using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// cisInfectiousCard
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisInfectiousCard")]
    public class EntityInfectiousCard : BaseDataContract
    {
        /// <summary>
        /// Regno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regno", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String regNo { get; set; }

        /// <summary>
        /// Dataxml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dataxml", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String dataXml { get; set; }

        /// <summary>
        /// Recorder
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorder", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String recorder { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string regNo = "regNo";
            public string dataXml = "dataXml";
            public string recorder = "recorder";
            public string recordDate = "recordDate";
        }

        [DataMember]
        public string layoutXml { get; set; }

        [DataMember]
        public string panelsize { get; set; }

        [DataMember]
        public bool isNew { get; set; }
    }

}
