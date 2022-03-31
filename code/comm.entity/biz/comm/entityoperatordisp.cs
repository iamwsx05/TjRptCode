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
    public class EntityOperatorDisp : BaseDataContract, IComparable
    {
        [DataMember]
        public string deptCode { get; set; }
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string operCode { get; set; }
        [DataMember]
        public string operName { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string birthday { get; set; }
        [DataMember]
        public string dutyName { get; set; }
        [DataMember]
        public string rankName { get; set; }
        [DataMember]
        public string pwd { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string teacher { get; set; }
        [DataMember]
        public string caKey { get; set; }
        [DataMember]
        public string contactTel { get; set; }
        [DataMember]
        public string contactAddr { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string operCode = "operCode";
            public string operName = "operName";
            public string sex = "sex";
            public string birthday = "birthday";
            public string dutyName = "dutyName";
            public string rankName = "rankName";
            public string pwd = "pwd";
            public string type = "type";
            public string teacher = "teacher";
            public string caKey = "caKey";
            public string contactTel = "contactTel";
            public string contactAddr = "contactAddr";
            public string status = "status";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }

        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityOperatorDisp)
            {
                return this.deptName.CompareTo(((EntityOperatorDisp)obj).deptName);
            }
            return 0;
        }
    }
}
