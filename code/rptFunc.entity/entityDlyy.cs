using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RptFunc.Dlyy
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
        public  string combCode { get; set; }
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
        public string tjzhxm { get; set; }
        public string tjzhxmmc { get; set;}
        public string gjc { get; set; }
        public string gjcmc { get; set; }
    }

}
