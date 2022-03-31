using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace RptFunc
{
    public class EntityCodeItem
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string type { get; set; }
        public decimal lcjPrice { get; set; }
        public decimal retPrice { get; set; }
        public decimal traPrice { get; set; }
        public decimal packRat { get; set; }
        public string standard { get; set; }
        public string itemCls { get; set; }
        public string doseRate { get; set; }
        public string bclFlag { get; set; }
       public string BIG_UNIT { get; set; }
       public string SMALL_UNIT { get; set; }
    }


    public class EntityTczh
    {
        public string TCZH { get; set; }
        public string TCMC { get; set; }
        public string YPMC { get; set; }
        public string hisItemCode { get; set; }
    }

    public class EntityFyHiszh
    {
        public string tempNo { get; set; }
        public string tempName { get; set; }
        public string itemName { get; set; }
        public string itemCode { get; set; }
    }


    public class EntityIpFee
    {
        public string PRE_NO { get; set; }
        public string itemCode { get; set; }
        public string item_name { get; set; }
        public decimal qty { get; set; }
        public decimal PRICE { get; set; }
        public decimal TOTAL { get; set; }
        public int sort { get; set; }
    }


    public class EntityFy
    {
        public string fyxh { get; set; }
        public string fymc { get; set; }
        public decimal sl { get; set; }
        public decimal fydj { get; set; }
        public decimal fyzj { get; set; }
        public int sort { get; set; }
    }


    public class EntityPatInfo
    {
        public string reg_no { get; set; }
        public string mc_id { get; set; }
        public string fee_code { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string ip_no { get; set; }
        public string outDiag { get; set; }
        public string ip_date { get; set; }
        public string op_date { get; set; }
        public string  cl_ediag {get;set;}
    }

    public class EntityPreInfo
    {
        public string NAME { get; set; }
        public string REG_NO { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public decimal GROUP_NO { get; set; }
        public string BEGIN_DATE { get; set; }
        public string BEGIN_TIME { get; set; }
        public string END_DATE { get; set; }
        public string END_TIME { get; set; }
        public string EXEC_DATE { get; set; }
        public string EXEC_TIME { get; set; }
        public string CHECK_TIME { get; set; }
        public string PRE_NO { get; set; }
    }



    public class EntityJyfy
    {
        public string REG_NO { get; set; }
       public string name { get; set; }
        public string age { get; set; }
        public string REC_DATE { get; set; }
        public string oper_name { get; set; }
        public string DEPT_NAME { get; set; }
        public string CHRG_NO { get; set; }
        public string invo_no { get; set; }
        public string group_name { get; set; }
        public string fl { get; set; }
        public decimal total { get; set; }

        public decimal hyf { get; set; }
        public decimal cxf { get; set; }
    }

    public class EntityYm
    {
        public string REG_NO { get; set; }
        public string CARD_NO { get; set; }
        public string name { get; set; }
        public string REC_DATE { get; set; }
        public string oper_name { get; set; }
        public string CHRG_NO { get; set; }
        public string invo_no { get; set; }
        public string ITEM_NAME { get; set; }
        public string itemName { get; set; }
        public string ITEM_CODE { get; set; }
        public decimal xmje { get; set; }
        public decimal llf { get; set; }
        public decimal fwf { get; set; }
    }



    public class EntityChkf
    {
        public string CARD_NO { get; set; }
        public string REG_NO { get; set; }
        public string NAME { get; set; }
        public string REC_DATE { get; set; }
        public string DR_CODE { get; set; }
        public string OPER_NAME { get; set; }
        public string NOTE { get; set; }
        public string PRICE { get; set; }
        public string QTY { get; set; }
        public decimal TOTAL { get; set; }
        public string flg { get; set; }

    }

    public class EntitySmItem
    {
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string mc_code { get; set; }
        public string shouM { get; set; }
    }


    public class EntityOpcode
    {
        public int serno_int { get; set; }
        public string opcode { get; set; }
        public string opname { get; set; }
        public string pycode { get; set; }
        public int level { get; set; }
        public int status { get; set; }
    }


    public class EntityJgitem
    {
        public string item_code { get; set; }
        public string item_name { get; set; }
        public decimal mzPrice { get; set; }
        public decimal zyPrice { get; set; }
        public string mc_code { get; set; }
        public string sdm { get; set; }
        public string smc { get; set; }
    }

    public class EntityItemPrice
    {
        public string item_code { get; set; }
        public decimal mzPrice { get; set; }
        public decimal zyPrice { get; set; }
        public string sdm { get; set; }
        public string smc { get; set; }
        public string XTBM { get; set; }
        public string XTMC { get; set; }
    }


}
