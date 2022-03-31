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
    /// dicDeptRoom
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDeptRoom")]
    public class EntityDicDeptRoom : BaseDataContract
    {
        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Roomcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// Roomname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String roomName { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// roomDesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomDesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String roomDesc { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string deptCode = "deptCode";
            public string roomCode = "roomCode";
            public string roomName = "roomName";
            public string status = "status";
            public string roomDesc = "roomDesc";
        }
    }

}
