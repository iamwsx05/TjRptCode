using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrPartogramMain
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrPartogramMain")]
    public class EntityEmrPartogramMain : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Patage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patAge", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String patAge { get; set; }

        /// <summary>
        /// Pregnanttimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pregnantTimes", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String pregnantTimes { get; set; }

        /// <summary>
        /// Labourtimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "labourTimes", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String labourTimes { get; set; }

        /// <summary>
        /// Pregnantweeks
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pregnantWeeks", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String pregnantWeeks { get; set; }

        /// <summary>
        /// Predestinatedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "predestinateDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime? predestinateDate { get; set; }

        /// <summary>
        /// Interspinal
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "interspinal", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String interspinal { get; set; }

        /// <summary>
        /// Iliacacrest
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iliacAcrest", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String iliacAcrest { get; set; }

        /// <summary>
        /// Conjugate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "conJugate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String conJugate { get; set; }

        /// <summary>
        /// Ischium
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ischium", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String ischium { get; set; }

        /// <summary>
        /// Labourtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "labourTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? labourTime { get; set; }

        /// <summary>
        /// Pregnantdays
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pregnantDays", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String pregnantDays { get; set; }

        /// <summary>
        /// Isdeleted
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDeleted", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal isDeleted { get; set; }

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
            public string registerId = "registerId";
            public string patAge = "patAge";
            public string pregnantTimes = "pregnantTimes";
            public string labourTimes = "labourTimes";
            public string pregnantWeeks = "pregnantWeeks";
            public string predestinateDate = "predestinateDate";
            public string interspinal = "interspinal";
            public string iliacAcrest = "iliacAcrest";
            public string conJugate = "conJugate";
            public string ischium = "ischium";
            public string labourTime = "labourTime";
            public string pregnantDays = "pregnantDays";
            public string isDeleted = "isDeleted";
        }

        /// <summary>
        /// 床号
        /// </summary>
        [DataMember]
        public string bedNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [DataMember]
        public string patName { get; set; }

        /// <summary>
        /// 住院号
        /// </summary>
        [DataMember]
        public string ipNo { get; set; }
    }

    /// <summary>
    /// 产程图数据
    /// </summary>
    [DataContract, Serializable]
    public class EmrPartogramData : BaseDataContract
    {
        /// <summary>
        /// 主记录数据
        /// </summary>
        [DataMember]
        public EntityEmrPartogramMain partogramMain { get; set; }
        /// <summary>
        /// 从表数据
        /// </summary>
        [DataMember]
        public List<EntityEmrPartogramData> lstPartogramData { get; set; }
    }

    /// <summary>
    /// 待处理基本信息
    /// </summary>
    [DataContract, Serializable]
    public class EmrPartogramForSave : BaseDataContract
    {
        /// <summary>
        /// 当前用户ID
        /// </summary>
        [DataMember]
        public string userId { get; set; }

        /// <summary>
        /// 待处理数据
        /// </summary>
        [DataMember]
        public EntityEmrPartogramMain partogramMain { get; set; }

        /// <summary>
        /// 处理标志(0-不处理,1-保存,2-更新)
        /// </summary>
        [DataMember]
        public int flag = 0;
    }

    /// <summary>
    /// 待处理记录数据
    /// </summary>
    [DataContract, Serializable]
    public class EmrPartogramDataForSave : BaseDataContract
    {
        /// <summary>
        /// 待处理数据
        /// </summary>
        [DataMember]
        public List<EntityEmrPartogramData> lstPartogramData { get; set; }

        /// <summary>
        /// 处理标志(0-不处理,1-保存,2-更新)
        /// </summary>
        [DataMember]
        public int flag = 0;
    }
}
