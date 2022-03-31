using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_FREQUENCY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_FREQUENCY")]
    public class EntityCodeFrequency : BaseDataContract
    {
        /// <summary>
        /// FREQ_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FREQ_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String freqCode { get; set; }

        /// <summary>
        /// FREQ_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FREQ_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String freqName { get; set; }

        /// <summary>
        /// TIMES
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TIMES", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal times { get; set; }

        /// <summary>
        /// CYC
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CYC", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal cyc { get; set; }

        /// <summary>
        /// UNSURE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "UNSURE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String unsure { get; set; }

        /// <summary>
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String scope { get; set; }

        /// <summary>
        /// COM_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "COM_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String comName { get; set; }

        /// <summary>
        /// FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string freqCode = "freqCode";
            public string freqName = "freqName";
            public string times = "times";
            public string cyc = "cyc";
            public string unsure = "unsure";
            public string scope = "scope";
            public string comName = "comName";
            public string flag = "flag";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }
        [DataMember]
        public string regNo { get; set; }
        [DataMember]
        public string orderNo { get; set; }
        [DataMember]
        public int groupNo { get; set; }
        [DataMember]
        public int rowHandle { get; set; }
    }

}
