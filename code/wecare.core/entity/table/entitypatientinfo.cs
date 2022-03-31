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
    /// PATIENTINFO
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "PATIENTINFO")]
    public class EntityPatientInfo : BaseDataContract
    {
        /// <summary>
        /// PID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PID", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String pid { get; set; }

        /// <summary>
        /// CARD_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CARD_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// IP_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "IP_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String ipNo { get; set; }

        /// <summary>
        /// CL_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CL_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String clNo { get; set; }

        /// <summary>
        /// PM_ID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PM_ID", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pmId { get; set; }

        /// <summary>
        /// MC_ID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_ID", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String mcId { get; set; }

        /// <summary>
        /// FEE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String feeCode { get; set; }

        /// <summary>
        /// NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String name { get; set; }

        /// <summary>
        /// SEX
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SEX", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String sex { get; set; }

        /// <summary>
        /// BIRTH
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BIRTH", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String birth { get; set; }

        /// <summary>
        /// MARRY
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MARRY", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String marry { get; set; }

        /// <summary>
        /// JOB
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "JOB", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String job { get; set; }

        /// <summary>
        /// BIRTHAREA
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BIRTHAREA", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String birthArea { get; set; }

        /// <summary>
        /// NATION
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NATION", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String nation { get; set; }

        /// <summary>
        /// COUNTRY
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "COUNTRY", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String country { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ID", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String ID { get; set; }

        /// <summary>
        /// AREA
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "AREA", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String area { get; set; }

        /// <summary>
        /// CORP
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CORP", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String corp { get; set; }

        /// <summary>
        /// C_TEL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "C_TEL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String cTel { get; set; }

        /// <summary>
        /// C_ZIP
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "C_ZIP", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String cZip { get; set; }

        /// <summary>
        /// ADDR
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ADDR", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String addr { get; set; }

        /// <summary>
        /// TEL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TEL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String tel { get; set; }

        /// <summary>
        /// ZIP
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ZIP", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String zip { get; set; }

        /// <summary>
        /// EMAIL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EMAIL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String email { get; set; }

        /// <summary>
        /// CONTACT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONTACT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String contact { get; set; }

        /// <summary>
        /// RELATION
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RELATION", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String relation { get; set; }

        /// <summary>
        /// CONT_ADDR
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONT_ADDR", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String contAddr { get; set; }

        /// <summary>
        /// CONT_TEL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONT_TEL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String contTel { get; set; }

        /// <summary>
        /// BT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String bt { get; set; }

        /// <summary>
        /// S_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "S_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal sSum { get; set; }

        /// <summary>
        /// REG_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String regDate { get; set; }

        /// <summary>
        /// REG_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String regTime { get; set; }

        /// <summary>
        /// REG_OPER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_OPER", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String regOper { get; set; }

        /// <summary>
        /// LOCK_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LOCK_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String lockDate { get; set; }

        /// <summary>
        /// LOCK_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LOCK_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String lockTime { get; set; }

        /// <summary>
        /// LOCK_OPER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LOCK_OPER", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String lockOper { get; set; }

        /// <summary>
        /// LOCK_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LOCK_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String lockFlag { get; set; }

        /// <summary>
        /// PARENT_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PARENT_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String parentName { get; set; }

        /// <summary>
        /// UP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "UP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String upFlag { get; set; }

        /// <summary>
        /// Nh_Id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nh_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String nhId { get; set; }

        /// <summary>
        /// Loc_Acc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "loc_acc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String locAcc { get; set; }

        /// <summary>
        /// Modi_Date
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modi_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.DateTime? modiDate { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "note", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.String note { get; set; }

        /// <summary>
        /// Trem_Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "trem_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.String tremType { get; set; }

        /// <summary>
        /// 性别(中文)
        /// </summary>
        [DataMember]
        public string sexCH
        {
            get
            {
                if (sex == "1")
                    return "男";
                else if (sex == "2")
                    return "女";
                else
                    return string.Empty;
            }
            set { ;}
        }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        public string age
        {
            get
            {
                if (!string.IsNullOrEmpty(birth))
                {
                    return weCare.Core.Utils.CalcAge.GetAge(Convert.ToDateTime(birth));
                }
                return string.Empty;
            }
            set { ;}
        }

        [DataMember]
        public string deptCode { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string doctCode { get; set; }

        [DataMember]
        public string doctName { get; set; }

        [DataMember]
        public int ipTimes { get; set; }

        [DataMember]
        public string bedNo { get; set; }

        [DataMember]
        public DateTime? inDate { get; set; }

        [DataMember]
        public DateTime? outDate { get; set; }

        [DataMember]
        public string toolTip { get; set; }

        /// <summary>
        /// 血透编号
        /// </summary>
        [DataMember]
        public string hdNo { get; set; }

        /// <summary>
        /// 血透时间
        /// </summary>
        [DataMember]
        public string hdDate { get; set; }

        /// <summary>
        /// 诊间编号
        /// </summary>
        [DataMember]
        public string roomCode { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        [DataMember]
        public string shiftCode { get; set; }

        [DataMember]
        public int carelevel { get; set; }

        /// <summary>
        /// 护理等级(简)
        /// </summary>
        public string carelevelNameSimple
        {
            get
            {
                if (carelevel == -1)
                {
                    return "";
                }
                else if (carelevel == 0)
                {
                    return "特级";
                }
                else if (carelevel == 1)
                {
                    return "一级";
                }
                else if (carelevel == 2)
                {
                    return "二级";
                }
                else if (carelevel == 3)
                {
                    return "三级";
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        [DataMember]
        public string diagDesc { get; set; }

        [DataMember]
        public string registerId { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pid = "pid";
            public string cardNo = "cardNo";
            public string ipNo = "ipNo";
            public string clNo = "clNo";
            public string pmId = "pmId";
            public string mcId = "mcId";
            public string feeCode = "feeCode";
            public string name = "name";
            public string sex = "sex";
            public string birth = "birth";
            public string marry = "marry";
            public string job = "job";
            public string birthArea = "birthArea";
            public string nation = "nation";
            public string country = "country";
            public string ID = "ID";
            public string area = "area";
            public string corp = "corp";
            public string cTel = "cTel";
            public string cZip = "cZip";
            public string addr = "addr";
            public string tel = "tel";
            public string zip = "zip";
            public string email = "email";
            public string contact = "contact";
            public string relation = "relation";
            public string contAddr = "contAddr";
            public string contTel = "contTel";
            public string bt = "bt";
            public string sSum = "sSum";
            public string regDate = "regDate";
            public string regTime = "regTime";
            public string regOper = "regOper";
            public string lockDate = "lockDate";
            public string lockTime = "lockTime";
            public string lockOper = "lockOper";
            public string lockFlag = "lockFlag";
            public string parentName = "parentName";
            public string upFlag = "upFlag";
            public string nhId = "nhId";
            public string locAcc = "locAcc";
            public string modiDate = "modiDate";
            public string note = "note";
            public string tremType = "tremType";
            public string sexCH = "sexCH";
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string registerId = "registerId";
        }
    }

}
