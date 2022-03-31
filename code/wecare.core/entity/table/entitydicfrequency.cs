using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// dicFrequency
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicFrequency")]
    public class EntityDicFrequency : BaseDataContract
    {
        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String freqId { get; set; }

        /// <summary>
        /// Freqcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String freqCode { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String freqName { get; set; }

        /// <summary>
        /// Freqprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqPrtName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String freqPrtName { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Times
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "times", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal times { get; set; }

        /// <summary>
        /// Days
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "days", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal days { get; set; }

        /// <summary>
        /// Execday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execDay", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String execDay { get; set; }

        /// <summary>
        /// Exectime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String execTime { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal typeId { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal sortNo { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string freqId = "freqId";
            public string freqCode = "freqCode";
            public string freqName = "freqName";
            public string freqPrtName = "freqPrtName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string times = "times";
            public string days = "days";
            public string execDay = "execDay";
            public string execTime = "execTime";
            public string typeId = "typeId";
            public string sortNo = "sortNo";
            public string status = "status";
        }
    }

}
