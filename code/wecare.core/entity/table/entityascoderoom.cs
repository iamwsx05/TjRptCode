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
    /// AS_CODE_ROOM
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "AS_CODE_ROOM")]
    public class EntityAsCodeRoom : BaseDataContract
    {
        /// <summary>
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// ROOM_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String roomName { get; set; }

        /// <summary>
        /// DW_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DW_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String dwName { get; set; }

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
            public string roomName = "roomName";
            public string dwName = "dwName";
        }
    }

}
