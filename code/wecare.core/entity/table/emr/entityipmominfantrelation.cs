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
    /// ipMominfantRelation
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipMominfantRelation")]
    public class EntityIpMominfantRelation : BaseDataContract
    {
        /// <summary>
        /// Mregisterid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "mregisterId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String mregisterId { get; set; }

        /// <summary>
        /// Cregisterid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cregisterId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String cregisterId { get; set; }

        /// <summary>
        /// Orderno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal orderNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string mregisterId = "mregisterId";
            public string cregisterId = "cregisterId";
            public string orderNo = "orderNo";
        }
    }

}
