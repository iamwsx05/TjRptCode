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
    public class EntityChartDeptNum : BaseDataContract, IComparable
    {
        [DataMember]
        public string doctCode { get; set; }

        [DataMember]
        public string doctName { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string typeName { get; set; }

        [DataMember]
        public string statusName { get; set; }

        [DataMember]
        public int nums { get; set; }

        [DataMember]
        public int numsPt { get; set; }

        [DataMember]
        public int numsZk { get; set; }

        [DataMember]
        public int sortNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string doctCode = "doctCode";
            public string doctName = "doctName";
            public string deptName = "deptName";
            public string typeName = "typeName";
            public string statusName = "statusName";
            public string nums = "nums";
            public string numsPt = "numsPt";
            public string numsZk = "numsZk";
        }

        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityChartDeptNum)
            {
                return this.sortNo.CompareTo(((EntityChartDeptNum)obj).sortNo);
            }
            return 0;
        }
    }
}
