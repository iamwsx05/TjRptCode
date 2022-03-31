using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    [DataContract, Serializable]
    public class EntityLocalSetting : BaseDataContract
    {
        [DataMember]
        public string MachName { get; set; }

        [DataMember]
        public string MacAddr { get; set; }

        [DataMember]
        public string IpAddr { get; set; }

        [DataMember]
        public string EmpNo { get; set; }

        [DataMember]
        public string Parent { get; set; }

        [DataMember]
        public string Node { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public bool IsDo { get; set; }

        /// <summary>
        /// 1 公用； 2 本机； 3 个人
        /// </summary>
        [DataMember]
        public int Type { get; set; }
    }
}
