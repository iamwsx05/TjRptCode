using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_PROVINCE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_PROVINCE")]
    public class EntityCodeProvince : BaseDataContract
    {
        /// <summary>
        /// COUNTRY_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "COUNTRY_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String countryNo { get; set; }

        /// <summary>
        /// PROVINCE_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PROVINCE_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String provinceNo { get; set; }

        /// <summary>
        /// PROVINCE_NM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PROVINCE_NM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String provinceNm { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string countryNo = "countryNo";
            public string provinceNo = "provinceNo";
            public string provinceNm = "provinceNm";
        }
    }

}
