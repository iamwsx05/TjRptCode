﻿using RptFunc.Entity;
using RptFunc.Xtyy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace RptFunc.Biz
{
    public class BizRptFunc : IDisposable
    {

        #region 项目报表
        public List<EntityItemRpt> GetItemRpt(List<EntityParm> parms)
        {
            List<EntityItemRpt> data = new List<EntityItemRpt>();
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string sql = @"select * from (select b.reg_date,b.lnc_code, b.reg_no, 
                                     e.comb_code,e.cls_code,
                                     e.comb_name,
                                      deptName= (select dept_name from zdKs where dept_code = e.dept_code),
                                     d.price1, 
                                     d.rate,
                                     d.rb_total
                                     from ywBrxx a,ywDjxx b,ywTjxmzx d,zdZhxm e        
                                     where a.pat_code = b.pat_code and             
                                           a.reg_times = b.reg_times and        
                                           b.reg_no = d.reg_no and           
                                           d.comb_code = e.comb_code            
                                           and  b.active = 'T'
                                     union all 
                                     select  b.reg_date, b.lnc_code, b.reg_no, 
                                     e.comb_code,e.cls_code,
                                     e.comb_name,
                                     deptName= (select dept_name from zdKs where dept_code = e.dept_code),
                                     d.price1, 
                                     d.rate,
                                     d.rb_total     
                                     from ywBrxx a,ywDjxx b,ywTjxm d,zdZhxm e           
                                     where a.pat_code = b.pat_code and             
                                           a.reg_times = b.reg_times and        
                                           b.reg_no = d.reg_no and           
                                           d.comb_code = e.comb_code                   
                                           and  b.active = 'T')  tmp where reg_date between ? and ? ";
            List<IDataParameter> lstParm = new List<IDataParameter>();
            if (parms != null)
            {
                foreach (var po in parms)
                {
                    switch (po.key)
                    {
                        case "regDate":
                            IDataParameter parm1 = svc.CreateParm();
                            parm1.Value = po.value.Split('|')[0];
                            lstParm.Add(parm1);
                            IDataParameter parm2 = svc.CreateParm();
                            parm2.Value = po.value.Split('|')[1];
                            lstParm.Add(parm2);
                            break;
                        case "lncCode":
                            strSub += " and lnc_code = '" + po.value + "'";
                            break;
                        default:
                            break;
                    }
                }
            }
            sql += strSub;
            sql += " order by cls_code;";
            DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
            int n = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EntityItemRpt vo = new EntityItemRpt();

                    vo.itemCode = dr["comb_code"].ToString().Trim();
                    vo.itemName = dr["comb_name"].ToString().Trim();
                    vo.zk = (Function.Dec(dr["rate"]) * 100).ToString() + "%";
                    vo.zqdj = Function.Dec(dr["price1"]);
                    vo.zhdj = Function.Dec((vo.zqdj * Function.Dec(dr["rate"])).ToString("0.00"));
                    vo.kdks = "体检中心";
                    vo.zxks = dr["deptName"].ToString();
                    vo.bz = "";

                    if (data.Any(r => r.itemCode == vo.itemCode && r.zhdj == vo.zhdj))
                    {
                        EntityItemRpt voClone = data.Find(r => r.itemCode == vo.itemCode && r.zhdj == vo.zhdj);
                        voClone.tjrc++;
                        voClone.zqje += vo.zqdj;
                        voClone.zhje += vo.zhdj;
                    }
                    else
                    {
                        vo.xh = ++n;
                        vo.tjrc = 1;
                        vo.zqje = vo.zqdj;
                        vo.zhje = vo.zhdj;
                        data.Add(vo);
                    }
                }
            }

            return data;
        }
        #endregion

        #region  单位挂账报表
        /// <summary>
        /// GetTjgzflRpt
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjdwgzfl> GetTjgzflRpt(List<EntityParm> parms)
        {
            List<EntityTjdwgzfl> data = new List<EntityTjdwgzfl>();
            Dictionary<string, decimal> dicHj = new Dictionary<string, decimal>();
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string sql = @"select * from (select b.reg_date,b.lnc_code, 
									lnc_name = (select lnc_name from zddw where lnc_code = b.lnc_code),
									b.reg_no, 
                                     e.comb_code,e.cls_code,
                                     e.comb_name,
                                      deptName= (select dept_name from zdKs where dept_code = e.dept_code),
                                      e.basic_cls,
                                      fyfl  = (select cls_name from zdJcfl where cls_code = e.basic_cls),
                                     d.price1, 
                                     d.rate,
                                     d.rb_total
                                     from ywBrxx a,ywDjxx b,ywTjxmzx d,zdZhxm e        
                                     where a.pat_code = b.pat_code and             
                                           a.reg_times = b.reg_times and        
                                           b.reg_no = d.reg_no and           
                                           d.comb_code = e.comb_code            
                                           and  b.active = 'T'
                                     union all 
                                     select  b.reg_date, b.lnc_code, 
                                     lnc_name = (select lnc_name from zddw where lnc_code = b.lnc_code),
                                     b.reg_no, 
                                     e.comb_code,e.cls_code,
                                     e.comb_name,
                                     deptName= (select dept_name from zdKs where dept_code = e.dept_code),
                                     e.basic_cls,
                                     fyfl  = (select cls_name from zdJcfl where cls_code = e.basic_cls),
                                     d.price1, 
                                     d.rate,
                                     d.rb_total     
                                     from ywBrxx a,ywDjxx b,ywTjxm d,zdZhxm e           
                                     where a.pat_code = b.pat_code and             
                                           a.reg_times = b.reg_times and        
                                           b.reg_no = d.reg_no and           
                                           d.comb_code = e.comb_code                   
                                           and  b.active = 'T')  tmp where reg_date between ? and ?  ";
            List<IDataParameter> lstParm = new List<IDataParameter>();
            if (parms != null)
            {
                foreach (var po in parms)
                {
                    switch (po.key)
                    {
                        case "regDate":
                            IDataParameter[] parm = svc.CreateParm(2);
                            parm[0].Value = po.value.Split('|')[0];
                            lstParm.Add(parm[0]);
                            parm[1].Value = po.value.Split('|')[1];
                            lstParm.Add(parm[1]);
                            break;
                        case "lncCode":
                            strSub += " and lnc_code = '" + po.value + "'";
                            break;
                        default:
                            break;
                    }
                }
            }
            sql += strSub;
            DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
            int n = 0;
            string lnc_code = string.Empty;
            string lnc_name = string.Empty;
            decimal dj = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EntityTjdwgzfl vo = new EntityTjdwgzfl();

                    vo.zdrq = DateTime.Now.ToString("yyyy-MM-dd");
                    vo.pzbh = "";
                    lnc_code = dr["lnc_code"].ToString().Trim();
                    vo.lnc_code = lnc_code;
                    vo.lnc_name = dr["lnc_name"].ToString();
                    vo.fyfl = dr["fyfl"].ToString();
                    dj = Function.Dec((Function.Dec(dr["price1"]) * Function.Dec(dr["rate"])).ToString("0.00"));
                    if (string.IsNullOrEmpty(lnc_code))
                    {
                        vo.lnc_code = "999999";
                        vo.lnc_name = "个人体检";
                    }
                    if (data.Any(r => r.lnc_code == vo.lnc_code && r.fyfl == vo.fyfl))
                    {
                        EntityTjdwgzfl voClone = data.Find(r => r.lnc_code == vo.lnc_code && r.fyfl == vo.fyfl);
                        voClone.flhj += dj;
                    }
                    else
                    {
                        vo.flhj = dj;
                        vo.hj = dj;
                        data.Add(vo);
                    }

                    if (dicHj.ContainsKey(vo.lnc_code))
                    {
                        dicHj[vo.lnc_code] += dj;
                    }
                    else
                    {
                        dicHj.Add(vo.lnc_code, vo.hj);
                    }
                }

                foreach(var vo in data)
                {
                    if (dicHj.ContainsKey(vo.lnc_code))
                    {
                        vo.hj = dicHj[vo.lnc_code];
                        continue;
                    }
                }
            }

            return data;
        }
        #endregion

        #region 
        /// <summary>
        /// GetTjSfJkmx
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjSfJkmx> GetTjSfJkmx(List<EntityParm> parms)
        {
            List<EntityTjSfJkmx> data = new List<EntityTjSfJkmx>() ;
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string sql = @"select * from (SELECT ywSf.chrg_no,
	                               ywcf.class,
                                   ywSf.chrg_time,
                                   ywSf.oper_code,
                                   oper_name = (select oper_name from zdCzy where oper_code = ywsf.oper_code),
                                   CASE ywSf.status
                                              WHEN '1' THEN
                                               '收费'
                                              WHEN '2' THEN
                                               '作废'
                                              WHEN '3' THEN
                                               '冲红'
                                              ELSE
                                               '未知'
                                            END AS type_name,
                                   ywSf.rec_flag,
                                   ywSf.fee_code,
                                   ywSffp.invo_no,
                                   ywCf.pat_code,
                                   ywCf.pat_name,
                                   ywCf.reg_no,
                                   ywDjxx.p_flag,
                                   ywSf.pay_name,
                                   (SELECT SUM(total_sum) - SUM(acct_sum) - SUM(rb_sum) AS Expr1
                                      FROM ywSfmx
                                     WHERE (chrg_no = ywSf.chrg_no)) AS sum_ss
                              FROM ywSf
                              LEFT OUTER JOIN ywSffp
                                ON ywSf.chrg_no = ywSffp.chrg_no
                             INNER JOIN ywSfcf
                                ON ywSf.chrg_no = ywSfcf.chrg_no
                             INNER JOIN ywCf
                                ON ywSfcf.rec_no = ywCf.rec_no
                             INNER JOIN ywSfmx
                                ON ywSf.chrg_no = ywSfmx.chrg_no
                                left  join ywDjxx 
                                on ywcf.reg_no = ywDjxx.reg_no
                             WHERE (ywCf.class = '1')
                               AND (ywSf.chrg_date >= '2022.02.01')
                               AND (ywSf.chrg_date <= '2022.03.29')
                             GROUP BY ywSf.chrg_no,ywcf.class,ywSf.chrg_time,
                                      ywSf.oper_code,ywSf.rec_flag,ywSf.fee_code,
                                      ywSf.card_no,ywSffp.invo_no,ywCf.pat_code ,
                                      ywCf.pat_name,ywCf.reg_no,ywcf.class,
                                      ywSf.pay_name,ywDjxx.p_flag,ywSf.status
                            union all 
                            SELECT DISTINCT ywSf.chrg_no,
				                            ywcf.class,
                                            ywSf.chrg_time,
                                            ywSf.oper_code,
                                            oper_name = (select oper_name from zdCzy where oper_code = ywsf.oper_code),
				                            CASE ywSf.status
                                              WHEN '1' THEN
                                               '收费'
                                              WHEN '2' THEN
                                               '作废'
                                              WHEN '3' THEN
                                               '冲红'
                                              ELSE
                                               '未知'
                                            END AS type_name,
                                            ywSf.rec_flag,
                                            ywSf.fee_code,
                                            ywSffp.invo_no,
                                            zdDw.lnc_code as pat_code,
                                            zdDw.lnc_name as pat_name,
				                            ywCf.reg_no,
				                             ywDjxx.p_flag,
                                            ywsf.pay_name,
                                            (SELECT SUM(total_sum) - SUM(acct_sum) - SUM(rb_sum) AS Expr1
                                               FROM ywSfmx
                                              WHERE (chrg_no = ywSf.chrg_no)) AS sum_ss
                              FROM ywSf
                              LEFT OUTER JOIN ywSffp
                                ON ywSf.chrg_no = ywSffp.chrg_no
                             INNER JOIN ywSfcf
                                ON ywSf.chrg_no = ywSfcf.chrg_no
                             INNER JOIN ywFp
                                ON ywSf.chrg_no = ywFp.chrg_no
                             INNER JOIN ywCf
                                ON ywSfcf.rec_no = ywCf.rec_no
                             INNER JOIN zdDw
                                ON ywSf.lnc_code = zdDw.lnc_code
                             INNER JOIN ywSfmx
                                ON ywSf.chrg_no = ywSfmx.chrg_no
                                left  join ywDjxx 
                                on ywcf.reg_no = ywDjxx.reg_no
                             WHERE (ywCf.class = '3')
                               AND (ywSf.chrg_date >= '2020.01.29')
                               AND (ywSf.chrg_date <= '2022.03.29')
                             GROUP BY ywSf.chrg_no,ywSf.chrg_time,ywSf.oper_code,
                                      ywSf.rec_flag,ywSf.fee_code,ywSffp.invo_no,
                                      ywSf.pay_code,ywFp.pay_date,ywFp.pay_flag,
                                      ywFp.pay_oper,zdDw.lnc_code,zdDw.lnc_name,
		                              ywCf.reg_no,ywsf.pay_name,ywSf.total,ywcf.class,
                                      ywDjxx.p_flag,ywSf.status ) tmp ";
            List<IDataParameter> lstParm = new List<IDataParameter>();
            if (parms != null)
            {
                foreach (var po in parms)
                {
                    switch (po.key)
                    {
                        case "chrgDate":
                            IDataParameter[] parm = svc.CreateParm(2);
                            parm[0].Value = po.value.Split('|')[0] + " 00:00:00";
                            lstParm.Add(parm[0]);
                            parm[1].Value = po.value.Split('|')[1] + " 23:59:59";
                            lstParm.Add(parm[1]);
                            break;
                        default:
                            break;
                    }
                }
            }
            sql += strSub;
            DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
            int n = 0;
            string pay_name = string.Empty;
            string classType = string.Empty;
            decimal mny = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EntityTjSfJkmx vo = new EntityTjSfJkmx();
                    vo.oper_code = dr["oper_code"].ToString();
                    vo.oper_name = dr["oper_name"].ToString();
                    classType = dr["class"].ToString().Trim();
                    pay_name = dr["pay_name"].ToString().Trim();
                    mny= Function.Dec(dr["sum_ss"]);
                    if (pay_name == "现金")
                    {
                        vo.xjSl = 1;
                        vo.xjJe = mny;
                    }
                    else if (pay_name == "公众号" || pay_name == "微信")
                    {
                        vo.wxSl = 1;
                        vo.wxJe = mny;
                    }
                    else if (pay_name == "支付宝")
                    {
                        vo.zfbSl = 1;
                        vo.zfbJe = mny;
                    }
                    else if (pay_name == "银联卡")
                    {
                        vo.yhkSl = 1;
                        vo.yhkJe = mny;
                    }
                    else if (pay_name == "转账")
                    {
                        vo.zzSl = 1;
                        vo.zzJe = mny;
                    }

                    if(classType == "1")
                    {
                        vo.grHj = mny;
                    }
                    else
                    {
                        vo.jyHj = mny;
                    }
                    

                    if (data.Any(r => r.oper_code == vo.oper_code))
                    {
                        EntityTjSfJkmx cloneVo = data.Find(r => r.oper_code == vo.oper_code);

                        if (pay_name == "现金")
                        {
                            cloneVo.xjSl++;
                            cloneVo.xjJe += vo.xjJe;
                        }
                        else if (pay_name == "公众号" || pay_name == "微信")
                        {
                            cloneVo.wxSl++;
                            cloneVo.wxJe += vo.wxJe;
                        }
                        else if (pay_name == "支付宝")
                        {
                            cloneVo.zfbSl++;
                            cloneVo.zfbJe += vo.zfbJe;
                        }
                        else if (pay_name == "银联卡")
                        {
                            cloneVo.yhkSl++;
                            cloneVo.yhkJe += vo.yhkJe;
                        }
                        else if (pay_name == "转账")
                        {
                            cloneVo.zzSl++;
                            cloneVo.zzJe += vo.zzJe;
                        }

                        if (classType == "1")
                        {
                            cloneVo.grHj += mny;
                        }
                        else
                        {
                            cloneVo.jyHj += mny;
                        }
                    }
                    else
                    {
                        data.Add(vo);
                    }
                }
            }
            return data;
        }

        #endregion

        #region 单位
        public List<EntityDw> GetZdDw()
        {
            List<EntityDw> data = new List<EntityDw>();

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from zddw";

                DataTable dt = svc.GetDataTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityDw vo = Function.Row2Model<EntityDw>(dr);
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            return data;
        }
        #endregion

        #region 项目进度
        public List<EntityTjjdb> GetTjjdb(List<EntityParm> parms)
        {
            List<EntityTjjdb> data = new List<EntityTjjdb>();
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            string regNo = string.Empty;
            string itemCode = string.Empty;
            Dictionary<string, string> dicComb = new Dictionary<string, string>();
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from( select  a.active,a.flag,a.lnc_code,
                                    lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
                                    a.reg_date,
                                    a.reg_no,b.pat_name,a.his_patid as pat_code,
                                    case b.sex
                                    when 1 then '男'
                                    else '女' 
                                    end sex,
                                    c.comb_code,
                                    comb_name = (select comb_name from zdZhxm where comb_code = c.comb_code),
                                    cls_code = (select cls_code from zdzhxm where comb_code = c.comb_code),
                                    d.item_code,
                                    item_name = (select item_name from zdXm where item_code = d.item_code),
                                    d.rec_result,
                                    c.doct_name,
                                    e.chrg_flag
                                    from ywDjxx a 
                                    left join ywBrxx b
                                    on a.reg_times = b.reg_times and a.pat_code = b.pat_code
                                    inner join ywTjbg c
                                    on a.reg_no = c.reg_no
                                    left join ywTjbgjgmx d
                                    on c.rec_no = d.rec_no
                                    left join ywCf e
                                    on a.reg_no  = e.reg_no
                                    where a.reg_date between ? and ?
                                    union all
                                    select  a.active,a.flag,a.lnc_code,
                                    lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
                                    a.reg_date,
                                    a.reg_no,b.pat_name,a.his_patid as pat_code,
                                    case b.sex
                                    when 1 then '男'
                                    else '女' 
                                    end sex,
                                    c.comb_code,
                                    comb_name = (select comb_name from zdZhxm where comb_code = c.comb_code),
                                    cls_code = (select cls_code from zdzhxm where comb_code = c.comb_code),
                                    d.item_code,
                                    item_name = (select item_name from zdXm where item_code = d.item_code),
                                    d.rec_result,
                                    c.doct_name,
                                    e.chrg_flag
                                    from ywDjxx a 
                                    left join ywBrxx b
                                    on a.reg_times = b.reg_times and a.pat_code = b.pat_code
                                    inner join ywTjbgzx c
                                    on a.reg_no = c.reg_no
                                    left join ywTjbgjgmxzx d
                                    on c.rec_no = d.rec_no
                                    left join ywCf e
                                    on a.reg_no  = e.reg_no
                                    where a.reg_date between ? and ? 
                                    union all
                                    select  a.active,a.flag,a.lnc_code,
                                    lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
                                    a.reg_date,
                                    a.reg_no,b.pat_name,a.his_patid as pat_code,
                                    case b.sex
                                    when 1 then '男'
                                    else '女' 
                                    end sex,
                                    c.comb_code,
                                    comb_name = (select comb_name from zdZhxm where comb_code = c.comb_code),
                                    cls_code = (select cls_code from zdzhxm where comb_code = c.comb_code),
                                    '' as item_code,
                                    '' as item_name ,
                                    '' as rec_result,
                                    '' as doct_name,
                                    '' as chrg_flag
                                    from ywDjxx a 
                                    left join ywBrxx b
                                    on a.reg_times = b.reg_times and a.pat_code = b.pat_code
                                    left join ywTjxmzx c
                                    on a.reg_no = c.reg_no
                                    where a.reg_date between ? and ? and (a.active = 'F' or a.active is null) ) tmp where cls_code not in ('90') ";
                List<IDataParameter> lstParm = new List<IDataParameter>();
                if (parms != null)
                {
                    foreach (var po in parms)
                    {
                        switch (po.key)
                        {
                            case "regDate":
                                IDataParameter[] parm = svc.CreateParm(6);
                                parm[0].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[0]);
                                parm[1].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[1]);
                                parm[2].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[2]);
                                parm[3].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[3]);
                                parm[4].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[4]);
                                parm[5].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[5]);
                                break;
                            case "lncCode":
                                strSub += " and lnc_code = '" + po.value + "'";
                                break;
                            default:
                                break;
                        }
                    }
                }
                sql += strSub;
                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                int n = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    string chrFlag = string.Empty;
                    string active = string.Empty;
                    string flag = string.Empty;
                    foreach (DataRow dr in dt.Rows)
                    {
                        //C 已核对 S已总检 R 已审核 P已打印
                        EntityTjjdb vo = new EntityTjjdb();
                        active = dr["active"].ToString().Trim();
                        vo.lnc_name = dr["lnc_name"].ToString();
                        vo.reg_date = dr["reg_date"].ToString().Trim();
                        vo.reg_no = dr["reg_no"].ToString().Trim();
                        regNo = vo.reg_no;
                        vo.pat_name = dr["pat_name"].ToString().Trim();
                        vo.pat_code = dr["pat_code"].ToString().Trim();
                        vo.sex = dr["sex"].ToString().Trim();
                        vo.comb_code = dr["comb_code"].ToString().Trim();
                        vo.comb_name = dr["comb_name"].ToString().Trim();
                        vo.item_code = dr["item_code"].ToString().Trim();
                        itemCode = vo.item_code;
                        vo.rec_result = dr["rec_result"].ToString().Trim();
                        vo.doct_name = dr["doct_name"].ToString().Trim();
                        flag = dr["flag"].ToString();
                        chrFlag = dr["chrg_flag"].ToString().Trim();

                        if (data.Any(r => r.reg_no == vo.reg_no))
                        {
                            EntityTjjdb voClone = data.Find(r => r.reg_no == vo.reg_no);

                            if (dicComb.ContainsKey(vo.reg_no))
                            {
                                string comb = dicComb[voClone.reg_no];
                                if (!comb.Contains(vo.comb_name))
                                {
                                    voClone.combCount++;
                                    dicComb[voClone.reg_no] += "、" + vo.comb_name;
                                }
                            }
                            if (flag == "C" || flag == "S" || flag == "R" || flag == "P")
                                continue;
                            else if (voClone.flg == "未完成")
                            {
                                if (string.IsNullOrEmpty(vo.doct_name))
                                {
                                    if( string.IsNullOrEmpty(voClone.finishStr))
                                    {
                                        voClone.unCombCount = 1;
                                        voClone.finishStr = "未完成-->" + vo.comb_name;
                                    }
                                    else if (!voClone.finishStr.Contains(vo.comb_name))
                                    {
                                        voClone.unCombCount += 1;
                                        voClone.finishStr += "-->" + vo.comb_name;
                                    } 
                                }
                            }
                            else if (voClone.flg == "未开始体检")
                            {
                                if (string.IsNullOrEmpty(voClone.finishStr))
                                {
                                    voClone.unCombCount = 1;
                                    voClone.finishStr = "未开始体检-->" + vo.comb_name;
                                }
                                else if (!voClone.finishStr.Contains(vo.comb_name))
                                {
                                    voClone.unCombCount += 1;
                                    voClone.finishStr += "-->" + vo.comb_name;
                                }
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(chrFlag) || chrFlag == "F")
                                vo.chrg_flag = "未缴费";
                            if (string.IsNullOrEmpty(active) || active == "F")
                                vo.active = "未开始体检";
                            vo.combCount = 1;
                            if (flag == "C")
                            {
                                vo.flg = "已核对";
                                vo.finishStr = "已完成所有体检-->未完成总检-->未审核报告";
                            }
                            else if (flag == "S")
                            {
                                vo.flg = "已总检";
                                vo.finishStr = "已完成所有体检-->已完成总检-->未审核报告";
                            }
                            else if (flag == "R" || flag == "P")
                            {
                                vo.flg = "已审核";
                                vo.finishStr = "已完成所有体检-->已完成总检-->已审核报告";
                            }
                            else if (active == "T")
                            {
                                vo.flg = "未完成";
                                if (string.IsNullOrEmpty(vo.doct_name))
                                {
                                    vo.unCombCount = 1;
                                    vo.finishStr = "未完成-->" + vo.comb_name;
                                }
                            }
                            else if (string.IsNullOrEmpty(active) || active == "F")
                            {
                                vo.flg = "未开始体检";
                                vo.unCombCount = 1;
                                vo.finishStr = "未开始体检-->" + vo.comb_name;
                            }
                            dicComb.Add(vo.reg_no, vo.comb_name);
                            data.Add(vo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Output("regNo-->" + regNo + "  itemCode-->" + itemCode);
                ExceptionLog.OutPutException(ex);
            }

            return data;
        }
        #endregion

        #region GetYwdjxx
        internal EntityYwDjxx GetYwdjxx(string regNo)
        {
            EntityYwDjxx vo = null;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string sql = @"select * from ywdjxx where reg_no = '{0}'";
            sql = string.Format(sql, regNo);
            DataTable dt = svc.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                vo = new EntityYwDjxx();
                vo.reg_no = dt.Rows[0]["reg_no"].ToString();
                vo.reg_date = dt.Rows[0]["reg_date"].ToString();
            }


            return vo;
        }
        #endregion

        #region GetZdzh
        internal List<EntityZdzh> GetZdzh()
        {
            List<EntityZdzh> data = new List<EntityZdzh>();
            try
            {
                string sql = "select * from zdzhxm where inst_flag = 'T'";

                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityZdzh vo = Function.Row2Model<EntityZdzh>(dr);
                        vo.comb_code = vo.comb_code.Trim();
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return data;
        }
        #endregion

        #region GetDyTjyjymxxm
        internal List<EntityDyTjyjymxxm> GetDyTjyjymxxm()
        {
            List<EntityDyTjyjymxxm> lstDyTjjy = new List<EntityDyTjyjymxxm>();

            try
            {
                string sql = "select * from dyTjyjymxxm ";

                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityDyTjyjymxxm vo = Function.Row2Model<EntityDyTjyjymxxm>(dr);
                        lstDyTjjy.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return lstDyTjjy;
        }
        #endregion

        #region 本地参数配置
        /// <summary>
        /// 本地参数配置
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        public List<EntityAppConfig> GetAppConfig(EntityPC pc)
        {
            string SQL = string.Empty;
            List<EntityAppConfig> lstSetting = new List<EntityAppConfig>();
            SqlHelper objSvc = new SqlHelper(EnumBiz.onlineDB);
            DataTable dt = null;

            try
            {
                string SQL1 = @"select t.typeid, t.setting
                                  from sysLocalsetting t
                                 where t.status = 1 
                                   ";
                IDataParameter[] objParamArr = null;
                if (!string.IsNullOrEmpty(pc.EmpNo))
                {
                    SQL += SQL1 + @"and t.typeid = 3
                                    and t.empno = ?";
                    objParamArr = objSvc.CreateParm(1);
                    objParamArr[0].Value = pc.EmpNo;
                    dt = objSvc.GetDataTable(SQL, objParamArr);

                    // 个人.优先
                    GetSetingArr(ref lstSetting, dt);
                }

                SQL = SQL1 + @"and t.typeid = 2
                               and (t.machinename = ? or t.ipaddr = ? or
                                    t.macaddr = ?)";
                objParamArr = objSvc.CreateParm(3);
                objParamArr[0].Value = pc.MachineName;
                objParamArr[1].Value = pc.IpAddr;
                objParamArr[2].Value = pc.MacAddr;
                dt = objSvc.GetDataTable(SQL, objParamArr);

                // 本机.其次
                GetSetingArr(ref lstSetting, dt);

                SQL = SQL1 + @"and t.typeid = 1";
                dt = objSvc.GetDataTable(SQL);

                // 公用.再次
                GetSetingArr(ref lstSetting, dt);
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                objSvc = null;
            }

            return lstSetting;
        }

        /// <summary>
        /// GetSetingArr
        /// </summary>
        /// <param name="lstSetting"></param>
        /// <param name="dt"></param>
        private void GetSetingArr(ref List<EntityAppConfig> lstSetting, DataTable dt)
        {
            List<string> lstNode = new List<string>() { "Service" };
            System.Xml.XmlNodeList nodeList = null;
            System.Xml.XmlNode node = null;
            EntityAppConfig vo = null;

            string xml = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["setting"] != DBNull.Value && !string.IsNullOrEmpty(dr["setting"].ToString()))
                {
                    xml = "<Main>" + Environment.NewLine + dr["setting"].ToString().Replace("<Parms>", "").Replace("</Parms>", "") + Environment.NewLine + "</Main>";

                    foreach (string nodeName in lstNode)
                    {
                        nodeList = Function.ReadXML(xml, nodeName);

                        if (nodeList != null)
                        {
                            for (int i = 0; i < nodeList.Count; i++)
                            {
                                node = nodeList.Item(i);
                                if (node.Attributes == null)
                                {
                                    continue;
                                }

                                vo = new EntityAppConfig();
                                vo.Node = nodeName;
                                vo.Module = node.Attributes["module"].Value.Trim();
                                vo.Name = node.Attributes["name"].Value.Trim();
                                vo.Text = node.Attributes["text"].Value.Trim();
                                vo.Value = node.Attributes["value"].Value.Trim();

                                if (lstSetting.Exists(t => t.Node == vo.Node && t.Module == vo.Module && t.Name == vo.Name))
                                {
                                    continue;
                                }
                                else
                                {
                                    lstSetting.Add(vo);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
