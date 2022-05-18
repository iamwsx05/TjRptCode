using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Entity
{
    public class EntityZdzy : BaseDataContract
    {
        public string job_code { get; set; }
        public string job_name { get; set; }
        public static EnumCols Columns = new EnumCols();
        public class EnumCols
        {
            public string job_code = "job_code";
            public string job_name = "job_name";
        }
    }
}
