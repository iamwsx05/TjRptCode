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
    /// sysLocalsetting
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysLocalsetting")]
    public class EntitySysLocalSetting : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 serNo { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 typeId { get; set; }

        /// <summary>
        /// Machinename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "machinename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String machineName { get; set; }

        /// <summary>
        /// Ipaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ipaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String ipAddr { get; set; }

        /// <summary>
        /// Macaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "macaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String macAddr { get; set; }

        /// <summary>
        /// Empno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String empNo { get; set; }

        /// <summary>
        /// Setting
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "setting", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String setting { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 status { get; set; }

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
            public string typeId = "typeId";
            public string machineName = "machineName";
            public string ipAddr = "ipAddr";
            public string macAddr = "macAddr";
            public string empNo = "empNo";
            public string setting = "setting";
            public string status = "status";
        }
    }

}
