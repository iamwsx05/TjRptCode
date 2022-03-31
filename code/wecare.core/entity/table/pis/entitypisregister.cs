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
    /// pisRegister
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisRegister")]
    public class EntityPisRegister : BaseDataContract
    {
        /// <summary>
        /// Pno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String pNo { get; set; }

        /// <summary>
        /// Ipno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ipNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String ipNo { get; set; }

        /// <summary>
        /// Opno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String opNo { get; set; }

        /// <summary>
        /// Patname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String patName { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 sex { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "birthday", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime birthday { get; set; }

        /// <summary>
        /// Nation
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nation", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String nation { get; set; }

        /// <summary>
        /// Native
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "native", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String native { get; set; }

        /// <summary>
        /// Idno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String idNo { get; set; }

        /// <summary>
        /// Workunit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "workUnit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String workUnit { get; set; }

        /// <summary>
        /// Marry
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "marry", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String marry { get; set; }

        /// <summary>
        /// Pattype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Int32 patType { get; set; }

        /// <summary>
        /// Paytype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String payType { get; set; }

        /// <summary>
        /// Contactaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactAddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String contactAddr { get; set; }

        /// <summary>
        /// Contacttel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactTel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String contactTel { get; set; }

        /// <summary>
        /// Bedno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String bedNo { get; set; }

        /// <summary>
        /// Isemer
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isEmer", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Int32 isEmer { get; set; }

        /// <summary>
        /// Ischarge
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isCharge", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Int32 isCharge { get; set; }

        /// <summary>
        /// Feeinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "feeInfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String feeInfo { get; set; }

        /// <summary>
        /// Samplename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sampleName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String sampleName { get; set; }

        /// <summary>
        /// Sampledate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sampleDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.DateTime sampleDate { get; set; }

        /// <summary>
        /// Sampleclassid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sampleClassId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String sampleClassId { get; set; }

        /// <summary>
        /// Applyunit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "applyUnit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String applyUnit { get; set; }

        /// <summary>
        /// Applydeptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "applyDeptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String applyDeptCode { get; set; }

        /// <summary>
        /// Applyareacode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "applyAreaCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String applyAreaCode { get; set; }

        /// <summary>
        /// Applydoctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "applyDoctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String applyDoctCode { get; set; }

        /// <summary>
        /// Checkopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String checkOperCode { get; set; }

        /// <summary>
        /// Checkdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.DateTime? checkDate { get; set; }

        /// <summary>
        /// Clinicdiag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clinicDiag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String clinicDiag { get; set; }

        /// <summary>
        /// Hissummary
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hisSummary", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String hisSummary { get; set; }

        /// <summary>
        /// Opssummary
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opsSummary", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String opsSummary { get; set; }

        /// <summary>
        /// Othsummary
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "othSummary", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String othSummary { get; set; }

        /// <summary>
        /// Receiptnote
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "receiptNote", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String receiptNote { get; set; }

        /// <summary>
        /// Regopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String regOperCode { get; set; }

        /// <summary>
        /// Regdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.DateTime regDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// confOperCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String confOperCode { get; set; }

        /// <summary>
        /// confDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.DateTime? confDate { get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String creator { get; set; }

        /// <summary>
        /// Creatdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.DateTime creatDate { get; set; }

        [DataMember]
        public int check { get; set; }

        [DataMember]
        public string age { get; set; }

        [DataMember]
        public string sampleClassName { get; set; }

        [DataMember]
        public string sexCH
        {
            get
            {
                if (sex == 1)
                    return "男";
                else if (sex == 2)
                    return "女";
                else
                    return "未知";
            }
            set { ;}
        }

        [DataMember]
        public string statusDesc
        {
            get
            {
                if (status == -1)
                    return "作废";
                else if (status == 0)
                    return "新建";
                else if (status == 1)
                    return "确认";
                else
                    return "";
            }
            set { ;}
        }

        [DataMember]
        public string statusName { get; set; }

        [DataMember]
        public string patTypeName
        {
            get
            {
                if (patType == 1)
                    return "急诊";
                else if (patType == 2)
                    return "门诊";
                else if (patType == 3)
                    return "住院";
                else if (patType == 4)
                    return "其他";
                else
                    return "";
            }
            set { ;}
        }

        [DataMember]
        public string applyDeptName { get; set; }

        [DataMember]
        public string applyDoctName { get; set; }

        [DataMember]
        public string confOperName { get; set; }

        [DataMember]
        public string regOperName { get; set; }

        [DataMember]
        public string checkOperName { get; set; }

        [DataMember]
        public string recDoctName { get; set; }

        [DataMember]
        public string confDoctName { get; set; }

        [DataMember]
        public string recDoctCode { get; set; }

        [DataMember]
        public DateTime? recDate { get; set; }

        [DataMember]
        public string recConfDoctCode { get; set; }

        [DataMember]
        public DateTime? recConfDate { get; set; }

        [DataMember]
        public string recConfDoctName { get; set; }

        /// <summary>
        /// 0 无效; 1 保存; 2 审核
        /// </summary>
        [DataMember]
        public int recStatus { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pNo = "pNo";
            public string ipNo = "ipNo";
            public string opNo = "opNo";
            public string patName = "patName";
            public string sex = "sex";
            public string birthday = "birthday";
            public string nation = "nation";
            public string native = "native";
            public string idNo = "idNo";
            public string workUnit = "workUnit";
            public string marry = "marry";
            public string patType = "patType";
            public string payType = "payType";
            public string contactAddr = "contactAddr";
            public string contactTel = "contactTel";
            public string bedNo = "bedNo";
            public string isEmer = "isEmer";
            public string isCharge = "isCharge";
            public string feeInfo = "feeInfo";
            public string sampleName = "sampleName";
            public string sampleDate = "sampleDate";
            public string sampleClassId = "sampleClassId";
            public string applyUnit = "applyUnit";
            public string applyDeptCode = "applyDeptCode";
            public string applyAreaCode = "applyAreaCode";
            public string applyDoctCode = "applyDoctCode";
            public string checkOperCode = "checkOperCode";
            public string checkDate = "checkDate";
            public string clinicDiag = "clinicDiag";
            public string hisSummary = "hisSummary";
            public string opsSummary = "opsSummary";
            public string othSummary = "othSummary";
            public string receiptNote = "receiptNote";
            public string regOperCode = "regOperCode";
            public string regDate = "regDate";
            public string status = "status";
            public string confOperCode = "confOperCode";
            public string confDate = "confDate";
            public string creator = "creator";
            public string creatDate = "creatDate";
            public string check = "check";
            public string age = "age";
            public string sampleClassName = "sampleClassName";
            public string statusDesc = "statusDesc";
            public string patTypeName = "patTypeName";
            public string applyDeptName = "applyDeptName";
            public string applyDoctName = "applyDoctName";
            public string confOperName = "confOperName";
            public string regOperName = "regOperName";
            public string checkOperName = "checkOperName";
            public string recDoctName = "recDoctName";
            public string confDoctName = "confDoctName";
            public string recDoctCode = "recDoctCode";
            public string recDate = "recDate";
            public string recConfDoctCode = "recConfDoctCode";
            public string recConfDate = "recConfDate";
            public string recConfDoctName = "recConfDoctName";
            public string recStatus = "recStatus";
        }
    }

}
