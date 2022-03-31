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
    /// wechatDailyReport
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "wechatDailyReport")]
    public class EntityWechatDailyReport : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Rptdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String rptDate { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Deptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String deptName { get; set; }

        /// <summary>
        /// Depttype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String deptType { get; set; }

        /// <summary>
        /// Opmedamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opMedAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal opMedAmount { get; set; }

        /// <summary>
        /// Opselfamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opSelfAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal opSelfAmount { get; set; }

        /// <summary>
        /// Emergmedamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "emergMedAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal emergMedAmount { get; set; }

        /// <summary>
        /// Emergselfamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "emergSelfAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal emergSelfAmount { get; set; }

        /// <summary>
        /// Opmedfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opMedFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal opMedFee { get; set; }

        /// <summary>
        /// Opselffee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opSelfFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal opSelfFee { get; set; }

        /// <summary>
        /// Emergmedfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "emergMedFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal emergMedFee { get; set; }

        /// <summary>
        /// Emergselffee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "emergSelfFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal emergSelfFee { get; set; }

        /// <summary>
        /// Opdrugfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opDrugFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal opDrugFee { get; set; }

        /// <summary>
        /// Opantifee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opAntiFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal opAntiFee { get; set; }

        /// <summary>
        /// Opmaterialfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opMaterialFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal opMaterialFee { get; set; }

        /// <summary>
        /// Examamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "examAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal examAmount { get; set; }

        /// <summary>
        /// Examfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "examFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal examFee { get; set; }

        /// <summary>
        /// Inmedamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inMedAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal inMedAmount { get; set; }

        /// <summary>
        /// Inselfamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inSelfAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal inSelfAmount { get; set; }

        /// <summary>
        /// Indangeramount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDangerAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal inDangerAmount { get; set; }

        /// <summary>
        /// Indeathamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDeathAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal inDeathAmount { get; set; }

        /// <summary>
        /// Insurgeryamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inSurgeryAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal inSurgeryAmount { get; set; }

        /// <summary>
        /// Inmedfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inMedFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Decimal inMedFee { get; set; }

        /// <summary>
        /// Inselffee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inSelfFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Decimal inSelfFee { get; set; }

        /// <summary>
        /// Indrugfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDrugFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal inDrugFee { get; set; }

        /// <summary>
        /// Inantifee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inAntiFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal inAntiFee { get; set; }

        /// <summary>
        /// Inmaterialfee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inMaterialFee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Decimal inMaterialFee { get; set; }

        /// <summary>
        /// Inadmitamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inAdmitAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Decimal inAdmitAmount { get; set; }

        /// <summary>
        /// Indischargeamount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inDischargeAmount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal inDischargeAmount { get; set; }

        /// <summary>
        /// Inusedbeds
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inUsedBeds", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal inUsedBeds { get; set; }

        /// <summary>
        /// Intotbeds
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inTotBeds", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Decimal inTotBeds { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.DateTime recordDate { get; set; }

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
            public string rptDate = "rptDate";
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string deptType = "deptType";
            public string opMedAmount = "opMedAmount";
            public string opSelfAmount = "opSelfAmount";
            public string emergMedAmount = "emergMedAmount";
            public string emergSelfAmount = "emergSelfAmount";
            public string opMedFee = "opMedFee";
            public string opSelfFee = "opSelfFee";
            public string emergMedFee = "emergMedFee";
            public string emergSelfFee = "emergSelfFee";
            public string opDrugFee = "opDrugFee";
            public string opAntiFee = "opAntiFee";
            public string opMaterialFee = "opMaterialFee";
            public string examAmount = "examAmount";
            public string examFee = "examFee";
            public string inMedAmount = "inMedAmount";
            public string inSelfAmount = "inSelfAmount";
            public string inDangerAmount = "inDangerAmount";
            public string inDeathAmount = "inDeathAmount";
            public string inSurgeryAmount = "inSurgeryAmount";
            public string inMedFee = "inMedFee";
            public string inSelfFee = "inSelfFee";
            public string inDrugFee = "inDrugFee";
            public string inAntiFee = "inAntiFee";
            public string inMaterialFee = "inMaterialFee";
            public string inAdmitAmount = "inAdmitAmount";
            public string inDischargeAmount = "inDischargeAmount";
            public string inUsedBeds = "inUsedBeds";
            public string inTotBeds = "inTotBeds";
            public string recordDate = "recordDate";
        }
    }

}
