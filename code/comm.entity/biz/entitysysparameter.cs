using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using iCare.Core.Entity;

namespace Common.Entity
{
    #region 参数

    /// <summary>
    /// EntitySysParameter
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysParameter")]
    public class EntitySysParameter : BaseDataContract
    {
        /// <summary>
        /// Subsysid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "subsysid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String Subsysid { get; set; }

        /// <summary>
        /// Parmid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parmid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Parmid { get; set; }

        /// <summary>
        /// Parmname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parmname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Parmname { get; set; }

        /// <summary>
        /// Parmvalue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parmvalue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Parmvalue { get; set; }

        /// <summary>
        /// Parmdesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parmdesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Parmdesc { get; set; }

        /// <summary>
        /// Parmstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parmstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Parmstatus { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Subsysid = "Subsysid";
            public string Parmid = "Parmid";
            public string Parmname = "Parmname";
            public string Parmvalue = "Parmvalue";
            public string Parmdesc = "Parmdesc";
            public string Parmstatus = "Parmstatus";

            public string SubSysName = "SubSysName";
            public string Status = "Status";
            public string StatusName = "StatusName";
        }
        /// <summary>
        /// SubSysName
        /// </summary>
        [DataMember]
        public System.String SubSysName { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// StatusName
        /// </summary>
        [DataMember]
        public System.String StatusName { get; set; }
    }

    #endregion
}
