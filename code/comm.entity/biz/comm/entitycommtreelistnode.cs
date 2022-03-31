using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 通用树Node
    /// </summary>
    [DataContract, Serializable]
    public class CommTreeListNode
    {
        /// <summary>
        /// KeyFieldName
        /// </summary>
        [DataMember]
        public string KeyFieldName { get; set; }
        /// <summary>
        /// KeyFieldCaption
        /// </summary>
        [DataMember]
        public string KeyFieldCaption { get; set; }
        /// <summary>
        /// KeyFieldImageIndex
        /// </summary>
        [DataMember]
        public int KeyFieldImageIndex { get; set; }
        /// <summary>
        /// ParentFieldName
        /// </summary>
        [DataMember]
        public string ParentFieldName { get; set; }
        /// <summary>
        /// PyCode
        /// </summary>
        [DataMember]
        public string PyCode { get; set; }
        /// <summary>
        /// WbCode
        /// </summary>
        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string FuncCode { get; set; }

        [DataMember]
        public string FuncFile { get; set; }

        [DataMember]
        public string OperName { get; set; }

        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public BaseDataContract Entity { get; set; }
    }
}
