using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Xtyy
{
    public class EntityHisItem
    {
        public string hisItemCode { get; set; }
        public string hisItemName { get; set; }
        public string hisItemUnit { get; set; }
        public decimal hisItemPrice { get; set; }
        public string mec_name { get; set; }
    }

    public class EntityTjItem
    {
        public string tjItemCode { get; set; }
        public string tjItemName { get; set; }
        public decimal tjItemPrice { get; set; }

        public string hisItemCode { get; set; }
    }

    public class EntitySysTj
    {
        public string sysItemCode { get; set; }
        public string sysItemName { get; set; }
        public decimal sysItemPrice { get; set; }
        public string hisCode { get; set; }
    }



    public class EntityZdzhDlt
    {
        public string clsName { get; set; }
        public string combCode { get; set; }
        public string combName { get; set; }
        public decimal price { get; set; }
        public string hisItemCode { get; set; }
        public string hisName { get; set; }
        public decimal hisPrice { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
    }


    public class EntityTcDlt
    {
        public string clusCode { get; set; }
        public string clusName { get; set; }
        public decimal price { get; set; }
        public string combCode { get; set; }
        public string combName { get; set; }
        public string instFlg { get; set; }
    }


    public class EntityTcZhDlt
    {
        public string clusCode { get; set; }
        public string clusName { get; set; }
        public decimal price { get; set; }
        public string combCode { get; set; }
        public string combName { get; set; }
        public string hisItemCode { get; set; }
        public string hisName { get; set; }
        public decimal hisPrice { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }

    }
    public class EntityCzy
    {
        public string operCode { get; set; }
        public string operName { get; set; }
        public string sex { get; set; }
        public string srf { get; set; }
        public string pwd { get; set; }
        public string disable { get; set; }
        public string userId { get; set; }
        public string pyCode { get; set; }
        public string wbCode { get; set; }

    }



    public class EntityHisTj
    {
        public string combCode { get; set; }
        public string combName { get; set; }
        public string hisCode { get; set; }
        public decimal price { get; set; }
    }

    public class EntityDyTjHis
    {
        public string peCombCode { get; set; }
        public string hisItemCode { get; set; }
    }



    public class EntityPeItem
    {
        public string comb_code { get; set; }
        public string comb_name { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string rec_result { get; set; }
        public string ref_lower { get; set; }
        public string ref_uppper { get; set; }
        public string refLowUp { get; set; }

        public string lisCode { get; set; }
    }

    public class EntityLisItem
    {
        public string lisCode { get; set; }
        public string lisName { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string result { get; set; }
        public string refLow { get; set; }
        public string refUp { get; set; }
        public string tip { get; set; }
        public string unit { get; set; }
        public string oper { get; set; }
        public string resultTime { get; set; }
        public string refLowUp { get; set; }
    }


    /// <summary>
    /// EntityYwDjxx
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ywDjxx")]
    public class EntityYwDjxx : BaseDataContract
    {
        /// <summary>
        /// reg_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_no", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String reg_no { get; set; }

        /// <summary>
        /// pat_code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pat_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String pat_code { get; set; }

        /// <summary>
        /// reg_times
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 reg_times { get; set; }

        /// <summary>
        /// reg_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String reg_date { get; set; }

        /// <summary>
        /// reg_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String reg_time { get; set; }

        /// <summary>
        /// hosp_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hosp_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String hosp_no { get; set; }

        /// <summary>
        /// as_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "as_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String as_no { get; set; }

        /// <summary>
        /// total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? total { get; set; }

        /// <summary>
        /// tab_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tab_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String tab_type { get; set; }

        /// <summary>
        /// rep_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rep_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String rep_type { get; set; }

        /// <summary>
        /// flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String flag { get; set; }

        /// <summary>
        /// b_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "b_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String b_flag { get; set; }

        /// <summary>
        /// p_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "p_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String p_flag { get; set; }

        /// <summary>
        /// c_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "c_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String c_flag { get; set; }

        /// <summary>
        /// s_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "s_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String s_flag { get; set; }

        /// <summary>
        /// r_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "r_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String r_flag { get; set; }

        /// <summary>
        /// f_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "f_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String f_flag { get; set; }

        /// <summary>
        /// rec_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rec_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String rec_date { get; set; }

        /// <summary>
        /// rec_status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rec_status", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String rec_status { get; set; }

        /// <summary>
        /// rec_num
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rec_num", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Int32? rec_num { get; set; }

        /// <summary>
        /// con_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "con_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String con_oper { get; set; }

        /// <summary>
        /// p_status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "p_status", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String p_status { get; set; }

        /// <summary>
        /// res_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "res_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String res_oper { get; set; }

        /// <summary>
        /// n_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "n_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String n_flag { get; set; }

        /// <summary>
        /// check_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "check_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String check_date { get; set; }

        /// <summary>
        /// check_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "check_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String check_oper { get; set; }

        /// <summary>
        /// exam_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "exam_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String exam_oper { get; set; }

        /// <summary>
        /// recheck_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recheck_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String recheck_no { get; set; }

        /// <summary>
        /// active
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "active", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String active { get; set; }

        /// <summary>
        /// register_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "register_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String register_date { get; set; }

        /// <summary>
        /// sync_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sync_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String sync_flag { get; set; }

        /// <summary>
        /// txm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "txm", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Int32? txm { get; set; }

        /// <summary>
        /// fee_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fee_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String fee_flag { get; set; }

        /// <summary>
        /// l_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "l_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String l_flag { get; set; }

        /// <summary>
        /// l_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "l_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String l_type { get; set; }

        /// <summary>
        /// j_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "j_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String j_flag { get; set; }

        /// <summary>
        /// active_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "active_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String active_time { get; set; }

        /// <summary>
        /// h_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "h_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String h_flag { get; set; }

        /// <summary>
        /// reqprint_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reqprint_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String reqprint_flag { get; set; }

        /// <summary>
        /// lnc_code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lnc_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String lnc_code { get; set; }

        /// <summary>
        /// fee_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fee_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String fee_type { get; set; }

        /// <summary>
        /// clus_total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clus_total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.Decimal? clus_total { get; set; }

        /// <summary>
        /// other_total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "other_total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.Decimal? other_total { get; set; }

        /// <summary>
        /// salesman
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "salesman", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.String salesman { get; set; }

        /// <summary>
        /// history
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "history", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.String history { get; set; }

        /// <summary>
        /// net_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "net_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 47)]
        public System.String net_flag { get; set; }

        /// <summary>
        /// net_login
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "net_login", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 48)]
        public System.String net_login { get; set; }

        /// <summary>
        /// net_password
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "net_password", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 49)]
        public System.String net_password { get; set; }

        /// <summary>
        /// vip
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vip", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 50)]
        public System.String vip { get; set; }

        /// <summary>
        /// rz_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rz_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 51)]
        public System.String rz_flag { get; set; }

        /// <summary>
        /// frist_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "frist_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 52)]
        public System.String frist_oper { get; set; }

        /// <summary>
        /// frist_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "frist_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 53)]
        public System.String frist_time { get; set; }

        /// <summary>
        /// last_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "last_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 54)]
        public System.String last_oper { get; set; }

        /// <summary>
        /// last_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "last_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 55)]
        public System.String last_time { get; set; }

        /// <summary>
        /// print_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "print_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 56)]
        public System.String print_oper { get; set; }

        /// <summary>
        /// print_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "print_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 57)]
        public System.String print_time { get; set; }

        /// <summary>
        /// print_cs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "print_cs", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 58)]
        public System.Int32? print_cs { get; set; }

        /// <summary>
        /// hletter_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hletter_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 59)]
        public System.String hletter_flag { get; set; }

        /// <summary>
        /// limit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "limit", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 60)]
        public System.Decimal? limit { get; set; }

        /// <summary>
        /// urgent_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "urgent_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 61)]
        public System.String urgent_flag { get; set; }

        /// <summary>
        /// check_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "check_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 62)]
        public System.String check_flag { get; set; }

        /// <summary>
        /// lockfee_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockfee_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 63)]
        public System.String lockfee_flag { get; set; }

        /// <summary>
        /// lockfee_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockfee_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 64)]
        public System.String lockfee_date { get; set; }

        /// <summary>
        /// delfee_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "delfee_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 65)]
        public System.String delfee_flag { get; set; }

        /// <summary>
        /// delfee_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "delfee_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 66)]
        public System.String delfee_date { get; set; }

        /// <summary>
        /// delfee_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "delfee_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 67)]
        public System.String delfee_oper { get; set; }

        /// <summary>
        /// delfee_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "delfee_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 68)]
        public System.String delfee_time { get; set; }

        /// <summary>
        /// work_age
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "work_age", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 69)]
        public System.String work_age { get; set; }

        /// <summary>
        /// injury_age
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "injury_age", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 70)]
        public System.String injury_age { get; set; }

        /// <summary>
        /// fc_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 71)]
        public System.String fc_flag { get; set; }

        /// <summary>
        /// fc_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 72)]
        public System.String fc_date { get; set; }

        /// <summary>
        /// fc_note
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_note", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 73)]
        public System.String fc_note { get; set; }

        /// <summary>
        /// fc_send
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_send", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 74)]
        public System.String fc_send { get; set; }

        /// <summary>
        /// fc_send_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_send_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 75)]
        public System.String fc_send_oper { get; set; }

        /// <summary>
        /// fc_send_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fc_send_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 76)]
        public System.String fc_send_time { get; set; }

        /// <summary>
        /// report_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "report_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 77)]
        public System.String report_type { get; set; }

        /// <summary>
        /// film_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 78)]
        public System.String film_type { get; set; }

        /// <summary>
        /// film_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 79)]
        public System.String film_date { get; set; }

        /// <summary>
        /// film_note
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_note", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 80)]
        public System.String film_note { get; set; }

        /// <summary>
        /// film_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 81)]
        public System.String film_oper { get; set; }

        /// <summary>
        /// film_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 82)]
        public System.String film_time { get; set; }

        /// <summary>
        /// film_get_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_get_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 83)]
        public System.String film_get_oper { get; set; }

        /// <summary>
        /// film_get_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_get_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 84)]
        public System.String film_get_time { get; set; }

        /// <summary>
        /// film_send_oper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_send_oper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 85)]
        public System.String film_send_oper { get; set; }

        /// <summary>
        /// film_send_time
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "film_send_time", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 86)]
        public System.String film_send_time { get; set; }

        /// <summary>
        /// room_code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "room_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 87)]
        public System.String room_code { get; set; }

        /// <summary>
        /// phone
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "phone", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 88)]
        public System.String phone { get; set; }

        /// <summary>
        /// recovery_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recovery_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 89)]
        public System.String recovery_flag { get; set; }

        /// <summary>
        /// kj_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "kj_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 90)]
        public System.String kj_flag { get; set; }

        /// <summary>
        /// contract
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contract", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 91)]
        public System.String contract { get; set; }

        /// <summary>
        /// critical_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "critical_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 92)]
        public System.String critical_flag { get; set; }

        /// <summary>
        /// followUp_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "followUp_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 93)]
        public System.String followUp_flag { get; set; }

        /// <summary>
        /// followUp_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "followUp_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 94)]
        public System.String followUp_date { get; set; }

        /// <summary>
        /// followUp_type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "followUp_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 95)]
        public System.String followUp_type { get; set; }

        /// <summary>
        /// out_falg
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "out_falg", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 96)]
        public System.String out_falg { get; set; }

        /// <summary>
        /// emer_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "emer_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 97)]
        public System.String emer_flag { get; set; }

        /// <summary>
        /// work_age_m
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "work_age_m", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 98)]
        public System.String work_age_m { get; set; }

        /// <summary>
        /// injury_age_m
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "injury_age_m", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 99)]
        public System.String injury_age_m { get; set; }

        /// <summary>
        /// xs_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xs_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 100)]
        public System.String xs_flag { get; set; }

        /// <summary>
        /// xs_id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xs_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 101)]
        public System.String xs_id { get; set; }

        /// <summary>
        /// wc_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wc_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 102)]
        public System.String wc_flag { get; set; }

        /// <summary>
        /// fhcs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fhcs", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 103)]
        public System.String fhcs { get; set; }

        /// <summary>
        /// kj_date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "kj_date", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 104)]
        public System.String kj_date { get; set; }

        /// <summary>
        /// zyb_gen_flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "zyb_gen_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 105)]
        public System.String zyb_gen_flag { get; set; }

        /// <summary>
        /// pay_card_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pay_card_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 106)]
        public System.String pay_card_no { get; set; }

        /// <summary>
        /// sort_no
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sort_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 107)]
        public System.String sort_no { get; set; }

        /// <summary>
        /// Columns
        /// </summary>

    }

    public class EntityPatinfo
    {
        public string lismain_repno { get; set; }
        public string lismain_order_ids { get; set; }
        public string patInNo { get; set; }
        public string lismain_rep_name { get; set; }
    }

    public class EntityResultInfo
    {
        public string lisresult_repno { get; set; }
        public string lisresult_order_id { get; set; } //220301880546_900371</lisresult_order_id>
        public string lisresult_item_id { get; set; } //10022</lisresult_item_id>
        public string lisresult_item_cname { get; set; }  //尿糖</lisresult_item_cname>
        public string llisresult_result { get; set; } //<![CDATA[正常]]></llisresult_result>
        public string lisresult_ref_range { get; set; } //<![CDATA[正常]]></lisresult_ref_range>
        public string lisresult_unit { get; set; } //
        public string lisresult_refflag { get; set; } //阴性</lisresult_refflag>
        public string lisresult_time { get; set; }    //2022-3-3 9:07:25</lisresult_time>
        public string lisresult_ref_max { get; set; } //<![CDATA[]]></lisresult_ref_max>
        public string lisresult_ref_min { get; set; } //<![CDATA[正常]]></lisresult_ref_min>
    }


    public class EntityZdzh
    {
        public string comb_code { get; set; }
        public string comb_name { get; set; }
    }


    [DataContract, Serializable]
    [EntityAttribute(TableName = "dyTjyjymxxm")]
    public class EntityDyTjyjymxxm : BaseDataContract
    {
        /// <summary>
        /// pe_item
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pe_item", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String pe_item { get; set; }

        /// <summary>
        /// pe_name
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pe_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String pe_name { get; set; }

        /// <summary>
        /// as_item
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "as_item", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String as_item { get; set; }

        /// <summary>
        /// as_name
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "as_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String as_name { get; set; }

        /// <summary>
        /// as_roomcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "as_roomcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.String as_roomcode { get; set; }

        /// <summary>
        /// as_roomname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "as_roomname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String as_roomname { get; set; }
    }

    public class EntityZdjb
    {
        public string dea_code { get; set; }
        public string dea_name { get; set; }
        public string cls_code { get; set; }
        public string res_tag { get; set; }
        public string sug_tag { get; set; }
        public string py_code { get; set; }
        public string wb_code { get; set; }
        public string stat_flag { get; set; }
        public string res_flag { get; set; }
    }

    public class EntityOldJb
    {
        public string jbfl { get; set; }
        public string jbmc { get; set; }
        public string jbzgjz { get; set; }
        public string jbcgjz { get; set; }
        public string jbjy { get; set; }
    }

    public class EntitySl
    {
        public string reg_no { get; set; }
        public string rec_no { get; set; }
        public string item_code { get; set; }
        public string rec_result { get; set; }
        public string res_tag { get; set; }
    }


   
    public class EntityItemRpt
    {
        public int xh { get; set; }
        public int tjrc { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string zk { get; set; }
        public decimal zqdj { get; set; }
        public decimal zqje { get; set; }
        public decimal zhdj { get; set; }
        public decimal zhje { get; set; }
        public string kdks { get; set; }
        public string zxks { get; set; }
        public string bz { get; set; }
    }
}
