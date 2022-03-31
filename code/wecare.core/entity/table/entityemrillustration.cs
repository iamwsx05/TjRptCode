using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrIllustration
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrIllustration")]
    public class EntityEmrIllustration : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 serNo { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 deptId { get; set; }

        /// <summary>
        /// Imgdesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imgdesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String imgDesc { get; set; }

        /// <summary>
        /// Imgbyte
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imgbyte", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Byte[] imgByte { get; set; }

        /// <summary>
        /// Sysscope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sysscope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 sysScope { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string deptId = "deptId";
            public string imgDesc = "imgDesc";
            public string imgByte = "imgByte";
            public string sysScope = "sysScope";
        }
    }

}
