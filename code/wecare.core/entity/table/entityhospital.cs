using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 全局医院信息
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysHospital")]
    public class EntityHospital : BaseDataContract
    {
        /// <summary>
        /// Hospitalid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hospitalid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Hospitalid { get; set; }

        /// <summary>
        /// Hospitalname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hospitalname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Hospitalname { get; set; }

        /// <summary>
        /// Hospitaladdr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hospitaladdr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Hospitaladdr { get; set; }

        /// <summary>
        /// Hospitaltel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hospitaltel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Hospitaltel { get; set; }

        /// <summary>
        /// Hospitalzip
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hospitalzip", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Hospitalzip { get; set; }

        /// <summary>
        /// Orgsyscode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgsyscode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orgsyscode { get; set; }

        /// <summary>
        /// Orgcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Orgcode { get; set; }

        /// <summary>
        /// Orgname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Orgname { get; set; }

        /// <summary>
        /// Orgnature
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgnature", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Orgnature { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Hospitalid = "Hospitalid";
            public string Hospitalname = "Hospitalname";
            public string Hospitaladdr = "Hospitaladdr";
            public string Hospitaltel = "Hospitaltel";
            public string Hospitalzip = "Hospitalzip";
            public string Orgsyscode = "Orgsyscode";
            public string Orgcode = "Orgcode";
            public string Orgname = "Orgname";
            public string Orgnature = "Orgnature";
        }
    }
}
