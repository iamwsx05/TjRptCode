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
    /// ipTransfer
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipTransfer")]
    public class EntityIpTransferEmr : BaseDataContract
    {
        /// <summary>
        /// Transid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "transId", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal transId { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "beginDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.DateTime beginDate { get; set; }

        /// <summary>
        /// Enddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime? endDate { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String deptId { get; set; }

        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String areaId { get; set; }

        /// <summary>
        /// Bedid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String bedId { get; set; }

        /// <summary>
        /// Termid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "termId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String termId { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String doctId { get; set; }

        /// <summary>
        /// Boperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "boperId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String boperId { get; set; }

        /// <summary>
        /// Eoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eoperId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String eoperId { get; set; }

        /// <summary>
        /// Sysdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sysDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? sysDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Supdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "supDoctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String supDoctId { get; set; }

        /// <summary>
        /// Dirdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dirDoctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String dirDoctId { get; set; }

        /// <summary>
        /// Nurgroupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nurGroupNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String nurGroupNo { get; set; }

        /// <summary>
        /// Optype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? opType { get; set; }

        /// <summary>
        /// Orgtransid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgTransId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal? orgTransId { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string transId = "transId";
            public string beginDate = "beginDate";
            public string endDate = "endDate";
            public string registerId = "registerId";
            public string deptId = "deptId";
            public string areaId = "areaId";
            public string bedId = "bedId";
            public string termId = "termId";
            public string doctId = "doctId";
            public string boperId = "boperId";
            public string eoperId = "eoperId";
            public string sysDate = "sysDate";
            public string status = "status";
            public string supDoctId = "supDoctId";
            public string dirDoctId = "dirDoctId";
            public string nurGroupNo = "nurGroupNo";
            public string opType = "opType";
            public string orgTransId = "orgTransId";
        }
    }

}
