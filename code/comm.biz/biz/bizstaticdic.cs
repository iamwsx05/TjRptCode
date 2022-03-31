using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace Common.Biz
{
    /// <summary>
    /// 静态(静态)字典
    /// </summary>
    public class BizStaticDic : IDisposable
    {
        #region 医嘱字典
        /// <summary>
        /// 医嘱字典
        /// </summary>
        /// <param name="orderType">1 长、临嘱； 2 草药； 3 检验、检查</param>
        /// <returns></returns>
        public List<EntityDicOrderInput> GetDicOrderInput(int orderType)
        {
            #region sql
            string SQL = string.Empty;
            string SqlSub = string.Empty;

            #region SQL2
            SqlSub = @"select a.item_code,
                               a.item_name as item_name,
                               a.xtbm,
                               a.xtmc,
                               a.xmbm,
                               a.xmmc,
                               b.standard,
                               b.small_unit,
                               b.ret_price,
                               a.gb_code,
                               a.py_code,
                               a.wb_code,
                               a.la_code,
                               a.gp_rate,
                               a.ap_rate,
                               a.item_cls,
                               a.price_flag,
                               a.big_flag,
                               b.dose,
                               b.dose_unit,
                               b.dire_code,
                               b.freq_code,
                               b.big_unit,
                               b.pack_rate,
                               a.esp_flag,
                               a.exp_flag,
                               a.mc_flag,
                               a.sp_flag,
                               a.disable,
                               a.loc_flag,
                               a.old_code,
                               c.dire_name,
                               d.freq_name
                          from code_item a
                         inner join plus_item b on a.item_code = b.item_code
                          left join code_direction c on b.dire_code = c.dire_code
                          left join code_frequency d on b.freq_code = d.freq_code
                         where (a.ip_flag = 'T' and b.type = '3')
                          ";
            #endregion

            if (orderType == 1)
            {
                #region 长、临嘱
                SQL = @"select a.item_code,
                               a.xtbm,
                               a.xtmc,
                               a.xmbm,
                               a.xmmc,
                               a.item_name as item_name,
                               b.standard,
                               b.small_unit,
                               b.ret_price,
                               a.gb_code,
                               a.py_code,
                               a.wb_code,
                               a.la_code,
                               a.gp_rate,
                               a.ap_rate,
                               a.item_cls,
                               a.price_flag,
                               a.big_flag,
                               b.dose,
                               b.dose_unit,
                               b.dire_code,
                               b.freq_code,
                               b.big_unit,
                               b.pack_rate,
                               a.esp_flag,
                               a.exp_flag,
                               a.mc_flag,
                               a.sp_flag,
                               a.disable,
                               a.loc_flag,
                               c.class,
                               c.pack_code,
                               a.ph_code,
                               a.kss_flag,
                               a.cls_flag,
                               a.drug_cls,
                               e.acct_rate,
                               a.old_code,
                               f.dire_name,
                               g.freq_name
                          from code_item a
                         inner join plus_item b on a.item_code = b.item_code
                          left join code_drugpack c on a.pack_code = c.pack_code
                          left join def_item_ratio e on a.item_code = e.item_code
                                                    and e.fee_code = '15'
                                                    and e.scope = '2'
                          left join code_direction f on b.dire_code = f.dire_code
                          left join code_frequency g on b.freq_code = g.freq_code
                         where (a.ip_flag = 'T' and b.type = '3' and (b.disable is null or b.disable = 'F'))
                           and (a.disable = 'F')
                           and (a.item_cls in ('1', '2', '4', '5', '6', '7', '8', '9'))
                        union all
                        select a.item_code,
                               a.xtbm,
                               a.xtmc,
                               a.xmbm,
                               a.xmmc,
                               d.alias_name as item_name,
                               b.standard,
                               b.small_unit,
                               b.ret_price,
                               a.gb_code,
                               d.py_code,
                               d.wb_code,
                               d.la_code,
                               a.gp_rate,
                               a.ap_rate,
                               a.item_cls,
                               a.price_flag,
                               a.big_flag,
                               b.dose,
                               b.dose_unit,
                               b.dire_code,
                               b.freq_code,
                               b.big_unit,
                               b.pack_rate,
                               a.esp_flag,
                               a.exp_flag,
                               a.mc_flag,
                               a.sp_flag,
                               a.disable,
                               a.loc_flag,
                               c.class,
                               c.pack_code,
                               a.ph_code,
                               a.kss_flag,
                               a.cls_flag,
                               a.drug_cls,
                               e.acct_rate,
                               a.old_code,
                               f.dire_name,
                               g.freq_name
                          from code_item a
                         inner join plus_item b on a.item_code = b.item_code
                         inner join alias_item d on a.item_code = d.item_code
                          left join code_drugpack c on a.pack_code = c.pack_code
                          left join def_item_ratio e on a.item_code = e.item_code
                                                    and e.fee_code = '15'
                                                    and e.scope = '2'
                          left join code_direction f on b.dire_code = f.dire_code
                          left join code_frequency g on b.freq_code = g.freq_code
                         where (a.ip_flag = 'T' and b.type = '3' and (b.disable is null or b.disable = 'F'))
                           and (a.disable = 'F')
                           and (a.item_cls in ('1', '2', '4', '5', '6', '7', '8', '9'))";
                #endregion
            }
            else if (orderType == 2)    // 草药
            {
                SQL = SqlSub + @" and (a.item_cls = '3')";
            }
            else if (orderType == 3)    // 检验、检查
            {
                SQL = SqlSub + @" and (a.item_cls = '4' or a.item_cls = '5')";
            }
            #endregion

            List<EntityDicOrderInput> data = new List<EntityDicOrderInput>();
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.GetDataTable(SQL);
                if (dt != null && dt.Rows.Count > 0)
                {
                    Dictionary<string, string> dicItemCls = new Dictionary<string, string>();
                    dicItemCls.Add("1", "西药");
                    dicItemCls.Add("2", "中成药");
                    dicItemCls.Add("3", "中草药");
                    dicItemCls.Add("4", "化验");
                    dicItemCls.Add("5", "检查");
                    dicItemCls.Add("6", "材料");
                    dicItemCls.Add("7", "治疗");
                    dicItemCls.Add("8", "医嘱");
                    dicItemCls.Add("9", "其它");

                    EntityDicOrderInput vo = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityDicOrderInput();
                        vo.itemCode = dr["item_code"].ToString();
                        vo.xtbm = (dr["xtbm"] == null ? string.Empty : dr["xtbm"].ToString().Trim());
                        vo.xtmc = (dr["xtmc"] == null ? string.Empty : dr["xtmc"].ToString().Trim());
                        vo.xmbm = (dr["xmbm"] == null ? string.Empty : dr["xmbm"].ToString().Trim());
                        vo.xmmc = (dr["xmmc"] == null ? string.Empty : dr["xmmc"].ToString().Trim());
                        vo.itemName = (dr["item_name"] == null ? string.Empty : dr["item_name"].ToString().Trim());
                        vo.standard = (dr["standard"] == null ? string.Empty : dr["standard"].ToString().Trim());
                        vo.smallUnit = dr["small_unit"].ToString();
                        vo.retPrice = Function.Dec(dr["ret_price"]).ToString("0.######");
                        vo.gbCode = dr["gb_code"].ToString();
                        vo.pyCode = dr["py_code"].ToString();
                        vo.wbCode = dr["wb_code"].ToString();
                        vo.laCode = dr["la_code"].ToString();
                        vo.gpRate = dr["gp_rate"].ToString();
                        vo.apRate = dr["ap_rate"].ToString();
                        vo.itemCls = dr["item_cls"].ToString();
                        if (!string.IsNullOrEmpty(vo.itemCls) && dicItemCls.ContainsKey(vo.itemCls)) vo.itemClsName = dicItemCls[vo.itemCls];
                        vo.priceFlag = dr["price_flag"].ToString();
                        vo.dose = (dr["dose"] == null ? string.Empty : Function.Dec(dr["dose"]).ToString("0.######"));
                        vo.doseUnit = (dr["dose_unit"] == null ? string.Empty : dr["dose_unit"].ToString().Trim());
                        vo.direCode = dr["dire_code"].ToString();
                        vo.freqCode = dr["freq_code"].ToString();
                        vo.bigUnit = dr["big_unit"].ToString();
                        vo.packRate = dr["pack_rate"].ToString();
                        vo.espFlag = dr["esp_flag"].ToString();
                        vo.expFlag = dr["exp_flag"].ToString();
                        vo.mcFlag = dr["mc_flag"].ToString();
                        vo.spFlag = dr["sp_flag"].ToString();
                        vo.disable = dr["disable"].ToString();
                        vo.locFlag = dr["loc_flag"].ToString();
                        vo.oldCode = dr["old_code"].ToString();
                        vo.bigFlag = dr["big_flag"].ToString();

                        vo.direName = dr["dire_name"].ToString();
                        vo.freqName = dr["freq_name"].ToString();
                        if (orderType == 1)
                        {
                            vo.packClass = dr["class"].ToString();
                            vo.packCode = dr["pack_code"].ToString();
                            vo.phCode = dr["ph_code"].ToString();
                            vo.antiLevel = Function.Int(dr["kss_flag"]);
                            vo.clsFlag = dr["cls_flag"].ToString();
                            vo.drugCls = dr["drug_cls"].ToString();
                            vo.acctRate = dr["acct_rate"].ToString();
                        }                        
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return data;
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
