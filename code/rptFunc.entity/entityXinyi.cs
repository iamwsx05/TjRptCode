using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RptFunc.Xinyi
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


    [XmlRoot("DataExchange")]
    public class Header
    {
        public string DocumentId { get; set; }
        public string OperateType { get; set; }
        public string BusinessActivityIdentification { get; set; }
        public string ReportOrgCode { get; set; }
        public string License { get; set; }
        public string ReportZoneCode { get; set; }
    }

    public class ENTERPRISE_INFO
    {
        public string regNo { get; set; }
        public string ENTERPRISE_NAME { get; set; }
        public string CREDIT_CODE { get; set; }
        public string ECONOMIC_TYPE_CODE { get; set; }
        public string INDUSTRY_CATEGORY_CODE { get; set; }
        public string BUSINESS_SCALE_CODE { get; set; }
        public string ADDRESS_CODE { get; set; }
        public string ADDRESS_DETAIL { get; set; }
        public string ADDRESS_ZIP_CODE { get; set; }
        public string ENTERPRISE_CONTACT { get; set; }
        public string CONTACT_TELPHONE { get; set; }
        public string ALL_NAME { get; set; }
    }

    public class ENTERPRISE_INFO_EMPLOYER
    {
        public string regNo { get; set; }
        public string ENTERPRISE_NAME_EMPLOYER { get; set; }
        public string CREDIT_CODE_EMPLOYER { get; set; }
        public string ECONOMIC_TYPE_CODE_EMPLOYER { get; set; }
        public string INDUSTRY_CATEGORY_CODE_EMPLOYER { get; set; }
        public string BUSINESS_SCALE_CODE_EMPLOYER { get; set; }
        public string ADDRESS_CODE_EMPLOYER { get; set; }
        public string ALL_NAME_EMPLOYER { get; set; }

    }

    public class WORKER_INFO
    {
        public string regNo { get; set; }
        public string WORKER_NAME { get; set; }
        public string ID_CARD_TYPE_CODE { get; set; }
        public string ID_CARD { get; set; }
        public string GENDER_CODE { get; set; }
        public string BIRTH_DATE { get; set; }
        public string WORKER_TELPHONE { get; set; }
        public string JC_TYPE { get; set; }
        public string EMERGENCY_CONTACT { get; set; }
        public string CONTACT_INFORMATION { get; set; }
    }

    public class HEALTH_EXAM_RECORD
    {
        public string regNo { get; set; }
        public string JC_TYPE { get; set; }
        public string EXAM_TYPE_CODE { get; set; }
        public string EXAM_DATE { get; set; }
        public string FACTOR_CODE { get; set; }
        public string FACTOR_OTHER { get; set; }
        public string WRITE_PERSON { get; set; }
        public string WRITE_PERSON_TELPHONE { get; set; }
        public string WRITE_DATE { get; set; }
        public string REPORT_ORGAN_CREDIT_CODE { get; set; }
        public string REMARK { get; set; }
        public string WORK_TYPE_CODE { get; set; }
        public string OTHER_WORK_TYPE { get; set; }
        public string HARM_START_DATE { get; set; }
        public string HARM_AGE_YEAR { get; set; }
        public string HARM_AGE_MONTH { get; set; }
        public string IS_REVIEW { get; set; }
        public string AREA_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string REPORT_UNIT { get; set; }
        public string REPORT_PERSON { get; set; }
        public string REPORT_PERSON_TEL { get; set; }
        public string REPORT_DATE { get; set; }
        public string WORKER_TELPHONE { get; set; }
        public string CONTACT_FACTOR_CODE { get; set; }
        public string CONTACT_FACTOR_OTHER { get; set; }
    }


    public class EXAM_CONCLUSION
    {
        public string regNo { get; set; }
        public string ITAM_CODE { get; set; }
        public string ITAM_NAME { get; set; }
        public string EXAM_CONCLUSION_CODE { get; set; }
        public string YSZYB_CODE { get; set; }
        public string ZYJJZ_NAME { get; set; }
        public string QTJB_NAME { get; set; }
        public string JC_TYPE { get; set; }
        public string HARM_START_DATE { get; set; }
        public string HARM_AGE_YEAR { get; set; }
        public string HARM_AGE_MONTH { get; set; }
    }

    public class EXAM_ITEM_RESULT
    {
        public string regNo { get; set; }
        public string EXAM_ITEM_PNAME { get; set; }
        public string EXAM_ITEM_NAME { get; set; }
        public string EXAM_ITEM_CODE { get; set; }
        public string EXAM_RESULT_TYPE { get; set; }
        public string EXAM_RESULT { get; set; }
        public string EXAM_ITEM_UNIT_CODE { get; set; }
        public string REFERENCE_RANGE_MIN { get; set; }
        public string REFERENCE_RANGE_MAX { get; set; }
        public string ABNORMAL { get; set; }
    }

    public class EntityList
    {
        public string regNo { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }




    public class EntityTjxmmx
    {
        public string  lnc_code { get; set; }
        public string   lnc_name { get; set; }
        public string reg_no { get; set; }
        public string pat_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string idcard { get; set; }
        public string p_flag { get; set; }
        public string c_flag { get; set; }
        public string reg_date { get; set; }
        public string comb_code { get; set; }
        public string comb_name { get; set; }
        public decimal totalSum { get; set; }
        public decimal price1{ get; set; } 
        public string tjType { get; set; }
        public string regType { get; set; }
    }

}
