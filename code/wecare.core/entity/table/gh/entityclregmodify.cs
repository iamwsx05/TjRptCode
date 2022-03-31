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
    /// CL_REGMODIFY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_REGMODIFY")]
    public class EntityClRegModify : BaseDataContract
    {
        /// <summary>
        /// NEW_REGNO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NEW_REGNO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String NEW_REGNO { get; set; }

        /// <summary>
        /// OLD_REGNO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OLD_REGNO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String OLD_REGNO { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string NEW_REGNO = "NEW_REGNO";
            public string OLD_REGNO = "OLD_REGNO";
        }
    }

}
