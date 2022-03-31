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
    public class EntityCsOrder : BaseDataContract
    {
        [DataMember]
        public string orderId { get; set; }

        [DataMember]
        public string orderDicId { get; set; }

        [DataMember]
        public string orderDicName { get; set; }

        [DataMember]
        public string registerId { get; set; }

        [DataMember]
        public string patientId { get; set; }

        [DataMember]
        public int executeType { get; set; }

        [DataMember]
        public int recipeNo { get; set; }

        [DataMember]
        public string spec { get; set; }

        [DataMember]
        public string execFreqId { get; set; }

        [DataMember]
        public string execFreqName { get; set; }

        [DataMember]
        public decimal dosage { get; set; }

        [DataMember]
        public string dosageUnit { get; set; }

        [DataMember]
        public decimal getDec { get; set; }

        [DataMember]
        public string getUnit { get; set; }

        [DataMember]
        public decimal useDec { get; set; }

        [DataMember]
        public string useUnit { get; set; }

        [DataMember]
        public string doseTypeId { get; set; }

        [DataMember]
        public string doseTypeName { get; set; }

        [DataMember]
        public string entrust { get; set; }

        [DataMember]
        public string parentId { get; set; }

        [DataMember]
        public int status { get; set; }

        [DataMember]
        public int isRich { get; set; }

        [DataMember]
        public int rateType { get; set; }

        [DataMember]
        public int isRepare { get; set; }

        [DataMember]
        public string creatorId { get; set; }

        [DataMember]
        public string creatorName { get; set; }

        [DataMember]
        public DateTime createDate { get; set; }

        [DataMember]
        public int isNeedFeel { get; set; }

        [DataMember]
        public int outGetMedDays { get; set; }

        [DataMember]
        public DateTime startDate { get; set; }

        [DataMember]
        public DateTime? finishDate { get; set; }

        [DataMember]
        public int isYb { get; set; }

        [DataMember]
        public string sampleId { get; set; }

        [DataMember]
        public string lisAppId { get; set; }

        [DataMember]
        public string partId { get; set; }

        [DataMember]
        public int ifParentId { get; set; }

        [DataMember]
        public string createAreaId { get; set; }

        [DataMember]
        public string createAreaName { get; set; }

        [DataMember]
        public int attachTimes { get; set; }

        [DataMember]
        public string doctorId { get; set; }

        [DataMember]
        public string doctorName { get; set; }

        [DataMember]
        public string curAreaId { get; set; }

        [DataMember]
        public string curBedId { get; set; }

        [DataMember]
        public string doctorGroupId { get; set; }

        [DataMember]
        public int isSign { get; set; }

        [DataMember]
        public string stoperId { get; set; }

        [DataMember]
        public string stoperName { get; set; }

        [DataMember]
        public DateTime? stopDate { get; set; }

        [DataMember]
        public int operation { get; set; }

        [DataMember]
        public string remark { get; set; }

        [DataMember]
        public int charge { get; set; }

        [DataMember]
        public string posterId { get; set; }

        [DataMember]
        public string posterName { get; set; }

        [DataMember]
        public DateTime postDate { get; set; }

        [DataMember]
        public int orderType { get; set; }

        [DataMember]
        public decimal singleAmount { get; set; }

        [DataMember]
        public int sourceType { get; set; }

        [DataMember]
        public string chargeDoctorGroupId { get; set; }

        [DataMember]
        public int antiuse { get; set; }

        [DataMember]
        public int antiuseYflx { get; set; }

        [DataMember]
        public int cureDays { get; set; }

        [DataMember]
        public int isProxyBoilMed { get; set; }

        [DataMember]
        public int isEmer { get; set; }

        [DataMember]
        public int isOps { get; set; }
    }
}
