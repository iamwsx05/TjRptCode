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
    /// ipRegister
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipRegister")]
    public class EntityIpRegisterEmr : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Registerdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.DateTime registerDate { get; set; }

        /// <summary>
        /// Indate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime? inDate { get; set; }

        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String patientId { get; set; }

        /// <summary>
        /// Patientipno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientIpNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String patientIpNo { get; set; }

        /// <summary>
        /// Iptimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ipTimes", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal ipTimes { get; set; }

        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String areaId { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String deptId { get; set; }

        /// <summary>
        /// Bedid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String bedId { get; set; }

        /// <summary>
        /// Carelevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "careLevel", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? careLevel { get; set; }

        /// <summary>
        /// Termid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "termId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String termId { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String doctId { get; set; }

        /// <summary>
        /// Paytype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String payType { get; set; }

        /// <summary>
        /// Indiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String inDiagnosis { get; set; }

        /// <summary>
        /// Outdiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outDiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String outDiagnosis { get; set; }

        /// <summary>
        /// Outtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal? outType { get; set; }

        /// <summary>
        /// Outdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.DateTime? outDate { get; set; }

        /// <summary>
        /// Inoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inOperId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String inOperId { get; set; }

        /// <summary>
        /// Outoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outOperId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String outOperId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Opdiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opDiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String opDiagnosis { get; set; }

        /// <summary>
        /// Opdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opDoctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String opDoctId { get; set; }

        /// <summary>
        /// Illnessstate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illnessState", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? illnessState { get; set; }

        /// <summary>
        /// Deathdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deathDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.DateTime? deathDate { get; set; }

        /// <summary>
        /// Illcasecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illCaseCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String illCaseCode { get; set; }

        /// <summary>
        /// Printflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printFlag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal? printFlag { get; set; }

        /// <summary>
        /// Supdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "supDoctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String supDoctId { get; set; }

        /// <summary>
        /// Dirdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dirDoctId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String dirDoctId { get; set; }

        /// <summary>
        /// Nurgroupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nurGroupNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String nurGroupNo { get; set; }

        /// <summary>
        /// Opstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal? opStatus { get; set; }

        /// <summary>
        /// Uploadcaseflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "uploadCaseFlag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal? uploadCaseFlag { get; set; }

        /// <summary>
        /// Identityid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "identityId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String identityId { get; set; }

        /// <summary>
        /// Intype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Decimal? inType { get; set; }

        /// <summary>
        /// Barcodeprtflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "barcodePrtflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Decimal? barcodePrtflag { get; set; }

        /// <summary>
        /// Patienttype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.Decimal? patientType { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string registerId = "registerId";
            public string registerDate = "registerDate";
            public string inDate = "inDate";
            public string patientId = "patientId";
            public string patientIpNo = "patientIpNo";
            public string ipTimes = "ipTimes";
            public string areaId = "areaId";
            public string deptId = "deptId";
            public string bedId = "bedId";
            public string careLevel = "careLevel";
            public string termId = "termId";
            public string doctId = "doctId";
            public string payType = "payType";
            public string inDiagnosis = "inDiagnosis";
            public string outDiagnosis = "outDiagnosis";
            public string outType = "outType";
            public string outDate = "outDate";
            public string inOperId = "inOperId";
            public string outOperId = "outOperId";
            public string status = "status";
            public string opDiagnosis = "opDiagnosis";
            public string opDoctId = "opDoctId";
            public string illnessState = "illnessState";
            public string deathDate = "deathDate";
            public string illCaseCode = "illCaseCode";
            public string printFlag = "printFlag";
            public string supDoctId = "supDoctId";
            public string dirDoctId = "dirDoctId";
            public string nurGroupNo = "nurGroupNo";
            public string opStatus = "opStatus";
            public string uploadCaseFlag = "uploadCaseFlag";
            public string identityId = "identityId";
            public string inType = "inType";
            public string barcodePrtflag = "barcodePrtflag";
            public string patientType = "patientType";
        }
    }

}
