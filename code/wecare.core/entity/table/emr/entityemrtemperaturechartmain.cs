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
    /// emrTemperatureChartMain
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrTemperatureChartMain")]
    public class EntityEmrTemperatureChartMain : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Patage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patAge", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patAge { get; set; }

        /// <summary>
        /// Operid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String operId { get; set; }

        /// <summary>
        /// Operdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime operDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string registerId = "registerId";
            public string patAge = "patAge";
            public string operId = "operId";
            public string operDate = "operDate";
        }
    }

}
