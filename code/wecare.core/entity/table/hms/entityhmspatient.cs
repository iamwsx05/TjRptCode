using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityHmsPatient
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "hmsPatient")]
    public class EntityHmsPatient : BaseDataContract
    {
        /// <summary>
        /// patId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String patId { get; set; }

        /// <summary>
        /// clientNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clientNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clientNo { get; set; }

        /// <summary>
        /// classId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String classId { get; set; }

        /// <summary>
        /// patName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String patName { get; set; }

        /// <summary>
        /// sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal sex { get; set; }

        /// <summary>
        /// birthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "birthday", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime? birthday { get; set; }

        /// <summary>
        /// culture
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "culture", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String culture { get; set; }

        /// <summary>
        /// occupation
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "occupation", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String occupation { get; set; }

        /// <summary>
        /// birthplace
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "birthplace", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String birthplace { get; set; }

        /// <summary>
        /// idType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 idType { get; set; }

        /// <summary>
        /// idNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String idNo { get; set; }

        /// <summary>
        /// registerAddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerAddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String registerAddr { get; set; }

        /// <summary>
        /// contactTel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactTel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String contactTel { get; set; }

        /// <summary>
        /// homeAddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "homeAddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String homeAddr { get; set; }

        /// <summary>
        /// homeTel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "homeTel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String homeTel { get; set; }

        /// <summary>
        /// workAddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "workAddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String workAddr { get; set; }

        /// <summary>
        /// workTel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "workTel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String workTel { get; set; }

        /// <summary>
        /// remark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String remark { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// creator
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String creator { get; set; }

        /// <summary>
        /// creatDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.DateTime creatDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string patId = "patId";
            public string clientNo = "clientNo";
            public string classId = "classId";
            public string patName = "patName";
            public string sex = "sex";
            public string birthday = "birthday";
            public string culture = "culture";
            public string occupation = "occupation";
            public string birthplace = "birthplace";
            public string idType = "idType";
            public string idNo = "idNo";
            public string registerAddr = "registerAddr";
            public string contactTel = "contactTel";
            public string homeAddr = "homeAddr";
            public string homeTel = "homeTel";
            public string workAddr = "workAddr";
            public string workTel = "workTel";
            public string remark = "remark";
            public string status = "status";
            public string creator = "creator";
            public string creatDate = "creatDate";
        }
    }
}
