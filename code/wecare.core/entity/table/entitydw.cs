using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    public class EntityDw : BaseDataContract
    {
        public string lnc_code { get; set; }
        public string lnc_name { get; set; }

        public static EnumCols Columns = new EnumCols();
        public class EnumCols
        {
            public string lnc_code = "lnc_code";
            public string lnc_name = "lnc_name";
        }
    }

}
