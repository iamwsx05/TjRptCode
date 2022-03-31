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
    /// AS_CODE_SAMPLE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "AS_CODE_SAMPLE")]
    public class EntityAsCodeSample : BaseDataContract
    {
        /// <summary>
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// SAMP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SAMP_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String sampCode { get; set; }

        /// <summary>
        /// SAMP_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SAMP_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String sampName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string roomCode = "roomCode";
            public string sampCode = "sampCode";
            public string sampName = "sampName";
        }
    }

}
