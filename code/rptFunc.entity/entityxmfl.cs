using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Entity
{
    public class EntityXmfl :BaseDataContract
    {
        [DataMember]
        public string cls_code { get; set; }
        [DataMember]
        public string cls_name { get; set; }

        public static EnumCols Columns = new EnumCols();
        public class EnumCols
        {
            public string cls_code = "cls_code";
            public string cls_name = "cls_name";
        }
    }
}
