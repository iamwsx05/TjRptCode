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
    [DataContract, Serializable]
    public class EntityCsRecipe : BaseDataContract
    {
        [DataMember]
        public string recipeId { get; set; }

        //[DataMember]
        //public string patientId { get; set; }

        //[DataMember]
        //public string registerId { get; set; }

        //[DataMember]
        //public string doctId { get; set; }

        //[DataMember]
        //public string doctName { get; set; }

        //[DataMember]
        //public string deptId { get; set; }

        //[DataMember]
        //public string deptName { get; set; }

        //[DataMember]
        //public string operId { get; set; }

        //[DataMember]
        //public string payTypeId { get; set; }

        [DataMember]
        public string caseHisId { get; set; }

        [DataMember]
        public string clinicDiag { get; set; }

        /// <summary>
        /// 1 正方、 2 付方
        /// </summary>
        [DataMember]
        public int recipeFlag { get; set; }

        /// <summary>
        /// 是否急诊
        /// </summary>
        [DataMember]
        public int isEmer { get; set; }

        //[DataMember]
        //public string currAreaId { get; set; }

        //[DataMember]
        //public string currAreaName { get; set; }

        //[DataMember]
        //public string currBedId { get; set; }
    }
}
