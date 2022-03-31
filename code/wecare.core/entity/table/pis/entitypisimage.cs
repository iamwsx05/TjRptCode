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
    /// EntityPisImage
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisImage")]
    public class EntityPisImage : BaseDataContract
    {
        /// <summary>
        /// imageId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imageId", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal imageId { get; set; }

        /// <summary>
        /// pNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String pNo { get; set; }

        /// <summary>
        /// imageData
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imageData", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Byte[] imageData { get; set; }

        /// <summary>
        /// isPrint
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isPrint", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal isPrint { get; set; }

        /// <summary>
        /// recOperCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String recOperCode { get; set; }

        /// <summary>
        /// recDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime recDate { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
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
            public string imageId = "imageId";
            public string pNo = "pNo";
            public string imageData = "imageData";
            public string isPrint = "isPrint";
            public string recOperCode = "recOperCode";
            public string recDate = "recDate";
            public string status = "status";
        }

    }

}
