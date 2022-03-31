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
    /// pisTeamRole
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisTeamRole")]
    public class EntityPisTeamRole : BaseDataContract
    {
        /// <summary>
        /// Teamid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "teamId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String teamId { get; set; }

        /// <summary>
        /// Roleid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roleId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String roleId { get; set; }

        [DataMember]
        public string roleName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string teamId = "teamId";
            public string roleId = "roleId";
            public string roleName = "roleName";
        }
    }

}
