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
    /// dicEventType
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicEventType")]
    public class EntityDicEventType : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Eventname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eventName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String eventName { get; set; }

        /// <summary>
        /// Drawingpotision
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drawingPotision", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal drawingPotision { get; set; }

        /// <summary>
        /// Isbreakingpoint
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isBreakingPoint", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal isBreakingPoint { get; set; }

        /// <summary>
        /// Isdrawtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDrawTime", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal isDrawTime { get; set; }

        /// <summary>
        /// Isoperation
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isOperation", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal isOperation { get; set; }

        /// <summary>
        /// Isdeleted
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDeleted", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
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
            public string eventName = "eventName";
            public string drawingPotision = "drawingPotision";
            public string isBreakingPoint = "isBreakingPoint";
            public string isDrawTime = "isDrawTime";
            public string isOperation = "isOperation";
            public string isDeleted = "isDeleted";
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.serNo, this.eventName);
        }
    }

}
