using RptFunc.Entity;
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
            string sql = @"select * from (select b.reg_date,b.lnc_code, b.reg_no ,a.pat_name, 
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
                                            and b.lnc_code <> '0000' 
                                     union all 
                                     select  b.reg_date, b.lnc_code, b.reg_no,a.pat_name, 
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
                                            and b.lnc_code <> '0000' 
                                           and  b.active = 'T')  tmp where reg_date between ? and ?  and reg_no not in('220327820003','220327820002','220325820003')";
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
                    string pat_name = dr["pat_name"].ToString();
                    if (pat_name.Contains("1") || pat_name.Contains("-") || pat_name.Contains("2") || pat_name.Contains("4") || pat_name.Contains("测试"))
                        continue;
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
            List<EntityDwRs> dataRs = new List<EntityDwRs>();
            Dictionary<string, decimal> dicHj = new Dictionary<string, decimal>();
            List<string> lstLnc = new List<string>();
            
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);

            #region  SQL
            string sql = @"select * from (select b.reg_date,b.lnc_code, a.pat_name,
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
                                           and b.lnc_code <> '0000' 
                                     union all 
                                     select  b.reg_date, b.lnc_code, a.pat_name,
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
                                            and b.lnc_code <> '0000' 
                                           and  b.active = 'T')  tmp where reg_date between ? and ? and reg_no not in('220327820003','220327820002','220325820003') ";
            #endregion

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
            string regNo = string.Empty;
            string lnc_code = string.Empty;
            string lnc_name = string.Empty;
            decimal dj = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EntityTjdwgzfl vo = new EntityTjdwgzfl();
                    string pat_name = dr["pat_name"].ToString();
                    if (pat_name.Contains("1") || pat_name.Contains("-") || pat_name.Contains("2") || pat_name.Contains("4") || pat_name.Contains("测试"))
                        continue;
                    vo.zdrq = DateTime.Now.ToString("yyyy-MM-dd");
                    vo.pzbh = "";
                    lnc_code = dr["lnc_code"].ToString().Trim();
                    vo.lnc_code = lnc_code;
                    vo.lnc_name = dr["lnc_name"].ToString();
                    vo.fyfl = dr["fyfl"].ToString();
                    dj = Function.Dec((Function.Dec(dr["price1"]) * Function.Dec(dr["rate"])).ToString("0.00"));
                    if (string.IsNullOrEmpty(lnc_code))
                    {
                        vo.lnc_code = "0001";
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
                    #region 算人次
                    if (!lstLnc.Contains(vo.lnc_code))
                        lstLnc.Add(vo.lnc_code);  
                    
                    EntityDwRs voR = new EntityDwRs();
                    voR.lnc_code = vo.lnc_code;
                    voR.reg_no = dr["reg_no"].ToString();
                    if (!dataRs.Any(r => r.reg_no == voR.reg_no ))
                    {
                        dataRs.Add(voR);
                    }
 
                    #endregion

                }

                foreach (var vo in data)
                {
                    if (dicHj.ContainsKey(vo.lnc_code))
                    {
                        vo.hj = dicHj[vo.lnc_code];
                    }

                    vo.rs = dataRs.FindAll(r => r.lnc_code == vo.lnc_code).Count;
                }
            }

            return data;
        }
        #endregion

        #region 交款员收费明细
        /// <summary>
        /// GetTjSfJkmx
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjSfJkmx> GetTjSfJkmx(List<EntityParm> parms)
        {
            List<EntityTjSfJkmx> data = new List<EntityTjSfJkmx>();
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
                    mny = Function.Dec(dr["sum_ss"]);
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

                    if (classType == "1")
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

        #region 项目进度
        public List<EntityTjjdb> GetTjjdb(List<EntityParm> parms)
        {
            List<EntityTjjdb> data = new List<EntityTjjdb>();
            List<EntityTjjdb> tmp = new List<EntityTjjdb>();
            string lncCode = string.Empty;
            string lncName = string.Empty;
            string strSub = string.Empty;
            string regNo = string.Empty;
            string itemCode = string.Empty;
            Dictionary<string, string> dicComb = new Dictionary<string, string>();
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                #region sql
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
                                    f.comb_code,
                                    comb_name = (select comb_name from zdZhxm where comb_code = f.comb_code),
                                    cls_code = (select cls_code from zdzhxm where comb_code = f.comb_code),
                                    d.item_code,
                                    item_name = (select item_name from zdXm where item_code = d.item_code),
                                    d.rec_result,
                                    c.doct_name,
                                    e.chrg_flag
                                    from ywDjxx a 
                                    left join ywBrxx b
                                    on a.reg_times = b.reg_times and a.pat_code = b.pat_code
                                    left join ywTjxmzx f
                                    on a.reg_no = f.reg_no
                                    left join ywTjbgzx c
                                    on a.reg_no = c.reg_no and f.comb_code = c.comb_code
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
                #endregion

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
                            case "patName":
                                strSub += " and pat_name like '%" + po.value + "%'";
                                break;
                            case "regNo":
                                strSub += " and reg_no = '" + po.value + "'";
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
                                    if (string.IsNullOrEmpty(voClone.finishStr))
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
                                vo.flg = "已总检未审核";
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

                    tmp = data.OrderBy(t => t.flg).ToList();

                    string lastFlg = string.Empty;
                    string flg = string.Empty;
                    int index = 0;
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        flg = tmp[i].flg;
                        if (flg != lastFlg)
                        {
                            EntityTjjdb cloneVo = tmp.Find(r => r.reg_no == tmp[i].reg_no);
                            index = tmp.FindIndex(r => r.reg_no == tmp[i].reg_no);

                            EntityTjjdb voInsert = new EntityTjjdb();
                            voInsert.flg = flg;
                            voInsert.lnc_name = tmp.Count(r => r.flg == flg).ToString();
                            tmp.Insert(index, voInsert);
                            lastFlg = flg;
                        }
                    }
                    if (tmp.Count > 0)
                    {
                        EntityTjjdb voInsert = new EntityTjjdb();
                        voInsert.flg = "合计";
                        voInsert.lnc_name = tmp.FindAll(r => !string.IsNullOrEmpty(r.reg_no)).Count.ToString();
                        tmp.Insert(tmp.Count, voInsert);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Output("regNo-->" + regNo + "  itemCode-->" + itemCode);
                ExceptionLog.OutPutException(ex);
            }

            return tmp;
        }
        #endregion

        #region 异常报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityYcjgRpt> GetYcjgRpt(List<EntityParm> parms)
        {
            List<EntityYcjgRpt> data = new List<EntityYcjgRpt>();
            bool isGjz = false;

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string strSub = string.Empty;
                string sql = @"select e.lnc_name ,
                                   b.reg_no ,
                                   a.pat_name ,
                                   case a.sex
                                     when '1' then '男'
                                     when '2' then '女'
                                     else ''   end sex,
                                   a.age ,
                                   a.tel ,
                                   a.idcard ,
                                   d.comb_name ,
                                   c.res_tag 
                              from ywBrxx a
                              join ywDjxx b
                                on a.pat_code = b.pat_code and a.reg_times = b.reg_times
                              join ywTjbg c
                                on b.reg_no = c.reg_no
                              left join zdZhxm d
                                on c.comb_code = d.comb_code
                              left join zddw e
                                on b.lnc_code = e.lnc_code
                             where  b.reg_date >= ? and b.reg_date <= ? ";

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
                            case "xmfl":
                                strSub += " and (d.cls_code = '" + po.value + "')";
                                if (po.value != "06")
                                    isGjz = true;
                                break;
                            case "lncCode":
                                strSub += " and b.lnc_code = '" + po.value + "'";
                                break;
                            case "ycgjz":
                                strSub += " and (c.res_tag like '%" + po.value + "%')";
                                isGjz = true;
                                break;
                            case "ycgjzF":
                                strSub += " and (c.res_tag not like '%" + po.value + "%')";
                                isGjz = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                sql += strSub;

                if (!isGjz)
                {
                    sql += @" and c.rec_no in (select rec_no
                                                      from ywTjbgjgmx d
                                                 where ab_flag = 'T'
                                                    or isnull(hint, '') <> '')";
                }

                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityYcjgRpt vo = new EntityYcjgRpt();
                        vo.lnc_name = dr["lnc_name"].ToString();
                        vo.reg_no = dr["reg_no"].ToString();
                        vo.pat_name = dr["pat_name"].ToString();
                        vo.sex = dr["sex"].ToString();
                        vo.age = dr["age"].ToString();
                        vo.tel = dr["tel"].ToString();
                        vo.idcard = dr["idcard"].ToString();
                        vo.comb_name = dr["comb_name"].ToString();
                        vo.res_tag = dr["res_tag"].ToString();

                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }


            return data;
        }

        #endregion

        #region 职业健康检查人员名单及检查结果
        /// <summary>
        /// 职业健康检查人员名单及检查结果
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityZybRegRpt> GetZybRegRpt(List<EntityParm> parms)
        {
            List<EntityZybRegRpt> data = new List<EntityZybRegRpt>();
            bool isGjz = false;

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string strSub = string.Empty;
                string sql = @" select * from ( select b.job,
		                                 d.job_name,
                                         a.job_his_name,
		                                 a.p_status as pStatus,
                                         a.REG_NO,
		                                 a.flag,
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                 a.work_age,
		                                 a.work_age_m,
		                                 a.injury_age,
		                                 a.injury_age_m,
		                                 c.cls_code,
		                                 c.comb_code,
		                                 f.comb_name,
		                                 c.res_tag,
		                                 e.sugg_tag,
		                                 a.reg_date,
		                                 b.tel
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbgzx c,
		                                 ywTjbgzybsjg e,
		                                 zdzhxm f,
		                                 zdZy d
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO *= c.REG_NO
		                                and b.job = d.job_code
		                                and a.reg_no *= e.reg_no
		                                and c.comb_code = f.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
		                               and (a.reg_date between ? and ?)      
                                 union all
                                        select b.job,
		                                 d.job_name,
                                         a.job_his_name,
		                                 a.p_status as pStatus,
                                         a.REG_NO,
		                                 a.flag,
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                 a.work_age,
		                                 a.work_age_m,
		                                 a.injury_age,
		                                 a.injury_age_m,
		                                 c.cls_code,
		                                 c.comb_code,
		                                 f.comb_name,
		                                 c.res_tag,
		                                 e.sugg_tag,
		                                 a.reg_date,
		                                 b.tel
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbg c,
		                                 ywTjbgzybsjg e,
		                                 zdzhxm f,
		                                 zdZy d
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO *= c.REG_NO
		                                and b.job = d.job_code
		                                and a.reg_no *= e.reg_no
		                                and c.comb_code = f.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
                                        and a.flag in ('P','R')
		                                and (a.reg_date between ? and ?) )  tmp where reg_no <> ''
		                                

  ";

                List<IDataParameter> lstParm = new List<IDataParameter>();
                if (parms != null)
                {
                    foreach (var po in parms)
                    {
                        switch (po.key)
                        {
                            case "regDate":
                                IDataParameter[] parm = svc.CreateParm(4);
                                parm[0].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[0]);
                                parm[1].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[1]);
                                parm[2].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[2]);
                                parm[3].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[3]);
                                break;
                            case "xmfl":
                                strSub += " and cls_code = '" + po.value + "'";
                                if (po.value != "06")
                                    isGjz = true;
                                break;
                            case "lncCode":
                                strSub += " and lnc_code = '" + po.value + "'";
                                break;
                            case "regNo":
                                strSub += " and reg_no = '" + po.value + "'";
                                break;
                            case "ycgjz":
                                //strSub += " and c.res_tag like '%" + po.value + "%'";
                                isGjz = true;
                                break;
                            case "ycgjzF":
                                strSub += " and res_tag not like '%" + po.value + "%'";
                                isGjz = true;
                                break;

                            case "isSh":
                                strSub += " and flag in ('R', 'P')";
                                break;
                            default:
                                break;
                        }
                    }

                    string strSub2 = string.Empty;
                    foreach (var po in parms)
                    {
                        if (po.key == "ycgjz")
                        {
                            strSub2 += " res_tag like '%" + po.value + "%' or";
                        }
                    }
                    if (!string.IsNullOrEmpty(strSub2))
                    {
                        strSub2 = strSub2.TrimEnd('r');
                        strSub2 = strSub2.TrimEnd('o');
                        strSub2 = "and (" + strSub2 + ")";
                        sql += strSub2;
                    }


                }

                sql += strSub + "order  by reg_no";

                //if (!isGjz)
                //{

                //    sql += @" and rec_no in (select rec_no
                //                                      from ywTjbgjgmx d
                //                                 where d.ab_flag = 'T'
                //                                    or isnull(d.hint, '') <> '')";
                //}

                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                int n = 1;
                string lastRegNo = string.Empty;
                string regNo = string.Empty;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityZybRegRpt vo = new EntityZybRegRpt();
                        vo.reg_no = dr["reg_no"].ToString();
                        vo.pat_name = dr["pat_name"].ToString();
                        vo.idcard = dr["IDCARD"].ToString();
                        vo.sex = dr["sex"].ToString();
                        vo.age = dr["age"].ToString();
                        vo.tel = dr["tel"].ToString();
                        vo.idcard = dr["idcard"].ToString();
                        vo.pStatus = dr["pStatus"].ToString().Trim();
                        if (vo.pStatus == "01")
                            vo.pStatus = "上岗前";
                        if (vo.pStatus == "02")
                            vo.pStatus = "在岗期间";
                        if (vo.pStatus == "03")
                            vo.pStatus = "离岗";
                        if (vo.pStatus == "04")
                            vo.pStatus = "离岗后";
                        vo.job_whys = dr["job_his_name"].ToString();
                        vo.injury_age = dr["injury_age"].ToString() + "年" + dr["injury_age_m"].ToString() + "月";
                        vo.work_age = dr["work_age"].ToString() + "年" + dr["work_age_m"].ToString() + "月";
                        vo.comb_name = dr["comb_name"].ToString();
                        vo.res_tag = dr["res_tag"].ToString().Replace("", "");
                        vo.sugg_tag = dr["sugg_tag"].ToString();
                        regNo = vo.reg_no;
                        if (regNo != lastRegNo)
                        {
                            lastRegNo = regNo;
                            n = 1;
                        }

                        if (data.Any(r => r.reg_no == vo.reg_no))
                        {
                            EntityZybRegRpt cloneVo = data.Find(r => r.reg_no == vo.reg_no);
                            cloneVo.res_tag += (++n).ToString() + "、" + vo.comb_name + ":" + vo.res_tag + "\r\n";
                        }
                        else
                        {
                            vo.res_tag = n.ToString() + "、" + vo.comb_name + ":" + vo.res_tag + "\r\n";
                            data.Add(vo);
                        }
                    }

                    if (data != null && data.Count > 0)
                    {
                        foreach (EntityZybRegRpt vo in data)
                        {
                            vo.res_tag = vo.res_tag.TrimEnd('\n');
                            vo.res_tag = vo.res_tag.TrimEnd('\r');
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }


            return data;
        }
        #endregion

        #region 肺活量记录表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityFhljlRpt> GetFhljlRpts(List<EntityParm> parms)
        {
            List<EntityFhljlRpt> data = new List<EntityFhljlRpt>();
            string strSub = string.Empty;
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from (
                                        select 
                                         a.REG_NO,
		                                 a.reg_date,
                                         a.lnc_code,
		                                 lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                 c.cls_code,
		                                 c.comb_code,
		                                 e.comb_name,
		                                 d.item_code,
		                                 item_name = (select item_name from zdXm where item_code = d.item_code),
		                                 d.rec_result
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbgzx c,
		                                 ywTjbgjgmxzx d,
		                                 zdzhxm e
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO = c.REG_NO
		                                and c.rec_no = d.rec_no and c.comb_code = d.comb_code
		                                and c.comb_code = e.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
                                        and c.comb_code in('20002','50004')
                                        and (a.reg_date between ? and ?)	                       
                                        union all	                                
                                        select 
                                         a.REG_NO,
		                                 a.reg_date,
                                         a.lnc_code,
		                                 lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                 c.cls_code,
		                                 c.comb_code,
		                                 e.comb_name,
		                                 d.item_code,
		                                 item_name = (select item_name from zdXm where item_code = d.item_code),
		                                 d.rec_result
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbg c,
		                                 ywTjbgjgmx d,
		                                 zdzhxm e
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO = c.REG_NO
		                                and c.rec_no = d.rec_no and c.comb_code = d.comb_code
		                                and c.comb_code = e.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
                                        and c.comb_code in('20002','50004')
                                        and a.flag in ('P','R')
		                                and (a.reg_date between ? and ?) ) tmp where reg_no <> ''
		                                 ";


                List<IDataParameter> lstParm = new List<IDataParameter>();
                if (parms != null)
                {
                    foreach (var po in parms)
                    {
                        switch (po.key)
                        {
                            case "regDate":
                                IDataParameter[] parm = svc.CreateParm(4);
                                parm[0].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[0]);
                                parm[1].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[1]);
                                parm[2].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[2]);
                                parm[3].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[3]);
                                break;
                            case "lncCode":
                                strSub += " and lnc_code = '" + po.value + "'";
                                break;
                            case "patName":
                                strSub += " and pat_name like '%" + po.value + "%'";
                                break;
                            case "regNo":
                                strSub += " and reg_no = '" + po.value + "'";
                                break;
                            default:
                                break;
                        }
                    }
                }
                sql += strSub + Environment.NewLine + " order by reg_no";
                string item_code = string.Empty;
                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityFhljlRpt vo = new EntityFhljlRpt();
                        vo.reg_no = dr["reg_no"].ToString();
                        vo.lnc_name = dr["lnc_name"].ToString();
                        vo.pat_name = dr["pat_name"].ToString();
                        vo.idcard = dr["IDCARD"].ToString();
                        vo.sex = dr["sex"].ToString();
                        vo.age = dr["age"].ToString();
                        vo.idcard = dr["idcard"].ToString();
                        vo.reg_date = dr["reg_date"].ToString();
                        item_code = dr["item_code"].ToString().Trim();
                        if (data.Any(r => r.reg_no == vo.reg_no))
                        {
                            EntityFhljlRpt cloneVo = data.Find(r => r.reg_no == vo.reg_no);
                            if (item_code == "350003")
                                cloneVo.item_fvc = dr["rec_result"].ToString();
                            if (item_code == "350004")
                                cloneVo.item_fev = dr["rec_result"].ToString();
                            if (item_code == "350005")
                                cloneVo.item_fev2 = dr["rec_result"].ToString();
                            if (item_code == "350006")
                                cloneVo.item_fhl = dr["rec_result"].ToString();
                            if (item_code == "050025")
                                cloneVo.item_ty = dr["rec_result"].ToString();
                        }
                        else
                        {
                            if (item_code == "350003")
                                vo.item_fvc = dr["rec_result"].ToString();
                            if (item_code == "350004")
                                vo.item_fev = dr["rec_result"].ToString();
                            if (item_code == "350005")
                                vo.item_fev2 = dr["rec_result"].ToString();
                            if (item_code == "350006")
                                vo.item_fhl = dr["rec_result"].ToString();
                            if (item_code == "050025")
                                vo.item_ty = dr["rec_result"].ToString();
                            data.Add(vo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }

            return data;
        }
        #endregion

        #region 职业病结果报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityZybjgRpt> GetZybjgRpts(List<EntityParm> parms)
        {
            List<EntityZybjgRpt> data = new List<EntityZybjgRpt>();
            string strSub = string.Empty;
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from (
                                        select 
                                         a.REG_NO,
		                                 a.reg_date,
		                                   a.job_his_name,
		                                 a.p_status as pStatus,
                                         a.lnc_code,
		                                 lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                  a.work_age,
		                                 a.work_age_m,
		                                 a.injury_age,
		                                 a.injury_age_m,
		                                 e.cls_code,
		                                 c.comb_code,
		                                 e.comb_name,
		                                 c.res_tag,
		                                 d.sum_up,
		                                 d.sugg_tag
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbgzx c,
		                                 ywTjbgzybsjg d,
		                                 zdzhxm e
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO = c.REG_NO
                                        and a.reg_no *= d.reg_no
		                                and c.comb_code = e.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
                                        and a.reg_date between ? and ?
                                        union all	                                
                                        select 
                                         a.REG_NO,
		                                 a.reg_date,
		                                   a.job_his_name,
		                                 a.p_status as pStatus,
                                         a.lnc_code,
		                                 lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code),
		                                 b.PAT_NAME,
		                                 CASE b.SEX WHEN '1' THEN '男' WHEN '2' THEN '女' ELSE '/' END AS sex,
		                                 b.AGE,
		                                 b.IDCARD,
		                                  a.work_age,
		                                 a.work_age_m,
		                                 a.injury_age,
		                                 a.injury_age_m,
		                                 e.cls_code,
		                                 c.comb_code,
		                                 e.comb_name,
		                                 c.res_tag,
		                                 d.sum_up,
		                                 d.sugg_tag
                                FROM   ywDjxx a,
		                                 ywBrxx b,
		                                 ywTjbg c,
		                                 ywTjbgzybsjg d,
		                                 zdzhxm e
                                WHERE a.PAT_CODE = b.PAT_CODE and a.REG_TIMES = b.REG_TIMES 
		                                and a.REG_NO = c.REG_NO
		                                and a.reg_no = d.reg_no
		                                and c.comb_code = e.comb_code
		                                and a.p_flag  = 'T'
                                        and a.active = 'T'
                                        and a.flag in ('P','R')
                                        and a.reg_date between ? and ?
		                                 ) tmp where reg_no <> ''";

                List<IDataParameter> lstParm = new List<IDataParameter>();
                if (parms != null)
                {
                    foreach (var po in parms)
                    {
                        switch (po.key)
                        {
                            case "regDate":
                                IDataParameter[] parm = svc.CreateParm(4);
                                parm[0].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[0]);
                                parm[1].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[1]);
                                parm[2].Value = po.value.Split('|')[0];
                                lstParm.Add(parm[2]);
                                parm[3].Value = po.value.Split('|')[1];
                                lstParm.Add(parm[3]);
                                break;
                            case "lncCode":
                                strSub += " and lnc_code = '" + po.value + "'";
                                break;
                            case "patName":
                                strSub += " and pat_name like '%" + po.value + "%'";
                                break;
                            case "regNo":
                                strSub += " and reg_no = '" + po.value + "'";
                                break;
                            default:
                                break;
                        }
                    }
                }
                sql += strSub + Environment.NewLine + " order by reg_no";
                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityZybjgRpt vo = new EntityZybjgRpt();
                        vo.reg_no = dr["reg_no"].ToString();
                        vo.pat_name = dr["pat_name"].ToString();
                        vo.idcard = dr["IDCARD"].ToString();
                        vo.sex = dr["sex"].ToString();
                        vo.age = dr["age"].ToString();
                        //vo.tel = dr["tel"].ToString();
                        vo.idcard = dr["idcard"].ToString();
                        vo.pStatus = dr["pStatus"].ToString().Trim();
                        if (vo.pStatus == "01")
                            vo.pStatus = "上岗前";
                        if (vo.pStatus == "02")
                            vo.pStatus = "在岗期间";
                        if (vo.pStatus == "03")
                            vo.pStatus = "离岗";
                        if (vo.pStatus == "04")
                            vo.pStatus = "离岗后";
                        vo.job_whys = dr["job_his_name"].ToString();
                        vo.injury_age = Function.Int(dr["injury_age"]).ToString() + "年" + Function.Int(dr["injury_age_m"]).ToString() + "月";
                        vo.work_age = Function.Int(dr["work_age"]).ToString() + "年" + Function.Int(dr["work_age_m"]).ToString() + "月";
                        vo.cls_code = dr["cls_code"].ToString().Trim();
                        vo.comb_code = dr["comb_code"].ToString().Trim();
                        vo.comb_name = dr["comb_name"].ToString();
                        vo.res_tag = dr["res_tag"].ToString().Replace("", "");
                        vo.sugg_tag = dr["sugg_tag"].ToString();
                        vo.sum_up = dr["sum_up"].ToString();
                        //内科/神经
                        if (vo.comb_code == "20007" || vo.comb_code == "450010")
                            vo.item_nksj = vo.res_tag + "-->";
                        //眼科
                        else if (vo.cls_code == "04")
                            vo.item_ykyd = vo.res_tag + "-->";
                        //心电图
                        else if (vo.cls_code == "11")
                            vo.item_xdt = vo.res_tag + "-->";
                        //DR
                        else if (vo.cls_code == "07")
                            vo.item_xbdr = vo.res_tag + "-->";
                        //肺功能
                        else if (vo.cls_code == "35")
                            vo.item_fbjc = vo.res_tag + "-->";
                        //B超彩超
                        else if (vo.cls_code == "08")
                            vo.item_gdcc = vo.res_tag + "-->";
                        //lis
                        else if (vo.cls_code == "06")
                            vo.item_lis = vo.res_tag + "-->";
                        else
                            continue;

                        if (data.Any(r => r.reg_no == vo.reg_no))
                        {
                            EntityZybjgRpt cloneVo = data.Find(r => r.reg_no == vo.reg_no);
                            cloneVo.item_nksj += vo.item_nksj;
                            cloneVo.item_ykyd += vo.item_ykyd;
                            cloneVo.item_xdt += vo.item_xdt;
                            cloneVo.item_xbdr += vo.item_xbdr;
                            cloneVo.item_fbjc += vo.item_fbjc;
                            cloneVo.item_gdcc += vo.item_gdcc;
                            cloneVo.item_lis += vo.item_lis ;
                        }
                        else
                        {
                            List<EntityItemResult> lstResult = GetItemResult(vo.reg_no);
                            string result = string.Empty;
                            //血压
                            result = lstResult.Find(r=>r.reg_no == vo.reg_no && r.item_code == "010003").rec_result;
                            if (!string.IsNullOrEmpty(result))
                                vo.item_xy = result;
                            data.Add(vo);
                        } 
                    }
                    if (data != null && data.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            if (item.item_nksj.Contains("-->"))
                            {
                                item.item_nksj = item.item_nksj.TrimEnd('>');
                                item.item_nksj = item.item_nksj.TrimEnd('-');
                                item.item_nksj = item.item_nksj.TrimEnd('-');
                            }
                            if (item.item_ykyd.Contains("-->"))
                            {
                                item.item_ykyd = item.item_ykyd.TrimEnd('>');
                                item.item_ykyd = item.item_ykyd.TrimEnd('-');
                                item.item_ykyd = item.item_ykyd.TrimEnd('-');
                            }
                            if (item.item_xdt.Contains("-->"))
                            {
                                item.item_xdt = item.item_xdt.TrimEnd('>');
                                item.item_xdt = item.item_xdt.TrimEnd('-');
                                item.item_xdt = item.item_xdt.TrimEnd('-');
                            }
                            if (item.item_xbdr.Contains("-->"))
                            {
                                item.item_xbdr = item.item_xbdr.TrimEnd('>');
                                item.item_xbdr = item.item_xbdr.TrimEnd('-');
                                item.item_xbdr = item.item_xbdr.TrimEnd('-');
                            }
                            if (item.item_fbjc.Contains("-->"))
                            {
                                item.item_fbjc = item.item_fbjc.TrimEnd('>');
                                item.item_fbjc = item.item_fbjc.TrimEnd('-');
                                item.item_fbjc = item.item_fbjc.TrimEnd('-');
                            }
                            if (item.item_gdcc.Contains("-->"))
                            {
                                item.item_gdcc = item.item_gdcc.TrimEnd('>');
                                item.item_gdcc = item.item_gdcc.TrimEnd('-');
                                item.item_gdcc = item.item_gdcc.TrimEnd('-');
                            }
                            if (item.item_lis.Contains("-->"))
                            {
                                item.item_lis = item.item_lis.TrimEnd('>');
                                item.item_lis = item.item_lis.TrimEnd('-');
                                item.item_lis = item.item_lis.TrimEnd('-');
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }

            return data;
        }
        #endregion

        #region   获取项目结果
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regNo"></param>
        /// <returns></returns>
        internal List<EntityItemResult> GetItemResult(string regNo)
        {
            List<EntityItemResult> data = new List<EntityItemResult>();
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from (
                                select  a.reg_no,
                                a.comb_code,
                                b.item_code,
                                b.rec_result 
                                from ywTjbgzx a, 
                                ywTjbgjgmxzx b  
                                where a.rec_no = b.rec_no 
                                and a.reg_no = ?
                                union all
                                select a.reg_no,
                                a.comb_code,
                                b.item_code,
                                b.rec_result 
                                from ywTjbg a ,
                                ywTjbgjgmx b
                                where a.rec_no = b.rec_no 
                                and a.reg_no = ?) tmp ";

                if (string.IsNullOrEmpty(regNo))
                    return data;


                IDataParameter[] parm = svc.CreateParm(2);
                parm[0].Value = regNo;
                parm[1].Value = regNo;
                DataTable dt = svc.GetDataTable(sql, parm);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityItemResult vo = new EntityItemResult();
                        vo = Function.Row2Model<EntityItemResult>(dr);
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }

            return data;
        }
        #endregion

        #region 体检业务分类报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjywflRpt> GetTjywflRpts(List<EntityParm> parms)
        {
            List<EntityTjywflRpt> data = new List<EntityTjywflRpt>();
            string strSub = string.Empty;
            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"  SELECT b.job,
                                     job_name = (select job_name from zdZy where job_code = b.job),
	                                 a.reg_no,   
                                     b.pat_name,   
                                     sex = (case b.sex when '1' then '男' when '2' then '女' else '/' end),   
                                     b.age,   
                                     b.idcard,   
                                     b.tel,
                                     b.lnc_code, 
                                     lnc_name = (select lnc_name from zddw where lnc_code = a.lnc_code  ),
                                     a.reg_date,   
                                     a.flag,  
                                     a.c_flag,
                                     isnull(a.active,'F') as active,   
			                         isnull(a.f_flag,'F') as f_flag,
			                         sum_total_gr = isnull((select sum(isnull(aa.total,0.00))
						                            from ywCfmx aa,ywCf bb,ywSfcf d ,ywDjxx c 
						                            where aa.rec_no = bb.rec_no and bb.reg_no = c.reg_no and aa.chrg_no = d.chrg_no and bb.rec_no = d.rec_no and bb.reg_no = a.reg_no and bb.chrg_flag = 'T' and bb.class = '1'),0.00),
			                          yje = (select sum(total) from ywFyxm where reg_no = a.reg_no),
			                          pt_je = isnull((select SUM(rb_total) from ywTjxmzx where reg_no = a.reg_no and ISNULL(zyb_flag,'F') = 'F'),0) +
					                            isnull((select SUM(rb_total) from ywTjxm where reg_no = a.reg_no and ISNULL(zyb_flag,'F') = 'F'),0),
		                              zyb_je = isnull((select SUM(rb_total) from ywTjxmzx where reg_no = a.reg_no and ISNULL(zyb_flag,'F') = 'T'),0) +
					                            isnull((select SUM(rb_total) from ywTjxm where reg_no = a.reg_no and ISNULL(zyb_flag,'F') = 'T'),0)		
                                FROM ywDjxx a,   
                                     ywBrxx b  
                                WHERE a.pat_code = b.pat_code 
			                            and a.reg_times = b.reg_times 
			                            and isnull(a.delfee_flag,'F') <> 'T'  
			                            and a.active = 'T' 
                                        and a.lnc_code <> '0000'
                                        and a.flag <> 'Z'
			                            and a.reg_date between ? and ? ";
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
                                strSub += " and a.lnc_code = '" + po.value + "'";
                                break;
                            case "jobName":
                                strSub += " and b.job = '" + po.value + "'";
                                break;
                            default:
                                break;
                        }
                    }
                }
                sql += strSub + Environment.NewLine + " order by job_name,a.reg_date,a.reg_no";
                DataTable dt = svc.GetDataTable(sql, lstParm.ToArray());
                if (dt != null && dt.Rows.Count > 0)
                {
                    string jobName = string.Empty;
                    string lastJobName = string.Empty;
                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityTjywflRpt vo = new EntityTjywflRpt();
                        vo.tel = dr["tel"].ToString();
                        vo.job_name = dr["job_name"].ToString();
                        vo.reg_no = dr["reg_no"].ToString();
                        vo.pat_name = dr["pat_name"].ToString();
                        if (vo.pat_name.Contains("1") || vo.pat_name.Contains("-") || vo.pat_name.Contains("2") || vo.pat_name.Contains("4") || vo.pat_name.Contains("测试"))
                            continue;
                        vo.sex = dr["sex"].ToString();
                        vo.age = dr["age"].ToString();
                        vo.idcard = dr["idcard"].ToString();
                        vo.reg_date = dr["reg_date"].ToString();
                        vo.lnc_name = dr["lnc_name"].ToString();
                        vo.cFlag = dr["c_flag"].ToString().Trim();
                        vo.sumGr = Function.Dec(dr["pt_je"]) + Function.Dec(dr["zyb_je"]);
                        if (vo.cFlag == "1")
                            vo.cFlag = "团检";
                        else
                            vo.cFlag = "个检";

                        vo.fFlag = dr["f_flag"].ToString().Trim() ;
                        if (vo.fFlag == "F")
                            vo.fFlag = "未收费";
                        else
                            vo.fFlag = "已收费";
                        vo.status = dr["flag"].ToString().Trim();
                        if (vo.status == "P" || vo.status == "R")
                            vo.status = "已审核";
                        else if (vo.status == "S" )
                            vo.status = "已总检未审核";
                        else 
                            vo.status = "未总检未审核";
                        jobName = dr["job_name"].ToString().Trim();
                        if (data.Count == 0)
                            lastJobName = jobName;
                        if(lastJobName != jobName)
                        {
                            EntityTjywflRpt vo2 = new EntityTjywflRpt();
                            vo2.job_name = "合计";
                            vo2.reg_no = data.FindAll(r=>r.job_name == lastJobName).Count().ToString();
                            vo2.sumGr = Math.Round( data.FindAll(r => r.job_name == lastJobName).Sum(t => t.sumGr),2);
                            data.Add(vo2);
                            lastJobName = jobName;
                        }

                        data.Add(vo);
                    }

                    EntityTjywflRpt vo3 = new EntityTjywflRpt();
                    vo3.job_name = "合计";
                    vo3.reg_no = data.FindAll(r => r.job_name == jobName).Count().ToString();
                    vo3.sumGr = Math.Round(data.FindAll(r => r.job_name == lastJobName).Sum(t => t.sumGr),2);
                    data.Add(vo3);
                }
            }
            catch(Exception ex)
            {
                ExceptionLog.OutPutException(ex); 
            }

            return data;
        }
        #endregion

        #region 项目分类
        public List<EntityXmfl> GetZdXmfl()
        {
            List<EntityXmfl> data = new List<EntityXmfl>();

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from zdxmfl a where a.cls_code in ('02','03','04','05','06','07','08','09','11','15','18','49')";

                DataTable dt = svc.GetDataTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityXmfl vo = new EntityXmfl();
                        vo.cls_code = dr["cls_code"].ToString().Trim();
                        vo.cls_name = dr["cls_name"].ToString().Trim();
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


        #region 职业分类
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EntityZdzy> GetZdZy()
        {
            List<EntityZdzy> data = new List<EntityZdzy>();

            try
            {
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                string sql = @"select * from zdzy a";

                DataTable dt = svc.GetDataTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        EntityZdzy vo = new EntityZdzy();
                        vo.job_code = dr["job_code"].ToString().Trim();
                        vo.job_name = dr["job_name"].ToString().Trim();
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
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
