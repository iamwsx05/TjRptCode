using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region EntityIpRegister
    /// <summary>
    /// t_ip_register
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipRegisterCp")]
    public class EntityIpRegisterCP : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Registerdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.DateTime Registerdate { get; set; }

        /// <summary>
        /// Indate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "indate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime? Indate { get; set; }

        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Patientid { get; set; }

        /// <summary>
        /// Patientipno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientipno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Patientipno { get; set; }

        /// <summary>
        /// Iptimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iptimes", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Iptimes { get; set; }

        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? Areaid { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Deptid { get; set; }

        /// <summary>
        /// Bedid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Bedid { get; set; }

        /// <summary>
        /// Carelevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "carelevel", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? Carelevel { get; set; }

        /// <summary>
        /// Termid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "termid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal? Termid { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? Doctid { get; set; }

        /// <summary>
        /// Paytype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paytype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Paytype { get; set; }

        /// <summary>
        /// Indiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "indiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Indiagnosis { get; set; }

        /// <summary>
        /// Outdiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outdiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Outdiagnosis { get; set; }

        /// <summary>
        /// Outtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal? Outtype { get; set; }

        /// <summary>
        /// Outdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.DateTime? Outdate { get; set; }

        /// <summary>
        /// Inoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inoperid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal? Inoperid { get; set; }

        /// <summary>
        /// Outoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outoperid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal? Outoperid { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Opdiagnosis
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opdiagnosis", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String Opdiagnosis { get; set; }

        /// <summary>
        /// Opdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opdoctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal? Opdoctid { get; set; }

        /// <summary>
        /// Illnessstate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illnessstate", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? Illnessstate { get; set; }

        /// <summary>
        /// Deathdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deathdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.DateTime? Deathdate { get; set; }

        /// <summary>
        /// Illcasecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illcasecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Illcasecode { get; set; }

        /// <summary>
        /// Printflag
        /// </summary>
        [EntityAttribute(FieldName = "printflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal? Printflag { get; set; }

        /// <summary>
        /// Supdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "supdoctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal? Supdoctid { get; set; }

        /// <summary>
        /// Dirdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dirdoctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Decimal? Dirdoctid { get; set; }

        /// <summary>
        /// Nurgroupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nurgroupno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Nurgroupno { get; set; }

        /// <summary>
        /// Opstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal? Opstatus { get; set; }

        /// <summary>
        /// Transflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "transflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal? Transflag { get; set; }

        /// <summary>
        /// Uploadcaseflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "uploadcaseflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Decimal? Uploadcaseflag { get; set; }

        /// <summary>
        /// Identityid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "identityid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Decimal? Identityid { get; set; }

        /// <summary>
        /// Intype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "intype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Decimal? Intype { get; set; }

        /// <summary>
        /// Barcodeprtflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "barcodeprtflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.Decimal? Barcodeprtflag { get; set; }

        /// <summary>
        /// Patienttype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patienttype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.Decimal? Patienttype { get; set; }

        /// <summary>
        /// Iptolgoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iptolgoperid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.Decimal? Iptolgoperid { get; set; }

        /// <summary>
        /// Iptolgopdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iptolgopdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.DateTime? Iptolgopdate { get; set; }

        /// <summary>
        /// Hisglobalid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hisglobalid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.Decimal? Hisglobalid { get; set; }

        /// <summary>
        /// Isallowupload
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isallowupload", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.Decimal? Isallowupload { get; set; }

        /// <summary>
        /// Allowuploaddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "allowuploaddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.DateTime? Allowuploaddate { get; set; }

        /// <summary>
        /// Allowuploadopername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "allowuploadopername", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Allowuploadopername { get; set; }

        /// <summary>
        /// Cpstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.Decimal? Cpstatus { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Registerid = "Registerid";
            public string Registerdate = "Registerdate";
            public string Indate = "Indate";
            public string Patientid = "Patientid";
            public string Patientipno = "Patientipno";
            public string Iptimes = "Iptimes";
            public string Areaid = "Areaid";
            public string Deptid = "Deptid";
            public string Bedid = "Bedid";
            public string Carelevel = "Carelevel";
            public string Termid = "Termid";
            public string Doctid = "Doctid";
            public string Paytype = "Paytype";
            public string Indiagnosis = "Indiagnosis";
            public string Outdiagnosis = "Outdiagnosis";
            public string Outtype = "Outtype";
            public string Outdate = "Outdate";
            public string Inoperid = "Inoperid";
            public string Outoperid = "Outoperid";
            public string Status = "Status";
            public string Opdiagnosis = "Opdiagnosis";
            public string Opdoctid = "Opdoctid";
            public string Illnessstate = "Illnessstate";
            public string Deathdate = "Deathdate";
            public string Illcasecode = "Illcasecode";
            public string Printflag = "Printflag";
            public string Supdoctid = "Supdoctid";
            public string Dirdoctid = "Dirdoctid";
            public string Nurgroupno = "Nurgroupno";
            public string Opstatus = "Opstatus";
            public string Transflag = "Transflag";
            public string Uploadcaseflag = "Uploadcaseflag";
            public string Identityid = "Identityid";
            public string Intype = "Intype";
            public string Barcodeprtflag = "Barcodeprtflag";
            public string Patienttype = "Patienttype";
            public string Iptolgoperid = "Iptolgoperid";
            public string Iptolgopdate = "Iptolgopdate";
            public string Hisglobalid = "Hisglobalid";
            public string Isallowupload = "Isallowupload";
            public string Allowuploaddate = "Allowuploaddate";
            public string Allowuploadopername = "Allowuploadopername";
            public string Cpstatus = "Cpstatus";
        }
    }
    #endregion

    #region EntityIpDiagnosisicd
    /// <summary>
    /// EntityIpDiagnosisicd
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipDiagnosisicd")]
    public class EntityIpDiagnosisicd : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Type { get; set; }

        /// <summary>
        /// Icdcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Icdcode { get; set; }

        /// <summary>
        /// Icdname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Icdname { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? Flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Registerid = "Registerid";
            public string Type = "Type";
            public string Icdcode = "Icdcode";
            public string Icdname = "Icdname";
            public string Flag = "Flag";
        }
    }

    #endregion

    #region EntityCpExecplan
    /// <summary>
    /// EntityCpExecplan
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplan")]
    public class EntityCpExecplan : BaseDataContract, IComparable
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Areaid { get; set; }

        /// <summary>
        /// Termid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "termid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? Termid { get; set; }

        /// <summary>
        /// Bedid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? Bedid { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Doctid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Indesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "indesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Indesc { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Nodetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal? Nodetype { get; set; }

        /// <summary>
        /// Currdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "currdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? Currdate { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.DateTime Begindate { get; set; }

        /// <summary>
        /// Enddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "enddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime? Enddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "syncode", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Syncode { get; set; }

        /// <summary>
        /// Lmaxgroupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lmaxgroupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Lmaxgroupno { get; set; }

        /// <summary>
        /// Tmaxgroupno
        /// </summary>
        [EntityAttribute(FieldName = "tmaxgroupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal? Tmaxgroupno { get; set; }

        /// <summary>
        /// Recorder
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorder", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal? Recorder { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Illstate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illstate", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String Illstate { get; set; }

        /// <summary>
        /// Phyexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "phyexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Phyexam { get; set; }

        /// <summary>
        /// Othexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "othexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String Othexam { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Registerid = "Registerid";
            public string Deptid = "Deptid";
            public string Areaid = "Areaid";
            public string Termid = "Termid";
            public string Bedid = "Bedid";
            public string Doctid = "Doctid";
            public string Cpid = "Cpid";
            public string Indesc = "Indesc";
            public string Nodename = "Nodename";
            public string Nodetype = "Nodetype";
            public string Currdate = "Currdate";
            public string Begindate = "Begindate";
            public string Enddate = "Enddate";
            public string Status = "Status";
            public string Syncode = "Syncode";
            public string Lmaxgroupno = "Lmaxgroupno";
            public string Tmaxgroupno = "Tmaxgroupno";
            public string Recorder = "Recorder";
            public string Recorddate = "Recorddate";
            public string Illstate = "Illstate";
            public string Phyexam = "Phyexam";
            public string Othexam = "Othexam";
            public string Cpname = "Cpname";
        }
        [DataMember]
        public string Cpname { get; set; }
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityCpExecplan)
            {
                return this.Execid.CompareTo(((EntityCpExecplan)obj).Execid);
            }
            return 0;
        }
    }
    #endregion

    #region EntityCpExecplanTrack
    /// <summary>
    /// EntityCpExecplanTrack
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplantrack")]
    public class EntityCpExecplanTrack : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Nodetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Nodetype { get; set; }

        /// <summary>
        /// Day
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "day", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? Day { get; set; }

        /// <summary>
        /// Execoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execoperid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Execoperid { get; set; }

        /// <summary>
        /// Execdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime Execdate { get; set; }

        /// <summary>
        /// Day
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Status { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime? Begindate { get; set; }

        /// <summary>
        /// Execcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execcontent", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 10)]
        public System.String Execcontent { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Nodetype = "Nodetype";
            public string Day = "Day";
            public string Execoperid = "Execoperid";
            public string Execdate = "Execdate";
            public string Status = "Status";
            public string Begindate = "Begindate";
            public string Nodedesc = "Nodedesc";
            public string Isleafnode = "Isleafnode";
            public string Cpname = "Cpname";
            public string Execcontent = "Execcontent";
        }
        [DataMember]
        public string Cpname { get; set; }
        /// <summary>
        /// Nodedesc
        /// </summary>
        [DataMember]
        public System.String Nodedesc { get; set; }
        /// <summary>
        /// 末节点
        /// </summary>
        [DataMember]
        public bool Isleafnode { get; set; }
    }
    #endregion

    #region EntityCpExecNodeReturnLog
    /// <summary>
    /// EntityCpExecNodeReturnLog
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecnodereturnlog")]
    public class EntityCpExecNodeReturnLog : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Nodetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Nodetype { get; set; }

        /// <summary>
        /// Returnoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "returnoperid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Returnoperid { get; set; }

        /// <summary>
        /// Returndate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "returndate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime Returndate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Execid = "Execid";
            public string Nodename = "Nodename";
            public string Nodetype = "Nodetype";
            public string Returnoperid = "Returnoperid";
            public string Returndate = "Returndate";
        }
    }
    #endregion

    #region EntityCpExecplanVar
    /// <summary>
    /// EntityCpExecplanVar
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanvar")]
    public class EntityCpExecplanVar : BaseDataContract
    {
        /// <summary>
        /// Varid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Varid { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Vardate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vardate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime Vardate { get; set; }

        /// <summary>
        /// Vareffect
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vareffect", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Vareffect { get; set; }

        /// <summary>
        /// Syndrome
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "syndrome", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Syndrome { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? Doctid { get; set; }

        /// <summary>
        /// Doctdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? Doctdate { get; set; }

        /// <summary>
        /// Nurseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nurseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Nurseid { get; set; }

        /// <summary>
        /// Nursedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nursedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? Nursedate { get; set; }

        /// <summary>
        /// Operid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal Operid { get; set; }

        /// <summary>
        /// Operdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime Operdate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Varid = "Varid";
            public string Execid = "Execid";
            public string Registerid = "Registerid";
            public string Vardate = "Vardate";
            public string Vareffect = "Vareffect";
            public string Syndrome = "Syndrome";
            public string Doctid = "Doctid";
            public string Doctdate = "Doctdate";
            public string Nurseid = "Nurseid";
            public string Nursedate = "Nursedate";
            public string Operid = "Operid";
            public string Operdate = "Operdate";
            public string Status = "Status";
        }
    }

    #endregion

    #region EntityCpExecplanOrderdiffrate
    /// <summary>
    /// EntityCpExecplanOrderdiffrate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanorderdiffrate")]
    public class EntityCpExecplanOrderdiffrate : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Type { get; set; }

        /// <summary>
        /// Orgpkid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orgpkid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Orgpkid { get; set; }

        /// <summary>
        /// Itemcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Itemcode { get; set; }

        /// <summary>
        /// Itemname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 6)]
        public System.String Itemname { get; set; }

        /// <summary>
        /// Diffinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "diffinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Diffinfo { get; set; }

        /// <summary>
        /// Recorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorderid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Recorderid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Nodename = "Nodename";
            public string Type = "Type";
            public string Orgpkid = "Orgpkid";
            public string Itemcode = "Itemcode";
            public string Itemname = "Itemname";
            public string Diffinfo = "Diffinfo";
            public string Recorderid = "Recorderid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            public string Sortno = "Sortno";
        }
        [DataMember]
        public int Sortno { get; set; }
    }

    #endregion

    #region EntityCpExecplanOrderdetail
    /// <summary>
    /// EntityCpExecplanOrderdetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanorderdetail")]
    public class EntityCpExecplanOrderdetail : BaseDataContract
    {
        /// <summary>
        /// Orderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Orderid { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Makedeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Makedeptid { get; set; }

        /// <summary>
        /// Makeareaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makeareaid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Makeareaid { get; set; }

        /// <summary>
        /// Maketermid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maketermid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Maketermid { get; set; }

        /// <summary>
        /// Makeoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makeoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Makeoperid { get; set; }

        /// <summary>
        /// Makestartdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makestartdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? Makestartdate { get; set; }

        /// <summary>
        /// Makesysdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makesysdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime Makesysdate { get; set; }

        /// <summary>
        /// Confirmoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Confirmoperid { get; set; }

        /// <summary>
        /// Confirmdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.DateTime? Confirmdate { get; set; }

        /// <summary>
        /// Affirmdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "affirmdoctid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Affirmdoctid { get; set; }

        /// <summary>
        /// Affirmdoctdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "affirmdoctdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.DateTime? Affirmdoctdate { get; set; }

        /// <summary>
        /// Affirmnurseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "affirmnurseid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Affirmnurseid { get; set; }

        /// <summary>
        /// Affirmnursedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "affirmnursedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.DateTime? Affirmnursedate { get; set; }

        /// <summary>
        /// Execnurseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execnurseid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Execnurseid { get; set; }

        /// <summary>
        /// Execdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.DateTime? Execdate { get; set; }

        /// <summary>
        /// Execrecdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execrecdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.DateTime? Execrecdate { get; set; }

        /// <summary>
        /// Orderclassid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderclassid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal? Orderclassid { get; set; }

        /// <summary>
        /// Ordertypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordertypeid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Ordertypeid { get; set; }

        /// <summary>
        /// Dosageformclassid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageformclassid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? Dosageformclassid { get; set; }

        /// <summary>
        /// Dosageformid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageformid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Decimal? Dosageformid { get; set; }

        /// <summary>
        /// Medattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "medattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Decimal? Medattributeid { get; set; }

        /// <summary>
        /// Valuableflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "valuableflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal? Valuableflag { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Orderprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderprtname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Orderprtname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosagescale
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosagescale", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Decimal? Dosagescale { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Dosageunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String Dosageunitname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Sampleid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sampleid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Sampleid { get; set; }

        /// <summary>
        /// Driprate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "driprate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.String Driprate { get; set; }

        /// <summary>
        /// Days
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "days", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.Decimal? Days { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.Decimal? Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.Decimal? Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 47)]
        public System.Decimal? Total { get; set; }

        /// <summary>
        /// Packunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 48)]
        public System.String Packunitid { get; set; }

        /// <summary>
        /// Packqty
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packqty", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 49)]
        public System.Decimal? Packqty { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 50)]
        public System.Decimal Sortno { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 51)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentorderid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 52)]
        public System.String Parentorderid { get; set; }

        /// <summary>
        /// Numberfirst
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "numberfirst", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 53)]
        public System.Decimal? Numberfirst { get; set; }

        /// <summary>
        /// Numberend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "numberend", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 54)]
        public System.Decimal? Numberend { get; set; }

        /// <summary>
        /// Skintestflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "skintestflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 55)]
        public System.Decimal Skintestflag { get; set; }

        /// <summary>
        /// Skintestresult
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "skintestresult", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 56)]
        public System.Decimal? Skintestresult { get; set; }

        /// <summary>
        /// Otherpackflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "otherpackflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 57)]
        public System.Decimal? Otherpackflag { get; set; }

        /// <summary>
        /// Feetypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "feetypeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 58)]
        public System.Decimal Feetypeid { get; set; }

        /// <summary>
        /// Sourceid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sourceid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 59)]
        public System.Decimal? Sourceid { get; set; }

        /// <summary>
        /// Urgencyflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "urgencyflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 60)]
        public System.Decimal? Urgencyflag { get; set; }

        /// <summary>
        /// Addflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "addflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 61)]
        public System.Decimal? Addflag { get; set; }

        /// <summary>
        /// Drugflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drugflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 62)]
        public System.Decimal? Drugflag { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 63)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 64)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Execareaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execareaid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 65)]
        public System.String Execareaid { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 66)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Stopdoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stopdoctid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 67)]
        public System.String Stopdoctid { get; set; }

        /// <summary>
        /// Stopddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stopddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 68)]
        public System.DateTime? Stopddate { get; set; }

        /// <summary>
        /// Stopsysdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stopsysdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 69)]
        public System.DateTime? Stopsysdate { get; set; }

        /// <summary>
        /// Stoptypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stoptypeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 70)]
        public System.Decimal? Stoptypeid { get; set; }

        /// <summary>
        /// Stopnurseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stopnurseid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 71)]
        public System.String Stopnurseid { get; set; }

        /// <summary>
        /// Stopndate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "stopndate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 72)]
        public System.DateTime? Stopndate { get; set; }

        /// <summary>
        /// Deloperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deloperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 73)]
        public System.String Deloperid { get; set; }

        /// <summary>
        /// Deldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deldate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 74)]
        public System.DateTime? Deldate { get; set; }

        /// <summary>
        /// Canceloperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "canceloperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 75)]
        public System.String Canceloperid { get; set; }

        /// <summary>
        /// Canceldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "canceldate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 76)]
        public System.DateTime? Canceldate { get; set; }

        /// <summary>
        /// Confirmcanceloperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmcanceloperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 77)]
        public System.String Confirmcanceloperid { get; set; }

        /// <summary>
        /// Confirmcanceldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmcanceldate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 78)]
        public System.DateTime? Confirmcanceldate { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 79)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 80)]
        public System.Decimal Isrequired { get; set; }

        /// <summary>
        /// Isappend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isappend", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 81)]
        public System.Decimal Isappend { get; set; }

        /// <summary>
        /// Packsn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packsn", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 82)]
        public System.String Packsn { get; set; }

        /// <summary>
        /// Isexec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isexec", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 83)]
        public System.Decimal Isexec { get; set; }

        /// <summary>
        /// Illstate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illstate", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 84)]
        public System.String Illstate { get; set; }

        /// <summary>
        /// Phyexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "phyexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 85)]
        public System.String Phyexam { get; set; }

        /// <summary>
        /// Othexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "othexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 86)]
        public System.String Othexam { get; set; }

        /// <summary>
        /// Pharmacyno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pharmacyno", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 87)]
        public System.String Pharmacyno { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "nodedays", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 88)]
        public System.Decimal Nodedays { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "caseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 89)]
        public System.Decimal? Caseid { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "ordersn", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 90)]
        public System.Decimal? Ordersn { get; set; }

        [DataMember]
        public System.Int32 OrderSn { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Orderid = "Orderid";
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Registerid = "Registerid";
            public string Makedeptid = "Makedeptid";
            public string Makeareaid = "Makeareaid";
            public string Maketermid = "Maketermid";
            public string Makeoperid = "Makeoperid";
            public string Makestartdate = "Makestartdate";
            public string Makesysdate = "Makesysdate";
            public string Confirmoperid = "Confirmoperid";
            public string Confirmdate = "Confirmdate";
            public string Affirmdoctid = "Affirmdoctid";
            public string Affirmdoctdate = "Affirmdoctdate";
            public string Affirmnurseid = "Affirmnurseid";
            public string Affirmnursedate = "Affirmnursedate";
            public string Execnurseid = "Execnurseid";
            public string Execdate = "Execdate";
            public string Execrecdate = "Execrecdate";
            public string Orderclassid = "Orderclassid";
            public string Ordertypeid = "Ordertypeid";
            public string Dosageformclassid = "Dosageformclassid";
            public string Dosageformid = "Dosageformid";
            public string Medattributeid = "Medattributeid";
            public string Valuableflag = "Valuableflag";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Orderprtname = "Orderprtname";
            public string Dosage = "Dosage";
            public string Dosagescale = "Dosagescale";
            public string Dosageunitid = "Dosageunitid";
            public string Dosageunitname = "Dosageunitname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Sampleid = "Sampleid";
            public string Driprate = "Driprate";
            public string Days = "Days";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Packunitid = "Packunitid";
            public string Packqty = "Packqty";
            public string Sortno = "Sortno";
            public string Parentflag = "Parentflag";
            public string Parentorderid = "Parentorderid";
            public string Numberfirst = "Numberfirst";
            public string Numberend = "Numberend";
            public string Skintestflag = "Skintestflag";
            public string Skintestresult = "Skintestresult";
            public string Otherpackflag = "Otherpackflag";
            public string Feetypeid = "Feetypeid";
            public string Sourceid = "Sourceid";
            public string Urgencyflag = "Urgencyflag";
            public string Addflag = "Addflag";
            public string Drugflag = "Drugflag";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Execareaid = "Execareaid";
            public string Status = "Status";
            public string Stopdoctid = "Stopdoctid";
            public string Stopddate = "Stopddate";
            public string Stopsysdate = "Stopsysdate";
            public string Stoptypeid = "Stoptypeid";
            public string Stopnurseid = "Stopnurseid";
            public string Stopndate = "Stopndate";
            public string Deloperid = "Deloperid";
            public string Deldate = "Deldate";
            public string Canceloperid = "Canceloperid";
            public string Canceldate = "Canceldate";
            public string Confirmcanceloperid = "Confirmcanceloperid";
            public string Confirmcanceldate = "Confirmcanceldate";
            public string Entrustinfo = "Entrustinfo";
            public string Isrequired = "Isrequired";
            public string Isappend = "Isappend";
            public string Packsn = "Packsn";
            public string Isexec = "Isexec";
            public string Illstate = "Illstate";
            public string Phyexam = "Phyexam";
            public string Othexam = "Othexam";
            public string Pharmacyno = "Pharmacyno";
            public string Nodedays = "Nodedays";
            public string Caseid = "Caseid";
            public string Ordersn = "Ordersn";

            public string Requirename = "Requirename";
            public string Orderclassname = "Orderclassname";
            public string Otherpackflagname = "Otherpackflagname";
            public string Skintestflagname = "Skintestflagname";
            public string Urgencyflagname = "Urgencyflagname";
        }
        [DataMember]
        public string Requirename { get; set; }

        [DataMember]
        public string Orderclassname { get; set; }

        [DataMember]
        public string Otherpackflagname { get; set; }

        [DataMember]
        public string Skintestflagname { get; set; }

        [DataMember]
        public string Urgencyflagname { get; set; }
    }
    #endregion

    #region EntityCpExecplanDnDetail
    /// <summary>
    /// EntityCpExecplanDnDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplandndetail")]
    public class EntityCpExecplanDnDetail : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Classid { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Typeid { get; set; }

        /// <summary>
        /// Workdesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "workdesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Workdesc { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Casecode { get; set; }

        /// <summary>
        /// Casename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Casename { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Isrequired { get; set; }

        /// <summary>
        /// Isappend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isappend", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal Isappend { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Sortno { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Classid = "Classid";
            public string Typeid = "Typeid";
            public string Workdesc = "Workdesc";
            public string Casecode = "Casecode";
            public string Casename = "Casename";
            public string Isrequired = "Isrequired";
            public string Isappend = "Isappend";
            public string Sortno = "Sortno";
            public string Status = "Status";

            public string Checked = "Checked";
            public string Classname = "Classname";
            public string Requirename = "Requirename";
            public string Typename = "Typename";
        }
        [DataMember]
        public int Checked { get; set; }

        [DataMember]
        public string Classname { get; set; }

        [DataMember]
        public string Requirename { get; set; }

        [DataMember]
        public string Typename { get; set; }
    }
    #endregion

    #region EntityCpExecplanVardetail
    /// <summary>
    /// EntityCpExecplanVardetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanvardetail")]
    public class EntityCpExecplanVardetail : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Varid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Varid { get; set; }

        /// <summary>
        /// Varcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Varcontent { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Varid = "Varid";
            public string Varcontent = "Varcontent";
            public string Sortno = "Sortno";
        }
    }
    #endregion

    #region EntityCpExecplanStatindex
    /// <summary>
    /// EntityCpExecplanStatindex
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanstatindex")]
    public class EntityCpExecplanStatindex : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Statcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "statcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Statcode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Statcode = "Statcode";
        }
    }
    #endregion

    #region EntityCpExecplanConfirmHerbal
    /// <summary>
    /// EntityCpExecplanConfirmHerbal
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanconfirmherbal")]
    public class EntityCpExecplanConfirmHerbal : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Isconfirm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isconfirm", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Isconfirm { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Nodename = "Nodename";
            public string Recipeid = "Recipeid";
            public string Isconfirm = "Isconfirm";
        }
    }

    #endregion

    #region EntityCpExecplanHerbalRecipe
    /// <summary>
    /// EntityCpExecplanHerbalRecipe
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanherbalrecipe")]
    public class EntityCpExecplanHerbalRecipe : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Orderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Orderid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Patientid { get; set; }

        /// <summary>
        /// Identityid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "identityid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Identityid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 8)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Recipename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Recipename { get; set; }

        /// <summary>
        /// Recipeattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? Recipeattributeid { get; set; }

        /// <summary>
        /// Recipetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal Recipetype { get; set; }

        /// <summary>
        /// Typeida
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeida", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Typeida { get; set; }

        /// <summary>
        /// Typeidb
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidb", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Typeidb { get; set; }

        /// <summary>
        /// Typeidc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidc", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal Typeidc { get; set; }

        /// <summary>
        /// Begindatetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindatetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? Begindatetype { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime Begindate { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Decoction { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoctionname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Decoctionname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Packs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packs", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Decimal Packs { get; set; }

        /// <summary>
        /// Outflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal Outflag { get; set; }

        /// <summary>
        /// Helpflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "helpflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal Helpflag { get; set; }

        /// <summary>
        /// Recipemoney
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipemoney", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Decimal? Recipemoney { get; set; }

        /// <summary>
        /// Makedoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedoctid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Makedoctid { get; set; }

        /// <summary>
        /// Makedeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Makedeptid { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Recordoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String Recordoperid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.Decimal Isrequired { get; set; }

        /// <summary>
        /// Isappend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isappend", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.Decimal? Isappend { get; set; }

        /// <summary>
        /// Isexec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isexec", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.Decimal? Isexec { get; set; }

        /// <summary>
        /// Confirmoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String Confirmoperid { get; set; }

        /// <summary>
        /// Confirmdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.DateTime? Confirmdate { get; set; }

        /// <summary>
        /// Recipecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Recipecode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Orderid = "Orderid";
            public string Registerid = "Registerid";
            public string Patientid = "Patientid";
            public string Identityid = "Identityid";
            public string Recipeid = "Recipeid";
            public string Recipename = "Recipename";
            public string Recipeattributeid = "Recipeattributeid";
            public string Recipetype = "Recipetype";
            public string Typeida = "Typeida";
            public string Typeidb = "Typeidb";
            public string Typeidc = "Typeidc";
            public string Begindatetype = "Begindatetype";
            public string Begindate = "Begindate";
            public string Decoction = "Decoction";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Dosage = "Dosage";
            public string Dosageunitid = "Dosageunitid";
            public string Packs = "Packs";
            public string Outflag = "Outflag";
            public string Helpflag = "Helpflag";
            public string Recipemoney = "Recipemoney";
            public string Makedoctid = "Makedoctid";
            public string Makedeptid = "Makedeptid";
            public string Execdeptid = "Execdeptid";
            public string Entrustinfo = "Entrustinfo";
            public string Recordoperid = "Recordoperid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            public string Isrequired = "Isrequired";
            public string Isappend = "Isappend";
            public string Isexec = "Isexec";
            public string Confirmoperid = "Confirmoperid";
            public string Confirmdate = "Confirmdate";
            public string Recipecode = "Recipecode";

            public string Decoctionname = "Decoctionname";
            public string Execdeptname = "Execdeptname";

            public string IsNew = "IsNew";
        }
        [DataMember]
        public bool IsNew { get; set; }

    }

    #endregion

    #region EntityCpExecplanHerbalDetail
    /// <summary>
    /// EntityCpExecplanHerbalDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanherbaldetail")]
    public class EntityCpExecplanHerbalDetail : BaseDataContract
    {
        /// <summary>
        /// Recipesubid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipesubid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Recipesubid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Orderprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderprtname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderprtname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal Total { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Parentid { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "comment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Comment { get; set; }

        /// <summary>
        /// Isappend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isappend", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal Isappend { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipesubid = "Recipesubid";
            public string Recipeid = "Recipeid";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Orderprtname = "Orderprtname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Parentflag = "Parentflag";
            public string Parentid = "Parentid";
            public string Sortno = "Sortno";
            public string Comment = "Comment";
            public string Isappend = "Isappend";
            public string Execid = "Execid";
        }
    }

    #endregion

    #region EntityCpOut
    /// <summary>
    /// EntityCpOut
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpOut")]
    public class EntityCpOut : BaseDataContract
    {
        /// <summary>
        /// Outid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Outid { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Doctid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Outdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime Outdate { get; set; }

        /// <summary>
        /// Outtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Outtype { get; set; }

        /// <summary>
        /// Evaluation
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "evaluation", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? Evaluation { get; set; }

        /// <summary>
        /// Outinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Outinfo { get; set; }

        /// <summary>
        /// Operid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Operid { get; set; }

        /// <summary>
        /// Operdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime Operdate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Outid = "Outid";
            public string Doctid = "Doctid";
            public string Registerid = "Registerid";
            public string Outdate = "Outdate";
            public string Outtype = "Outtype";
            public string Evaluation = "Evaluation";
            public string Outinfo = "Outinfo";
            public string Operid = "Operid";
            public string Operdate = "Operdate";
            public string Status = "Status";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
        }

        [DataMember]
        public decimal Cpid { get; set; }

        [DataMember]
        public string Nodename { get; set; }
    }

    #endregion

    #region EntityCpOutcridetail
    /// <summary>
    /// EntityCpOutcridetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpOutcridetail")]
    public class EntityCpOutcridetail : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Outid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Outid { get; set; }

        /// <summary>
        /// Cricontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cricontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Cricontent { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Sortno { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Outid = "Outid";
            public string Cricontent = "Cricontent";
            public string Sortno = "Sortno";
        }
    }

    #endregion

    #region EntityCpExecPlanVar
    /// <summary>
    /// EntityCpExecPlanVar
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanvar")]
    public class EntityCpExecPlanVar : BaseDataContract
    {
        /// <summary>
        /// Varid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Varid { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Vardate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vardate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime Vardate { get; set; }

        /// <summary>
        /// Vartype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vartype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Vartype { get; set; }

        /// <summary>
        /// Newcpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "newcpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? Newcpid { get; set; }

        /// <summary>
        /// Vareffect
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vareffect", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Vareffect { get; set; }

        /// <summary>
        /// Varcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Varcontent { get; set; }

        /// <summary>
        /// Doctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Doctid { get; set; }

        /// <summary>
        /// Doctdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? Doctdate { get; set; }

        /// <summary>
        /// Nurseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nurseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal? Nurseid { get; set; }

        /// <summary>
        /// Nursedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nursedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? Nursedate { get; set; }

        /// <summary>
        /// Operid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Operid { get; set; }

        /// <summary>
        /// Operdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime Operdate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Varid = "Varid";
            public string Execid = "Execid";
            public string Registerid = "Registerid";
            public string Vardate = "Vardate";
            public string Vareffect = "Vareffect";
            public string Varcontent = "Varcontent";
            public string Doctid = "Doctid";
            public string Doctdate = "Doctdate";
            public string Nurseid = "Nurseid";
            public string Nursedate = "Nursedate";
            public string Operid = "Operid";
            public string Operdate = "Operdate";
            public string Status = "Status";
            public string Vartype = "Vartype";
            public string Newcpid = "Newcpid";
        }
    }

    #endregion

    #region EntityCpExecPlanVardetail
    /// <summary>
    /// EntityCpExecPlanVardetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecplanvardetail")]
    public class EntityCpExecPlanVardetail : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Varid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Varid { get; set; }

        /// <summary>
        /// Varcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Varcontent { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Varid = "Varid";
            public string Varcontent = "Varcontent";
            public string Sortno = "Sortno";
        }
    }

    #endregion

    #region EntityCpExecOrderMatchup
    /// <summary>
    /// EntityCpExecOrderMatchup
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpOrdermatchup")]
    public class EntityCpExecOrderMatchup : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Orderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Orderid { get; set; }

        /// <summary>
        /// Order_Sn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "order_sn", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 4)]
        public System.Decimal Order_Sn { get; set; }

        /// <summary>
        /// Isherbal
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isherbal", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Isherbal { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Orderid = "Orderid";
            public string Order_Sn = "Order_Sn";
            public string Isherbal = "Isherbal";
        }
    }

    #endregion

    #region EntityCpFlowdiagram
    /// <summary>
    /// EntityCpFlowdiagram
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpFlowdiagram")]
    public class EntityCpFlowdiagram : BaseDataContract
    {
        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Cpcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Cpcode { get; set; }

        /// <summary>
        /// Cpname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Cpname { get; set; }

        /// <summary>
        /// Cptype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cptype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Cptype { get; set; }

        /// <summary>
        /// Cpdays
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpdays", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Cpdays { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Diagram
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "diagram", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Diagram { get; set; }

        /// <summary>
        /// Inprocess
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inprocess", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String InprocessVchr { get; set; }

        /// <summary>
        /// Inprocess
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inprocessblb", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Byte[] InprocessBlb { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "version", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Version { get; set; }

        /// <summary>
        /// Formid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? Formid { get; set; }

        /// <summary>
        /// Recorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorderid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Recorderid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// efid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "efid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal Efid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Cpid = "Cpid";
            public string Cpcode = "Cpcode";
            public string Cpname = "Cpname";
            public string Cptype = "Cptype";
            public string Cpdays = "Cpdays";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Diagram = "Diagram";
            public string InprocessVchr = "InprocessVchr";
            public string InprocessBlb = "InprocessBlb";
            public string Version = "Version";
            public string Formid = "Formid";
            public string Recorderid = "Recorderid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            public string Efid = "Efid";
            public string Cpform = "Cpform";

            public string CpTypeName = "CpTypeName";
            public string Pdf = "Pdf";
            public string FormName = "FormName";
            public string StatusName = "StatusName";
        }
        [DataMember]
        public string CpTypeName { get; set; }
        [DataMember]
        public string Pdf { get; set; }
        [DataMember]
        public string FormName { get; set; }
        [DataMember]
        public string StatusName { get; set; }
    }
    #endregion

    #region EntityCpDefDept
    /// <summary>
    /// EntityCpDefDept
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpDefdept")]
    public class EntityCpDefDept : BaseDataContract
    {
        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Cpid = "Cpid";
            public string Deptid = "Deptid";
            public string DeptName = "DeptName";
        }
        [DataMember]
        public string DeptName { get; set; }
    }
    #endregion

    #region EntityCpExecFlowdiagram
    /// <summary>
    /// EntityCpExecFlowdiagram
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecflowdiagram")]
    public class EntityCpExecFlowdiagram : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Diagram
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "diagram", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Diagram { get; set; }

        /// <summary>
        /// Cpform
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpformdata", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Cpformdata { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "efid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Efid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Diagram = "Diagram";
            public string Cpformdata = "Cpformdata";
            public string Efid = "Efid";
        }

        [DataMember]
        public string Cpformlayout { get; set; }
    }

    #endregion

    #region EntityCpExecFlowdiagramAdjust
    /// <summary>
    /// EntityCpExecFlowdiagramAdjust
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpExecflowdiagramadjust")]
    public class EntityCpExecFlowdiagramAdjust : BaseDataContract
    {
        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Nodedays
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodedays", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Nodedays { get; set; }

        /// <summary>
        /// Parentnode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentnode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Parentnode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Nodedays = "Nodedays";
            public string Parentnode = "Parentnode";
            public string Status = "Status";
        }
    }
    #endregion

    #region EntityEform
    /// <summary>
    /// EntityEform
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisEform")]
    public class EntityEform : BaseDataContract
    {
        /// <summary>
        /// Appfid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "efid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Efid { get; set; }

        /// <summary>
        /// Appfcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "efcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Efcode { get; set; }

        /// <summary>
        /// Appfname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "efname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Efname { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Panelsize
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "panelsize", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Panelsize { get; set; }

        /// <summary>
        /// Layout
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "layout", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Layout { get; set; }

        /// <summary>
        /// Recorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorderid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Recorderid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Printfilename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printfilename", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Printfilename { get; set; }

        /// <summary>
        /// Printfiledata
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printfiledata", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Byte[] Printfiledata { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Efid = "Efid";
            public string Efcode = "Efcode";
            public string Efname = "Efname";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Panelsize = "Panelsize";
            public string Layout = "Layout";
            public string Rcode = "Rcode";
            public string Recorderid = "Recorderid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            public string Printfilename = "Printfilename";
            public string Printfiledata = "Printfiledata";
            public string RecorderName = "RecorderName";
            public string StatusName = "StatusName";
        }
        [DataMember]
        public string RecorderName { get; set; }
        [DataMember]
        public string StatusName { get; set; }

        #region 长.宽
        /// <summary>
        /// 高
        /// </summary>
        [DataMember]
        public int PanelHeight
        {
            get
            {
                if (!string.IsNullOrEmpty(Panelsize))
                {
                    string[] size = Panelsize.Split('|');
                    if (size.Length == 2)
                    {
                        return Convert.ToInt32(size[0]);
                    }
                }
                return 0;
            }
            set { ;}
        }
        /// <summary>
        /// 宽
        /// </summary>
        [DataMember]
        public int PanelWidth
        {
            get
            {
                if (!string.IsNullOrEmpty(Panelsize))
                {
                    string[] size = Panelsize.Split('|');
                    if (size.Length == 2)
                    {
                        return Convert.ToInt32(size[1]);
                    }
                }
                return 0;
            }
            set { ;}
        }
        #endregion
    }
    #endregion

    #region EntityFormGuide
    /// <summary>
    /// EntityFormGuide
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrFormguide")]
    public class EntityFormGuide : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Formname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Formname { get; set; }

        /// <summary>
        /// Formtemplate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formtemplate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Formtemplate { get; set; }

        /// <summary>
        /// Formdesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formdesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Formdesc { get; set; }

        /// <summary>
        /// Printtemplate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printtemplate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Printtemplate { get; set; }

        /// <summary>
        /// Modifierid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifierid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Modifierid { get; set; }

        /// <summary>
        /// Modifytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifytime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime Modifytime { get; set; }

        /// <summary>
        /// Funcid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Funcid { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Formversion
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formversion", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 11)]
        public System.Decimal Formversion { get; set; }

        /// <summary>
        /// Printversion
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printversion", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? Printversion { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? Status { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal? Type { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Formname = "Formname";
            public string Formtemplate = "Formtemplate";
            public string Formdesc = "Formdesc";
            public string Printtemplate = "Printtemplate";
            public string Modifierid = "Modifierid";
            public string Modifytime = "Modifytime";
            public string Funcid = "Funcid";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Formversion = "Formversion";
            public string Printversion = "Printversion";
            public string Status = "Status";
            public string Type = "Type";
        }
    }

    #endregion

    #region EntityEAFOrderItem
    /// <summary>
    /// EntityEAFOrderItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisEapplyformorderitem")]
    public class EntityEAFOrderItem : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Appfid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "appfid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Appfid { get; set; }

        /// <summary>
        /// Ordercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordercode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Ordercode { get; set; }

        /// <summary>
        /// Ordername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordername", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Ordername { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Appfid = "Appfid";
            public string Ordercode = "Ordercode";
            public string Ordername = "Ordername";
            public string Spec = "Spec";
        }
    }
    #endregion

    #region EntityEfOrderItem
    /// <summary>
    /// EntityEfOrderItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisEformItem")]
    public class EntityEfOrderItem : BaseDataContract
    {
        /// <summary>
        /// Efid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "efid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Efid { get; set; }

        /// <summary>
        /// Fieldname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Fieldname { get; set; }

        /// <summary>
        /// Ordercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordercode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String OrderCode { get; set; }

        /// <summary>
        /// Ordername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordername", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String OrderName { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Efid = "Efid";
            public string Fieldname = "Fieldname";
            public string OrderCode = "OrderCode";
            public string OrderName = "OrderName";
            public string Nodename = "Nodename";
        }
    }
    #endregion
    
    #region Order

    #region EntityOrderTemplate
    /// <summary>
    /// EntityOrderTemplate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicOrdertemplate")]
    public class EntityOrderTemplate : BaseDataContract
    {
        /// <summary>
        /// Templateid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Templateid { get; set; }

        /// <summary>
        /// Templatecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templatecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Templatecode { get; set; }

        /// <summary>
        /// Templatename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templatename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Templatename { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Recordoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Recordoperid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Iscommon
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iscommon", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Iscommon { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "scope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Scope { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Templateid = "Templateid";
            public string Templatecode = "Templatecode";
            public string Templatename = "Templatename";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Recordoperid = "Recordoperid";
            public string Recorddate = "Recorddate";
            public string Iscommon = "Iscommon";
            public string Scope = "Scope";
            public string Status = "Status";
            public string IsNew = "IsNew";
        }

        [DataMember]
        public bool IsNew { get; set; }

        [DataMember]
        public List<EntityCodeDepartment> DeptData { get; set; }
    }

    #endregion

    #region EntityOrderTemplateDet
    /// <summary>
    /// EntityOrderTemplateDet
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicOrdertemplatedet")]
    public class EntityOrderTemplateDet : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Orderclassid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderclassid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Orderclassid { get; set; }

        /// <summary>
        /// Ordertypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordertypeid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Ordertypeid { get; set; }

        /// <summary>
        /// Ordertypename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordertypename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Ordertypename { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosagescale
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosagescale", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Dosagescale { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Dosageunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Dosageunitname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Days
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "days", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal? Days { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal? Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal? Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal? Total { get; set; }

        /// <summary>
        /// Packunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String Packunitid { get; set; }

        /// <summary>
        /// Packunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String Packunitname { get; set; }

        /// <summary>
        /// Packqty
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packqty", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Decimal? Packqty { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal Sortno { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentorderid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Parentorderid { get; set; }

        /// <summary>
        /// Skintestflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "skintestflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Decimal Skintestflag { get; set; }

        /// <summary>
        /// Otherpackflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "otherpackflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal? Otherpackflag { get; set; }

        /// <summary>
        /// Urgencyflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "urgencyflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal? Urgencyflag { get; set; }

        /// <summary>
        /// Drugflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drugflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Decimal? Drugflag { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Packsn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packsn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String Packsn { get; set; }

        /// <summary>
        /// Templateid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.Decimal Templateid { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "pharmacyno", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String Pharmacyno { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "caseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.Decimal? Caseid { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "ordersn", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.Decimal? Ordersn { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Orderclassid = "Orderclassid";
            public string Ordertypeid = "Ordertypeid";
            public string Ordertypename = "Ordertypename";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Dosage = "Dosage";
            public string Dosagescale = "Dosagescale";
            public string Dosageunitid = "Dosageunitid";
            public string Dosageunitname = "Dosageunitname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Days = "Days";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Packunitid = "Packunitid";
            public string Packunitname = "Packunitname";
            public string Packqty = "Packqty";
            public string Sortno = "Sortno";
            public string Parentflag = "Parentflag";
            public string Parentorderid = "Parentorderid";
            public string Skintestflag = "Skintestflag";
            public string Otherpackflag = "Otherpackflag";
            public string Urgencyflag = "Urgencyflag";
            public string Drugflag = "Drugflag";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Entrustinfo = "Entrustinfo";
            public string Packsn = "Packsn";
            public string Templateid = "Templateid";
            public string Pharmacyno = "Pharmacyno";
            public string Caseid = "Caseid";
            public string Ordersn = "Ordersn";

            public string Checked = "Checked";
            public string Orderclassname = "Orderclassname";
            public string Skintestflagname = "Skintestflagname";
            public string Otherpackflagname = "Otherpackflagname";
            public string Isdrug = "Isdrug";
            public string Urgencyflagname = "Urgencyflagname";
        }

        [DataMember]
        public int Checked { get; set; }
        [DataMember]
        public string Orderclassname { get; set; }
        [DataMember]
        public string Skintestflagname { get; set; }
        [DataMember]
        public string Otherpackflagname { get; set; }
        [DataMember]
        public System.Decimal? Isdrug { get; set; }
        [DataMember]
        public string Urgencyflagname { get; set; }
    }
    #endregion

    #region EntityOrderTemplateDept
    /// <summary>
    /// EntityOrderTemplateDept
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defOrdertemplatedept")]
    public class EntityOrderTemplateDept : BaseDataContract
    {
        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Templateid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Templateid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Deptid = "Deptid";
            public string Templateid = "Templateid";
        }
    }
    #endregion

    #region EntityDicHerbalRecipe
    /// <summary>
    /// EntityDicHerbalRecipe
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicHerbalrecipe")]
    public class EntityDicHerbalRecipe : BaseDataContract
    {
        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Recipecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Recipecode { get; set; }

        /// <summary>
        /// Recipename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Recipename { get; set; }

        /// <summary>
        /// Recipeattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? Recipeattributeid { get; set; }

        /// <summary>
        /// Recipetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Recipetype { get; set; }

        /// <summary>
        /// Typeida
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeida", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Typeida { get; set; }

        /// <summary>
        /// Typeidb
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidb", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Typeidb { get; set; }

        /// <summary>
        /// Typeidc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidc", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Typeidc { get; set; }

        /// <summary>
        /// Begindatetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindatetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Begindatetype { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime Begindate { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Decoction { get; set; }

        /// <summary>
        /// Decoctionname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoctionname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Decoctionname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Dosageunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Dosageunitname { get; set; }

        /// <summary>
        /// Packs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packs", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal Packs { get; set; }

        /// <summary>
        /// Outflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal Outflag { get; set; }

        /// <summary>
        /// Helpflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "helpflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal Helpflag { get; set; }

        /// <summary>
        /// Recipemoney
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipemoney", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? Recipemoney { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Recordoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String Recordoperid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "scope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Decimal? Scope { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipeid = "Recipeid";
            public string Recipecode = "Recipecode";
            public string Recipename = "Recipename";
            public string Recipeattributeid = "Recipeattributeid";
            public string Recipetype = "Recipetype";
            public string Typeida = "Typeida";
            public string Typeidb = "Typeidb";
            public string Typeidc = "Typeidc";
            public string Begindatetype = "Begindatetype";
            public string Begindate = "Begindate";
            public string Decoction = "Decoction";
            public string Decoctionname = "Decoctionname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Dosage = "Dosage";
            public string Dosageunitid = "Dosageunitid";
            public string Dosageunitname = "Dosageunitname";
            public string Packs = "Packs";
            public string Outflag = "Outflag";
            public string Helpflag = "Helpflag";
            public string Recipemoney = "Recipemoney";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Entrustinfo = "Entrustinfo";
            public string Recordoperid = "Recordoperid";
            public string Recorddate = "Recorddate";
            public string Scope = "Scope";
            public string Status = "Status";
            public string IsNew = "IsNew";
        }
        [DataMember]
        public System.Boolean IsNew { get; set; }

        [DataMember]
        public List<EntityCodeDepartment> DeptData { get; set; }
    }
    #endregion

    #region EntityDicHerbalRecipeDet
    /// <summary>
    /// EntityDicHerbalRecipeDet
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicHerbalrecipedet")]
    public class EntityDicHerbalRecipeDet : BaseDataContract
    {
        /// <summary>
        /// Recipesubid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipesubid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Recipesubid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Orderprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderprtname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderprtname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal Total { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Parentid { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "comment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Comment { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipesubid = "Recipesubid";
            public string Recipeid = "Recipeid";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Orderprtname = "Orderprtname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Parentflag = "Parentflag";
            public string Parentid = "Parentid";
            public string Sortno = "Sortno";
            public string Comment = "Comment";
        }
    }

    #endregion

    #region EntityDefHerbalRecipeDept
    /// <summary>
    /// EntityDefHerbalRecipeDept
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defHerbalrecipedept")]
    public class EntityDefHerbalRecipeDept : BaseDataContract
    {
        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipeid = "Recipeid";
            public string Deptid = "Deptid";
        }
    }

    #endregion

    #region EntityEapplyformOrderitem
    /// <summary>
    /// EntityEapplyformOrderitem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisEapplyformorderitem")]
    public class EntityEapplyformOrderitem : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Appfid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "appfid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Appfid { get; set; }

        /// <summary>
        /// Ordercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordercode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Ordercode { get; set; }

        /// <summary>
        /// Ordername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordername", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Ordername { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Appfid = "Appfid";
            public string Ordercode = "Ordercode";
            public string Ordername = "Ordername";
            public string Spec = "Spec";
        }
    }

    #endregion

    #region EntityOutMedOrder
    /// <summary>
    /// EntityOutMedOrder
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisOutmedorder")]
    public class EntityOutMedOrder : BaseDataContract
    {
        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientid", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Patientid { get; set; }

        /// <summary>
        /// Iptimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iptimes", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Iptimes { get; set; }

        /// <summary>
        /// Ordersn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordersn", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Ordersn { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Patientid = "Patientid";
            public string Iptimes = "Iptimes";
            public string Ordersn = "Ordersn";
        }

    }

    #endregion

    #region EntityHRecipe
    /// <summary>
    /// EntityHRecipe
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisHerbalrecipe")]
    public class EntityHRecipe : BaseDataContract
    {
        /// <summary>
        /// Orderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal Orderid { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Registerid { get; set; }

        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Patientid { get; set; }

        /// <summary>
        /// Identityid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "identityid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Identityid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Recipecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Recipecode { get; set; }

        /// <summary>
        /// Recipename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Recipename { get; set; }

        /// <summary>
        /// Recipeattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Recipeattributeid { get; set; }

        /// <summary>
        /// Recipetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal Recipetype { get; set; }

        /// <summary>
        /// Typeida
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeida", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal Typeida { get; set; }

        /// <summary>
        /// Typeidb
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidb", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal Typeidb { get; set; }

        /// <summary>
        /// Typeidc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidc", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Typeidc { get; set; }

        /// <summary>
        /// Begindatetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindatetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? Begindatetype { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime Begindate { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Decoction { get; set; }

        /// <summary>
        /// Decoctionname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoctionname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Decoctionname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Packs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packs", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal Packs { get; set; }

        /// <summary>
        /// Outflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Decimal Outflag { get; set; }

        /// <summary>
        /// Helpflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "helpflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Decimal Helpflag { get; set; }

        /// <summary>
        /// Recipemoney
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipemoney", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Decimal? Recipemoney { get; set; }

        /// <summary>
        /// Makedoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedoctid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String Makedoctid { get; set; }

        /// <summary>
        /// Makedeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Makedeptid { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Recordoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String Recordoperid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Confirmoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Confirmoperid { get; set; }

        /// <summary>
        /// Confirmdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.DateTime? Confirmdate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Orderid = "Orderid";
            public string Registerid = "Registerid";
            public string Patientid = "Patientid";
            public string Identityid = "Identityid";
            public string Recipeid = "Recipeid";
            public string Recipecode = "Recipecode";
            public string Recipename = "Recipename";
            public string Recipeattributeid = "Recipeattributeid";
            public string Recipetype = "Recipetype";
            public string Typeida = "Typeida";
            public string Typeidb = "Typeidb";
            public string Typeidc = "Typeidc";
            public string Begindatetype = "Begindatetype";
            public string Begindate = "Begindate";
            public string Decoction = "Decoction";
            public string Decoctionname = "Decoctionname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Dosage = "Dosage";
            public string Dosageunitid = "Dosageunitid";
            public string Packs = "Packs";
            public string Outflag = "Outflag";
            public string Helpflag = "Helpflag";
            public string Recipemoney = "Recipemoney";
            public string Makedoctid = "Makedoctid";
            public string Makedeptid = "Makedeptid";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Entrustinfo = "Entrustinfo";
            public string Recordoperid = "Recordoperid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            public string Confirmoperid = "Confirmoperid";
            public string Confirmdate = "Confirmdate";
            public string IsNew = "IsNew";
        }
        [DataMember]
        public bool IsNew { get; set; }
    }

    #endregion

    #region EntityHRecipeDetail
    /// <summary>
    /// EntityHRecipeDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisHerbalrecipedetail")]
    public class EntityHRecipeDetail : BaseDataContract
    {
        /// <summary>
        /// Recipesubid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipesubid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Recipesubid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Orderprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderprtname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderprtname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal Total { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Parentid { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "comment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Comment { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipesubid = "Recipesubid";
            public string Recipeid = "Recipeid";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Orderprtname = "Orderprtname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Parentflag = "Parentflag";
            public string Parentid = "Parentid";
            public string Sortno = "Sortno";
            public string Comment = "Comment";
        }
    }

    #endregion

    #region EntityLisDept
    /// <summary>
    /// EntityLisDept
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "itfEhrlisdeptdef")]
    public class EntityLisDept : BaseDataContract
    {
        /// <summary>
        /// Ehrdeptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ehrdeptcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String Ehrdeptcode { get; set; }

        /// <summary>
        /// Ehrdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ehrdeptname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Ehrdeptname { get; set; }

        /// <summary>
        /// Lisdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lisdeptname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Lisdeptname { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Ehrdeptcode = "Ehrdeptcode";
            public string Ehrdeptname = "Ehrdeptname";
            public string Lisdeptname = "Lisdeptname";
        }
    }

    #endregion

    #region EntityIpEBill
    /// <summary>
    /// EntityIpEBill
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpIpebill")]
    public class EntityIpEBill : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Classid { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Orderxml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OrderXml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderxml { get; set; }

        /// <summary>
        /// Lis1xml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "Lis1Xml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Lis1xml { get; set; }

        /// <summary>
        /// Lis2xml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "Lis2Xml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Lis2xml { get; set; }

        /// <summary>
        /// Ris1xml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "Ris1Xml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Ris1xml { get; set; }

        /// <summary>
        /// Ris2xml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "Ris2Xml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Ris2xml { get; set; }

        /// <summary>
        /// Casexml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CaseXml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Casexml { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Classid = "Classid";
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Orderxml = "Orderxml";
            public string Lis1xml = "Lis1xml";
            public string Lis2xml = "Lis2xml";
            public string Ris1xml = "Ris1xml";
            public string Ris2xml = "Ris2xml";
            public string Casexml = "Casexml";
            public string OrderClassID = "OrderClassID";
            public string MaxGroupNo = "MaxGroupNo";
            public string MaxSortNo = "MaxSortNo";
        }
        [DataMember]
        public int OrderClassID { get; set; }

        [DataMember]
        public int MaxGroupNo { get; set; }

        [DataMember]
        public int MaxSortNo { get; set; }

    }

    #endregion

    #region EntityIpEBillPage
    /// <summary>
    /// EntityIpEBillPage
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpIpebillpage")]
    public class EntityIpEBillPage : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Classid { get; set; }

        /// <summary>
        /// Execid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Execid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Caseid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "caseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Caseid { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "page", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Byte[] Page { get; set; }

        /// <summary>
        /// Filepath
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "filepath", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Filepath { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Classid = "Classid";
            public string Execid = "Execid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Caseid = "Caseid";
            public string Page = "Page";
            public string Filepath = "Filepath";
        }
    }

    #endregion

    #region Order
    /// <summary>
    /// yz_order_detail_in
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "yz_order_detail_in")]
    public class PoYzOrderDetailIn : BaseDataContract, IComparable
    {
        /// <summary>
        /// Order_Sn
        /// </summary>
        [EntityAttribute(FieldName = "order_sn", DbType = DbType.Double, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Double Order_Sn { get; set; }

        /// <summary>
        /// Patient_Id
        /// </summary>
        [EntityAttribute(FieldName = "patient_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Patient_Id { get; set; }

        /// <summary>
        /// Admiss_Times
        /// </summary>
        [EntityAttribute(FieldName = "admiss_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 Admiss_Times { get; set; }

        /// <summary>
        /// Dept_Sn
        /// </summary>
        [EntityAttribute(FieldName = "dept_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Dept_Sn { get; set; }

        /// <summary>
        /// Ward_Sn
        /// </summary>
        [EntityAttribute(FieldName = "ward_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Ward_Sn { get; set; }

        /// <summary>
        /// Order_Code
        /// </summary>
        [EntityAttribute(FieldName = "order_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Order_Code { get; set; }

        /// <summary>
        /// Pack_Sn
        /// </summary>
        [EntityAttribute(FieldName = "pack_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Pack_Sn { get; set; }

        /// <summary>
        /// Order_Name
        /// </summary>
        [EntityAttribute(FieldName = "order_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Order_Name { get; set; }

        /// <summary>
        /// Order_Time
        /// </summary>
        [EntityAttribute(FieldName = "order_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime? Order_Time { get; set; }

        /// <summary>
        /// Enter_Time
        /// </summary>
        [EntityAttribute(FieldName = "enter_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? Enter_Time { get; set; }

        /// <summary>
        /// Confirm_Time
        /// </summary>
        [EntityAttribute(FieldName = "confirm_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime? Confirm_Time { get; set; }

        /// <summary>
        /// Execute_Time
        /// </summary>
        [EntityAttribute(FieldName = "execute_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? Execute_Time { get; set; }

        /// <summary>
        /// Start_Time
        /// </summary>
        [EntityAttribute(FieldName = "start_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.DateTime Start_Time { get; set; }

        /// <summary>
        /// Enter_Stop_Time
        /// </summary>
        [EntityAttribute(FieldName = "enter_stop_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime? Enter_Stop_Time { get; set; }

        /// <summary>
        /// Complete_Stop_Time
        /// </summary>
        [EntityAttribute(FieldName = "complete_stop_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.DateTime? Complete_Stop_Time { get; set; }

        /// <summary>
        /// Generator_Time
        /// </summary>
        [EntityAttribute(FieldName = "generator_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime? Generator_Time { get; set; }

        /// <summary>
        /// Order_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "order_doctor", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Order_Doctor { get; set; }

        /// <summary>
        /// Stop_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "stop_doctor", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Stop_Doctor { get; set; }

        /// <summary>
        /// Stop_Confirm_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "stop_confirm_doctor", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Stop_Confirm_Doctor { get; set; }

        /// <summary>
        /// Enter_Opera
        /// </summary>
        [EntityAttribute(FieldName = "enter_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Enter_Opera { get; set; }

        /// <summary>
        /// Edit_Opera
        /// </summary>
        [EntityAttribute(FieldName = "edit_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String Edit_Opera { get; set; }

        /// <summary>
        /// Confirm_Opera
        /// </summary>
        [EntityAttribute(FieldName = "confirm_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Confirm_Opera { get; set; }

        /// <summary>
        /// Stop_Opera
        /// </summary>
        [EntityAttribute(FieldName = "stop_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String Stop_Opera { get; set; }

        /// <summary>
        /// Stop_Confirm_Opera
        /// </summary>
        [EntityAttribute(FieldName = "stop_confirm_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String Stop_Confirm_Opera { get; set; }

        /// <summary>
        /// Frequ_Code
        /// </summary>
        [EntityAttribute(FieldName = "frequ_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Frequ_Code { get; set; }

        /// <summary>
        /// Order_Type
        /// </summary>
        [EntityAttribute(FieldName = "order_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String Order_Type { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [EntityAttribute(FieldName = "status", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String Status { get; set; }

        /// <summary>
        /// Supply_Code
        /// </summary>
        [EntityAttribute(FieldName = "supply_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Supply_Code { get; set; }

        /// <summary>
        /// Drug_Specification
        /// </summary>
        [EntityAttribute(FieldName = "drug_specification", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Drug_Specification { get; set; }

        /// <summary>
        /// Doseage
        /// </summary>
        [EntityAttribute(FieldName = "doseage", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Double? Doseage { get; set; }

        /// <summary>
        /// Doseage_Unit
        /// </summary>
        [EntityAttribute(FieldName = "doseage_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String Doseage_Unit { get; set; }

        /// <summary>
        /// Charge_Amount
        /// </summary>
        [EntityAttribute(FieldName = "charge_amount", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Double? Charge_Amount { get; set; }

        /// <summary>
        /// Drug_Occ
        /// </summary>
        [EntityAttribute(FieldName = "drug_occ", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Double? Drug_Occ { get; set; }

        /// <summary>
        /// Mini_Unit
        /// </summary>
        [EntityAttribute(FieldName = "mini_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String Mini_Unit { get; set; }

        /// <summary>
        /// Print_Order_Change
        /// </summary>
        [EntityAttribute(FieldName = "print_order_change", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Print_Order_Change { get; set; }

        /// <summary>
        /// P_Order_Sn
        /// </summary>
        [EntityAttribute(FieldName = "p_order_sn", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.Double? P_Order_Sn { get; set; }

        /// <summary>
        /// Print_Order
        /// </summary>
        [EntityAttribute(FieldName = "print_order", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String Print_Order { get; set; }

        /// <summary>
        /// Exclusive_Type
        /// </summary>
        [EntityAttribute(FieldName = "exclusive_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String Exclusive_Type { get; set; }

        /// <summary>
        /// Exclu_Back_Time
        /// </summary>
        [EntityAttribute(FieldName = "exclu_back_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.DateTime? Exclu_Back_Time { get; set; }

        /// <summary>
        /// Exclu_Order_Sn
        /// </summary>
        [EntityAttribute(FieldName = "exclu_order_sn", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.Double? Exclu_Order_Sn { get; set; }

        /// <summary>
        /// Pay_Self
        /// </summary>
        [EntityAttribute(FieldName = "pay_self", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String Pay_Self { get; set; }

        /// <summary>
        /// Infant_Flag
        /// </summary>
        [EntityAttribute(FieldName = "infant_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Infant_Flag { get; set; }

        /// <summary>
        /// Emergency_Flag
        /// </summary>
        [EntityAttribute(FieldName = "emergency_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.String Emergency_Flag { get; set; }

        /// <summary>
        /// Ope_Flag
        /// </summary>
        [EntityAttribute(FieldName = "ope_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.String Ope_Flag { get; set; }

        /// <summary>
        /// Self_Buy
        /// </summary>
        [EntityAttribute(FieldName = "self_buy", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.String Self_Buy { get; set; }

        /// <summary>
        /// Fit_Flag
        /// </summary>
        [EntityAttribute(FieldName = "fit_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.String Fit_Flag { get; set; }

        /// <summary>
        /// Instruction
        /// </summary>
        [EntityAttribute(FieldName = "instruction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 47)]
        public System.String Instruction { get; set; }

        /// <summary>
        /// Discription
        /// </summary>
        [EntityAttribute(FieldName = "discription", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 48)]
        public System.String Discription { get; set; }

        /// <summary>
        /// Deleted_Flag
        /// </summary>
        [EntityAttribute(FieldName = "deleted_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 49)]
        public System.String Deleted_Flag { get; set; }

        /// <summary>
        /// Back_Flag
        /// </summary>
        [EntityAttribute(FieldName = "back_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 50)]
        public System.String Back_Flag { get; set; }

        /// <summary>
        /// Alter_Print_Order
        /// </summary>
        [EntityAttribute(FieldName = "alter_print_order", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 51)]
        public System.Double? Alter_Print_Order { get; set; }

        /// <summary>
        /// Exec_Unit
        /// </summary>
        [EntityAttribute(FieldName = "exec_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 52)]
        public System.String Exec_Unit { get; set; }

        /// <summary>
        /// Long_Once_Flag
        /// </summary>
        [EntityAttribute(FieldName = "long_once_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 53)]
        public System.String Long_Once_Flag { get; set; }

        /// <summary>
        /// Yp_Group_No
        /// </summary>
        [EntityAttribute(FieldName = "yp_group_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 54)]
        public System.String Yp_Group_No { get; set; }

        /// <summary>
        /// Sys_Dept_Group
        /// </summary>
        [EntityAttribute(FieldName = "sys_dept_group", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 55)]
        public System.String Sys_Dept_Group { get; set; }

        /// <summary>
        /// Edit_Time
        /// </summary>
        [EntityAttribute(FieldName = "edit_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 56)]
        public System.DateTime? Edit_Time { get; set; }

        /// <summary>
        /// Execute_Opera
        /// </summary>
        [EntityAttribute(FieldName = "execute_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 57)]
        public System.String Execute_Opera { get; set; }

        /// <summary>
        /// Skin_Test
        /// </summary>
        [EntityAttribute(FieldName = "skin_test", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 58)]
        public System.String Skin_Test { get; set; }

        /// <summary>
        /// Order_Long_Id
        /// </summary>
        [EntityAttribute(FieldName = "order_long_id", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 59)]
        public System.Int32? Order_Long_Id { get; set; }

        /// <summary>
        /// Supply_Code_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "supply_code_doctor", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 60)]
        public System.String Supply_Code_Doctor { get; set; }

        /// <summary>
        /// Cancel_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "cancel_doctor", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 61)]
        public System.String Cancel_Doctor { get; set; }

        /// <summary>
        /// Cancel_Time
        /// </summary>
        [EntityAttribute(FieldName = "cancel_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 62)]
        public System.DateTime? Cancel_Time { get; set; }

        /// <summary>
        /// Stop_Time_Doctor
        /// </summary>
        [EntityAttribute(FieldName = "stop_time_doctor", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 63)]
        public System.DateTime? Stop_Time_Doctor { get; set; }

        /// <summary>
        /// Persist_Days
        /// </summary>
        [EntityAttribute(FieldName = "persist_days", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 64)]
        public System.Int32? Persist_Days { get; set; }

        /// <summary>
        /// First_Times
        /// </summary>
        [EntityAttribute(FieldName = "first_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 65)]
        public System.Int32? First_Times { get; set; }

        /// <summary>
        /// Last_Times
        /// </summary>
        [EntityAttribute(FieldName = "last_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 66)]
        public System.Int32? Last_Times { get; set; }

        /// <summary>
        /// Global_Pid
        /// </summary>
        [EntityAttribute(FieldName = "global_pid", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 67)]
        public System.Int32? Global_Pid { get; set; }

        /// <summary>
        /// Enter_Unit
        /// </summary>
        [EntityAttribute(FieldName = "enter_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 68)]
        public System.String Enter_Unit { get; set; }

        /// <summary>
        /// Frequ_Times
        /// </summary>
        [EntityAttribute(FieldName = "frequ_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 69)]
        public System.Int32? Frequ_Times { get; set; }

        /// <summary>
        /// Order_Flag
        /// </summary>
        [EntityAttribute(FieldName = "order_flag", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 70)]
        public System.Int32 Order_Flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Order_Sn = "Order_Sn";
            public string Patient_Id = "Patient_Id";
            public string Admiss_Times = "Admiss_Times";
            public string Dept_Sn = "Dept_Sn";
            public string Ward_Sn = "Ward_Sn";
            public string Order_Code = "Order_Code";
            public string Pack_Sn = "Pack_Sn";
            public string Order_Name = "Order_Name";
            public string Order_Time = "Order_Time";
            public string Enter_Time = "Enter_Time";
            public string Confirm_Time = "Confirm_Time";
            public string Execute_Time = "Execute_Time";
            public string Start_Time = "Start_Time";
            public string Enter_Stop_Time = "Enter_Stop_Time";
            public string Complete_Stop_Time = "Complete_Stop_Time";
            public string Generator_Time = "Generator_Time";
            public string Order_Doctor = "Order_Doctor";
            public string Stop_Doctor = "Stop_Doctor";
            public string Stop_Confirm_Doctor = "Stop_Confirm_Doctor";
            public string Enter_Opera = "Enter_Opera";
            public string Edit_Opera = "Edit_Opera";
            public string Confirm_Opera = "Confirm_Opera";
            public string Stop_Opera = "Stop_Opera";
            public string Stop_Confirm_Opera = "Stop_Confirm_Opera";
            public string Frequ_Code = "Frequ_Code";
            public string Order_Type = "Order_Type";
            public string Status = "Status";
            public string Supply_Code = "Supply_Code";
            public string Drug_Specification = "Drug_Specification";
            public string Doseage = "Doseage";
            public string Doseage_Unit = "Doseage_Unit";
            public string Charge_Amount = "Charge_Amount";
            public string Drug_Occ = "Drug_Occ";
            public string Mini_Unit = "Mini_Unit";
            public string Print_Order_Change = "Print_Order_Change";
            public string P_Order_Sn = "P_Order_Sn";
            public string Print_Order = "Print_Order";
            public string Exclusive_Type = "Exclusive_Type";
            public string Exclu_Back_Time = "Exclu_Back_Time";
            public string Exclu_Order_Sn = "Exclu_Order_Sn";
            public string Pay_Self = "Pay_Self";
            public string Infant_Flag = "Infant_Flag";
            public string Emergency_Flag = "Emergency_Flag";
            public string Ope_Flag = "Ope_Flag";
            public string Self_Buy = "Self_Buy";
            public string Fit_Flag = "Fit_Flag";
            public string Instruction = "Instruction";
            public string Discription = "Discription";
            public string Deleted_Flag = "Deleted_Flag";
            public string Back_Flag = "Back_Flag";
            public string Alter_Print_Order = "Alter_Print_Order";
            public string Exec_Unit = "Exec_Unit";
            public string Long_Once_Flag = "Long_Once_Flag";
            public string Yp_Group_No = "Yp_Group_No";
            public string Sys_Dept_Group = "Sys_Dept_Group";
            public string Edit_Time = "Edit_Time";
            public string Execute_Opera = "Execute_Opera";
            public string Skin_Test = "Skin_Test";
            public string Order_Long_Id = "Order_Long_Id";
            public string Supply_Code_Doctor = "Supply_Code_Doctor";
            public string Cancel_Doctor = "Cancel_Doctor";
            public string Cancel_Time = "Cancel_Time";
            public string Stop_Time_Doctor = "Stop_Time_Doctor";
            public string Persist_Days = "Persist_Days";
            public string First_Times = "First_Times";
            public string Last_Times = "Last_Times";
            public string Global_Pid = "Global_Pid";
            public string Enter_Unit = "Enter_Unit";
            public string Frequ_Times = "Frequ_Times";
            public string Order_Flag = "Order_Flag";
        }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is PoYzOrderDetailIn)
            {
                return this.Order_Long_Id.Value.CompareTo(((PoYzOrderDetailIn)obj).Order_Long_Id.Value);
            }
            return 0;
        }
    }

    /// <summary>
    /// yz_order_first
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "yz_order_first")]
    public class PoYzOrderFirst : BaseDataContract
    {
        /// <summary>
        /// Order_Sn
        /// </summary>
        [EntityAttribute(FieldName = "order_sn", DbType = DbType.Double, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Double Order_Sn { get; set; }

        /// <summary>
        /// Applye
        /// </summary>
        [EntityAttribute(FieldName = "apply_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 2)] //IsPK = false,
        public System.DateTime Apply_Date { get; set; }

        /// <summary>
        /// Patient_Id
        /// </summary>
        [EntityAttribute(FieldName = "patient_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Patient_Id { get; set; }

        /// <summary>
        /// Admiss_Times
        /// </summary>
        [EntityAttribute(FieldName = "admiss_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 Admiss_Times { get; set; }

        /// <summary>
        /// Doseage
        /// </summary>
        [EntityAttribute(FieldName = "doseage", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Double? Doseage { get; set; }

        /// <summary>
        /// Doseage_Unit
        /// </summary>
        [EntityAttribute(FieldName = "doseage_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Doseage_Unit { get; set; }

        /// <summary>
        /// Charge_Amount
        /// </summary>
        [EntityAttribute(FieldName = "charge_amount", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Double? Charge_Amount { get; set; }

        /// <summary>
        /// Drug_Occ
        /// </summary>
        [EntityAttribute(FieldName = "drug_occ", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Double? Drug_Occ { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Order_Sn = "Order_Sn";
            public string Applye = "Applye";
            public string Patient_Id = "Patient_Id";
            public string Admiss_Times = "Admiss_Times";
            public string Doseage = "Doseage";
            public string Doseage_Unit = "Doseage_Unit";
            public string Charge_Amount = "Charge_Amount";
            public string Drug_Occ = "Drug_Occ";
        }
    }

    /// <summary>
    /// EntityDefCpOrder
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defCporder")]
    public class EntityDefCpOrder : BaseDataContract
    {
        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientid", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Patientid { get; set; }

        /// <summary>
        /// Iptimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "iptimes", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Iptimes { get; set; }

        /// <summary>
        /// Ordersn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordersn", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Ordersn { get; set; }

        /// <summary>
        /// Ordersn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flag", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 4)]
        public System.Decimal Flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Patientid = "Patientid";
            public string Iptimes = "Iptimes";
            public string Ordersn = "Ordersn";
            public string Flag = "Flag";
        }
    }

    #region PoYzOrderDetailCharge
    /// <summary>
    /// PoYzOrderDetailCharge
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "Yz_Order_Detail_Charge")]
    public class PoYzOrderDetailCharge : BaseDataContract
    {
        /// <summary>
        /// Globalpid
        /// </summary>
        [EntityAttribute(FieldName = "GlobalPID", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Int32 Globalpid { get; set; }

        /// <summary>
        /// Ordersn
        /// </summary>
        [EntityAttribute(FieldName = "OrderSN", DbType = DbType.Double, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Double Ordersn { get; set; }

        /// <summary>
        /// Chargecode
        /// </summary>
        [EntityAttribute(FieldName = "ChargeCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Chargecode { get; set; }

        /// <summary>
        /// Packsn
        /// </summary>
        [EntityAttribute(FieldName = "PackSN", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 4)]
        public System.String Packsn { get; set; }

        /// <summary>
        /// Chargeamount
        /// </summary>
        [EntityAttribute(FieldName = "ChargeAmount", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Double Chargeamount { get; set; }

        /// <summary>
        /// Chargeprice
        /// </summary>
        [EntityAttribute(FieldName = "ChargePrice", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? Chargeprice { get; set; }

        /// <summary>
        /// Execunit
        /// </summary>
        [EntityAttribute(FieldName = "ExecUnit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Execunit { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        [EntityAttribute(FieldName = "Flag", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 8)]
        public System.Int32 Flag { get; set; }

        /// <summary>
        /// Fixed
        /// </summary>
        [EntityAttribute(FieldName = "Fixed", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 Fixed { get; set; }

        /// <summary>
        /// Deleteflag
        /// </summary>
        [EntityAttribute(FieldName = "DeleteFlag", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 Deleteflag { get; set; }

        /// <summary>
        /// Editinfo
        /// </summary>
        [EntityAttribute(FieldName = "EditInfo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 11)]
        public System.String Editinfo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Globalpid = "Globalpid";
            public string Ordersn = "Ordersn";
            public string Chargecode = "Chargecode";
            public string Packsn = "Packsn";
            public string Chargeamount = "Chargeamount";
            public string Chargeprice = "Chargeprice";
            public string Execunit = "Execunit";
            public string Flag = "Flag";
            public string Fixed = "Fixed";
            public string Deleteflag = "Deleteflag";
            public string Editinfo = "Editinfo";
        }
    }
    #endregion

    #endregion

    #region PoApp
    /// <summary>
    /// mzcpr_clinic_result
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "mzcpr_clinic_result")]
    public class PoApp : BaseDataContract
    {
        /// <summary>
        /// Exec_Name
        /// </summary>
        [EntityAttribute(FieldName = "exec_name", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Exec_Name { get; set; }

        /// <summary>
        /// Subsys_Code
        /// </summary>
        [EntityAttribute(FieldName = "subsys_code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Subsys_Code { get; set; }

        /// <summary>
        /// Computername
        /// </summary>
        [EntityAttribute(FieldName = "computername", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Computername { get; set; }

        /// <summary>
        /// Exec_Path
        /// </summary>
        [EntityAttribute(FieldName = "exec_path", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Exec_Path { get; set; }

        /// <summary>
        /// Appserver
        /// </summary>
        [EntityAttribute(FieldName = "appserver", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Appserver { get; set; }

        /// <summary>
        /// Appname
        /// </summary>
        [EntityAttribute(FieldName = "appname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Appname { get; set; }

        /// <summary>
        /// Disp_Name
        /// </summary>
        [EntityAttribute(FieldName = "disp_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Disp_Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [EntityAttribute(FieldName = "type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Type { get; set; }

        /// <summary>
        /// Class_Flag
        /// </summary>
        [EntityAttribute(FieldName = "class_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Class_Flag { get; set; }

        /// <summary>
        /// Sort_Sn
        /// </summary>
        [EntityAttribute(FieldName = "sort_sn", DbType = DbType.Int16, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int16? Sort_Sn { get; set; }

        /// <summary>
        /// Deleted_Flag
        /// </summary>
        [EntityAttribute(FieldName = "deleted_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Deleted_Flag { get; set; }

        /// <summary>
        /// Param1
        /// </summary>
        [EntityAttribute(FieldName = "param1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Param1 { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [EntityAttribute(FieldName = "code", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 13)]
        public System.Int32 Code { get; set; }

        /// <summary>
        /// Param_Mode
        /// </summary>
        [EntityAttribute(FieldName = "param_mode", DbType = DbType.Byte, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Byte? Param_Mode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Exec_Name = "Exec_Name";
            public string Subsys_Code = "Subsys_Code";
            public string Computername = "Computername";
            public string Exec_Path = "Exec_Path";
            public string Appserver = "Appserver";
            public string Appname = "Appname";
            public string Disp_Name = "Disp_Name";
            public string Type = "Type";
            public string Class_Flag = "Class_Flag";
            public string Sort_Sn = "Sort_Sn";
            public string Deleted_Flag = "Deleted_Flag";
            public string Param1 = "Param1";
            public string Code = "Code";
            public string Param_Mode = "Param_Mode";
        }
    }

    #endregion

    #region PoYzYpInf
    /// <summary>
    /// yz_yp_inf
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "yz_yp_inf")]
    public class PoYzYpInf : BaseDataContract
    {
        /// <summary>
        /// Dept_Sn
        /// </summary>
        [EntityAttribute(FieldName = "dept_sn", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Dept_Sn { get; set; }

        /// <summary>
        /// Ward_Sn
        /// </summary>
        [EntityAttribute(FieldName = "ward_sn", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Ward_Sn { get; set; }

        /// <summary>
        /// Submit_Time
        /// </summary>
        [EntityAttribute(FieldName = "submit_time", DbType = DbType.DateTime, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.DateTime Submit_Time { get; set; }

        /// <summary>
        /// Page_Type
        /// </summary>
        [EntityAttribute(FieldName = "page_type", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 4)]
        public System.Int32 Page_Type { get; set; }

        /// <summary>
        /// Page_No
        /// </summary>
        [EntityAttribute(FieldName = "page_no", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.Int32 Page_No { get; set; }

        /// <summary>
        /// Confirm_Flag
        /// </summary>
        [EntityAttribute(FieldName = "confirm_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Confirm_Flag { get; set; }

        /// <summary>
        /// Confirm_Operator
        /// </summary>
        [EntityAttribute(FieldName = "confirm_operator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Confirm_Operator { get; set; }

        /// <summary>
        /// Group_No
        /// </summary>
        [EntityAttribute(FieldName = "group_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Group_No { get; set; }

        /// <summary>
        /// Confirm_Time
        /// </summary>
        [EntityAttribute(FieldName = "confirm_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime? Confirm_Time { get; set; }

        /// <summary>
        /// Print_Time
        /// </summary>
        [EntityAttribute(FieldName = "print_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? Print_Time { get; set; }

        /// <summary>
        /// Print_Flag
        /// </summary>
        [EntityAttribute(FieldName = "print_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Print_Flag { get; set; }

        /// <summary>
        /// Checke
        /// </summary>
        [EntityAttribute(FieldName = "checke", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? Checke { get; set; }

        /// <summary>
        /// Check_Operator
        /// </summary>
        [EntityAttribute(FieldName = "check_operator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Check_Operator { get; set; }

        /// <summary>
        /// Submit_Opera
        /// </summary>
        [EntityAttribute(FieldName = "submit_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Submit_Opera { get; set; }

        /// <summary>
        /// Sort_No
        /// </summary>
        [EntityAttribute(FieldName = "sort_no", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 15)]
        public System.String Sort_No { get; set; }

        /// <summary>
        /// Send_Time
        /// </summary>
        [EntityAttribute(FieldName = "send_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime? Send_Time { get; set; }

        /// <summary>
        /// Send_Flag
        /// </summary>
        [EntityAttribute(FieldName = "send_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Send_Flag { get; set; }

        /// <summary>
        /// Send_Operator
        /// </summary>
        [EntityAttribute(FieldName = "send_operator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Send_Operator { get; set; }

        /// <summary>
        /// Check_Flag
        /// </summary>
        [EntityAttribute(FieldName = "check_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Check_Flag { get; set; }

        /// <summary>
        /// Exec_Sn
        /// </summary>
        [EntityAttribute(FieldName = "exec_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Exec_Sn { get; set; }

        /// <summary>
        /// Dept_Print_Flag
        /// </summary>
        [EntityAttribute(FieldName = "dept_print_flag", DbType = DbType.Byte, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Byte? Dept_Print_Flag { get; set; }

        /// <summary>
        /// Print_Group
        /// </summary>
        [EntityAttribute(FieldName = "print_group", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Print_Group { get; set; }

        /// <summary>
        /// Father_Page_No
        /// </summary>
        [EntityAttribute(FieldName = "father_page_no", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Int32? Father_Page_No { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Dept_Sn = "Dept_Sn";
            public string Ward_Sn = "Ward_Sn";
            public string Submit_Time = "Submit_Time";
            public string Page_Type = "Page_Type";
            public string Page_No = "Page_No";
            public string Confirm_Flag = "Confirm_Flag";
            public string Confirm_Operator = "Confirm_Operator";
            public string Group_No = "Group_No";
            public string Confirm_Time = "Confirm_Time";
            public string Print_Time = "Print_Time";
            public string Print_Flag = "Print_Flag";
            public string Checke = "Checke";
            public string Check_Operator = "Check_Operator";
            public string Submit_Opera = "Submit_Opera";
            public string Sort_No = "Sort_No";
            public string Send_Time = "Send_Time";
            public string Send_Flag = "Send_Flag";
            public string Send_Operator = "Send_Operator";
            public string Check_Flag = "Check_Flag";
            public string Exec_Sn = "Exec_Sn";
            public string Dept_Print_Flag = "Dept_Print_Flag";
            public string Print_Group = "Print_Group";
            public string Father_Page_No = "Father_Page_No";
        }
    }

    #endregion

    #region EntityHRecipeForm
    /// <summary>
    /// EntityHRecipeForm
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisHerbalrecipeform")]
    public class EntityHRecipeForm : BaseDataContract
    {
        /// <summary>
        /// Orderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Orderid { get; set; }

        /// <summary>
        /// Deptsn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptsn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Deptsn { get; set; }

        /// <summary>
        /// Wardsn
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wardsn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Wardsn { get; set; }

        /// <summary>
        /// Submitdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "submitdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime Submitdate { get; set; }

        /// <summary>
        /// Pagetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pagetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal Pagetype { get; set; }

        /// <summary>
        /// Pageno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pageno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Pageno { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Sortno { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Orderid = "Orderid";
            public string Deptsn = "Deptsn";
            public string Wardsn = "Wardsn";
            public string Submitdate = "Submitdate";
            public string Pagetype = "Pagetype";
            public string Pageno = "Pageno";
            public string Sortno = "Sortno";
        }
    }

    #endregion

    #region Ops

    #region PoOpApply
    /// <summary>
    /// ops_apply
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "ops_apply")]
    public class PoOpApply : BaseDataContract
    {
        /// <summary>
        /// Op_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Op_Id { get; set; }

        /// <summary>
        /// Patient_Id
        /// </summary>
        [EntityAttribute(FieldName = "patient_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Patient_Id { get; set; }

        /// <summary>
        /// Admiss_Times
        /// </summary>
        [EntityAttribute(FieldName = "admiss_times", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 Admiss_Times { get; set; }

        /// <summary>
        /// Applye
        /// </summary>
        [EntityAttribute(FieldName = "apply_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime? Apply_Date { get; set; }

        /// <summary>
        /// Apply_User
        /// </summary>
        [EntityAttribute(FieldName = "apply_user", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Apply_User { get; set; }

        /// <summary>
        /// Schedulee
        /// </summary>
        [EntityAttribute(FieldName = "schedule_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime? Schedule_Date { get; set; }

        /// <summary>
        /// Schedule_User
        /// </summary>
        [EntityAttribute(FieldName = "schedule_user", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Schedule_User { get; set; }

        /// <summary>
        /// Confirme
        /// </summary>
        [EntityAttribute(FieldName = "confirm_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? Confirm_Date { get; set; }

        /// <summary>
        /// Confirm_User
        /// </summary>
        [EntityAttribute(FieldName = "confirm_user", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Confirm_User { get; set; }

        /// <summary>
        /// Dept_Sn
        /// </summary>
        [EntityAttribute(FieldName = "dept_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Dept_Sn { get; set; }

        /// <summary>
        /// Ward_Sn
        /// </summary>
        [EntityAttribute(FieldName = "ward_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Ward_Sn { get; set; }

        /// <summary>
        /// Apply_Dept
        /// </summary>
        [EntityAttribute(FieldName = "apply_dept", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Apply_Dept { get; set; }

        /// <summary>
        /// Apply_Ward
        /// </summary>
        [EntityAttribute(FieldName = "apply_ward", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Apply_Ward { get; set; }

        /// <summary>
        /// Out_Dept
        /// </summary>
        [EntityAttribute(FieldName = "out_dept", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Out_Dept { get; set; }

        /// <summary>
        /// Out_Ward
        /// </summary>
        [EntityAttribute(FieldName = "out_ward", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Out_Ward { get; set; }

        /// <summary>
        /// Op_Code
        /// </summary>
        [EntityAttribute(FieldName = "op_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Op_Code { get; set; }

        /// <summary>
        /// Op_Name
        /// </summary>
        [EntityAttribute(FieldName = "op_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Op_Name { get; set; }

        /// <summary>
        /// Mazui_Code
        /// </summary>
        [EntityAttribute(FieldName = "mazui_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Mazui_Code { get; set; }

        /// <summary>
        /// Op_Status
        /// </summary>
        [EntityAttribute(FieldName = "op_status", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Op_Status { get; set; }

        /// <summary>
        /// Patient_Type
        /// </summary>
        [EntityAttribute(FieldName = "patient_type", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Patient_Type { get; set; }

        /// <summary>
        /// Op_B_Time
        /// </summary>
        [EntityAttribute(FieldName = "op_b_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.DateTime? Op_B_Time { get; set; }

        /// <summary>
        /// Diag_Before_Op
        /// </summary>
        [EntityAttribute(FieldName = "diag_before_op", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String Diag_Before_Op { get; set; }

        /// <summary>
        /// Diag_After_Op
        /// </summary>
        [EntityAttribute(FieldName = "diag_after_op", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String Diag_After_Op { get; set; }

        /// <summary>
        /// Relating_No
        /// </summary>
        [EntityAttribute(FieldName = "relating_no", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Double? Relating_No { get; set; }

        /// <summary>
        /// Unknown_Time_Flag
        /// </summary>
        [EntityAttribute(FieldName = "unknown_time_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Unknown_Time_Flag { get; set; }

        /// <summary>
        /// Infection_Flag
        /// </summary>
        [EntityAttribute(FieldName = "infection_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String Infection_Flag { get; set; }

        /// <summary>
        /// Urgent_Clinic_Flag
        /// </summary>
        [EntityAttribute(FieldName = "urgent_clinic_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String Urgent_Clinic_Flag { get; set; }

        /// <summary>
        /// Avocation_Flag
        /// </summary>
        [EntityAttribute(FieldName = "avocation_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Avocation_Flag { get; set; }

        /// <summary>
        /// Blood_Amount
        /// </summary>
        [EntityAttribute(FieldName = "blood_amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Decimal? Blood_Amount { get; set; }

        /// <summary>
        /// Blood_Unit
        /// </summary>
        [EntityAttribute(FieldName = "blood_unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Blood_Unit { get; set; }

        /// <summary>
        /// State_Code
        /// </summary>
        [EntityAttribute(FieldName = "state_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String State_Code { get; set; }

        /// <summary>
        /// Op_Room_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_room_id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String Op_Room_Id { get; set; }

        /// <summary>
        /// Isolation_Indicator
        /// </summary>
        [EntityAttribute(FieldName = "isolation_indicator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String Isolation_Indicator { get; set; }

        /// <summary>
        /// Op_Grade
        /// </summary>
        [EntityAttribute(FieldName = "op_grade", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Int32? Op_Grade { get; set; }

        /// <summary>
        /// Op_Group_No
        /// </summary>
        [EntityAttribute(FieldName = "op_group_no", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Op_Group_No { get; set; }

        /// <summary>
        /// Op_E_Time
        /// </summary>
        [EntityAttribute(FieldName = "op_e_time", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.DateTime? Op_E_Time { get; set; }

        /// <summary>
        /// Diag_Before_Code
        /// </summary>
        [EntityAttribute(FieldName = "diag_before_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String Diag_Before_Code { get; set; }

        /// <summary>
        /// Diag_After_Code
        /// </summary>
        [EntityAttribute(FieldName = "diag_after_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String Diag_After_Code { get; set; }

        /// <summary>
        /// Exec_Sn
        /// </summary>
        [EntityAttribute(FieldName = "exec_sn", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String Exec_Sn { get; set; }

        /// <summary>
        /// Hbsag
        /// </summary>
        [EntityAttribute(FieldName = "HbsAg", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String Hbsag { get; set; }

        /// <summary>
        /// Body_Code
        /// </summary>
        [EntityAttribute(FieldName = "body_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String Body_Code { get; set; }

        /// <summary>
        /// Specialreq_Code
        /// </summary>
        [EntityAttribute(FieldName = "specialreq_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Specialreq_Code { get; set; }

        /// <summary>
        /// Instrument_Code
        /// </summary>
        [EntityAttribute(FieldName = "instrument_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.String Instrument_Code { get; set; }

        /// <summary>
        /// Aspesis_Code
        /// </summary>
        [EntityAttribute(FieldName = "aspesis_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.String Aspesis_Code { get; set; }

        /// <summary>
        /// Selfblood_Flag
        /// </summary>
        [EntityAttribute(FieldName = "selfblood_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.String Selfblood_Flag { get; set; }

        /// <summary>
        /// Mz_Confirm_Flag
        /// </summary>
        [EntityAttribute(FieldName = "mz_confirm_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.String Mz_Confirm_Flag { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 47)]
        public System.String Remark { get; set; }

        /// <summary>
        /// Showinfo
        /// </summary>
        [EntityAttribute(FieldName = "showinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 48)]
        public System.String Showinfo { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        [EntityAttribute(FieldName = "weight", DbType = DbType.Double, IsPK = false, IsSeq = false, SerNo = 49)]
        public System.Double? Weight { get; set; }

        /// <summary>
        /// Allergic_History
        /// </summary>
        [EntityAttribute(FieldName = "allergic_history", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 50)]
        public System.String Allergic_History { get; set; }

        /// <summary>
        /// Blood_Kind
        /// </summary>
        [EntityAttribute(FieldName = "blood_kind", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 51)]
        public System.String Blood_Kind { get; set; }

        /// <summary>
        /// HIV
        /// </summary>
        [EntityAttribute(FieldName = "HIV", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 52)]
        public System.String HIV { get; set; }

        /// <summary>
        /// USR
        /// </summary>
        [EntityAttribute(FieldName = "USR", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 53)]
        public System.String USR { get; set; }

        /// <summary>
        /// Check_Opera
        /// </summary>
        [EntityAttribute(FieldName = "check_opera", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 54)]
        public System.String Check_Opera { get; set; }

        /// <summary>
        /// Checke
        /// </summary>
        [EntityAttribute(FieldName = "check_date", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 55)]
        public System.DateTime? Check_Date { get; set; }

        /// <summary>
        /// Ops_Status
        /// </summary>
        [EntityAttribute(FieldName = "ops_status", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 56)]
        public System.Int32? Ops_Status { get; set; }

        /// <summary>
        /// RH
        /// </summary>
        [EntityAttribute(FieldName = "RH", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 57)]
        public System.String RH { get; set; }

        /// <summary>
        /// Ops_Group
        /// </summary>
        [EntityAttribute(FieldName = "ops_group", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 58)]
        public System.String Ops_Group { get; set; }

        /// <summary>
        /// Incision_Category
        /// </summary>
        [EntityAttribute(FieldName = "incision_category", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 59)]
        public System.Int32? Incision_Category { get; set; }

        /// <summary>
        /// Indication
        /// </summary>
        [EntityAttribute(FieldName = "indication", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 60)]
        public System.Int32? Indication { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Op_Id = "Op_Id";
            public string Patient_Id = "Patient_Id";
            public string Admiss_Times = "Admiss_Times";
            public string Apply_Date = "Apply_Date";
            public string Apply_User = "Apply_User";
            public string Schedule_Date = "Schedule_Date";
            public string Schedule_User = "Schedule_User";
            public string Confirm_Date = "Confirm_Date";
            public string Confirm_User = "Confirm_User";
            public string Dept_Sn = "Dept_Sn";
            public string Ward_Sn = "Ward_Sn";
            public string Apply_Dept = "Apply_Dept";
            public string Apply_Ward = "Apply_Ward";
            public string Out_Dept = "Out_Dept";
            public string Out_Ward = "Out_Ward";
            public string Op_Code = "Op_Code";
            public string Op_Name = "Op_Name";
            public string Mazui_Code = "Mazui_Code";
            public string Op_Status = "Op_Status";
            public string Patient_Type = "Patient_Type";
            public string Op_B_Time = "Op_B_Time";
            public string Diag_Before_Op = "Diag_Before_Op";
            public string Diag_After_Op = "Diag_After_Op";
            public string Relating_No = "Relating_No";
            public string Unknown_Time_Flag = "Unknown_Time_Flag";
            public string Infection_Flag = "Infection_Flag";
            public string Urgent_Clinic_Flag = "Urgent_Clinic_Flag";
            public string Avocation_Flag = "Avocation_Flag";
            public string Blood_Amount = "Blood_Amount";
            public string Blood_Unit = "Blood_Unit";
            public string State_Code = "State_Code";
            public string Op_Room_Id = "Op_Room_Id";
            public string Isolation_Indicator = "Isolation_Indicator";
            public string Op_Grade = "Op_Grade";
            public string Op_Group_No = "Op_Group_No";
            public string Op_E_Time = "Op_E_Time";
            public string Diag_Before_Code = "Diag_Before_Code";
            public string Diag_After_Code = "Diag_After_Code";
            public string Exec_Sn = "Exec_Sn";
            public string Hbsag = "Hbsag";
            public string Body_Code = "Body_Code";
            public string Specialreq_Code = "Specialreq_Code";
            public string Instrument_Code = "Instrument_Code";
            public string Aspesis_Code = "Aspesis_Code";
            public string Selfblood_Flag = "Selfblood_Flag";
            public string Mz_Confirm_Flag = "Mz_Confirm_Flag";
            public string Remark = "Remark";
            public string Showinfo = "Showinfo";
            public string Weight = "Weight";
            public string Allergic_History = "Allergic_History";
            public string Blood_Kind = "Blood_Kind";
            public string HIV = "HIV";
            public string USR = "USR";
            public string Check_Opera = "Check_Opera";
            public string Checke = "Checke";
            public string Ops_Status = "Ops_Status";
            public string RH = "RH";
            public string Ops_Group = "Ops_Group";
            public string Incision_Category = "Incision_Category";
            public string Indication = "Indication";
        }
    }

    #endregion

    #region PoOpActor
    /// <summary>
    /// ops_actor
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "ops_actor")]
    public class PoOpActor : BaseDataContract
    {
        /// <summary>
        /// Op_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Op_Id { get; set; }

        /// <summary>
        /// Op_Function_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_function_id", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Op_Function_Id { get; set; }

        /// <summary>
        /// Op_Jion_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_jion_id", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32? Op_Jion_Id { get; set; }

        /// <summary>
        /// Op_Operator
        /// </summary>
        [EntityAttribute(FieldName = "op_operator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Op_Operator { get; set; }

        /// <summary>
        /// Workload
        /// </summary>
        [EntityAttribute(FieldName = "workload", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Workload { get; set; }

        /// <summary>
        /// Overworktime
        /// </summary>
        [EntityAttribute(FieldName = "overworktime", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32? Overworktime { get; set; }

        /// <summary>
        /// Op_Operator_Name
        /// </summary>
        [EntityAttribute(FieldName = "op_operator_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Op_Operator_Name { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [EntityAttribute(FieldName = "comment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Comment { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Op_Id = "Op_Id";
            public string Op_Function_Id = "Op_Function_Id";
            public string Op_Jion_Id = "Op_Jion_Id";
            public string Op_Operator = "Op_Operator";
            public string Workload = "Workload";
            public string Overworktime = "Overworktime";
            public string Op_Operator_Name = "Op_Operator_Name";
            public string Comment = "Comment";
        }
    }

    #endregion

    #region PoOpInstrument
    /// <summary>
    /// ops_instrument_list
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "ops_instrument_list")]
    public class PoOpInstrument : BaseDataContract
    {
        /// <summary>
        /// Op_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Op_Id { get; set; }

        /// <summary>
        /// Instrument_Code
        /// </summary>
        [EntityAttribute(FieldName = "instrument_code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Instrument_Code { get; set; }

        /// <summary>
        /// Instrument_Name
        /// </summary>
        [EntityAttribute(FieldName = "instrument_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Instrument_Name { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Op_Id = "Op_Id";
            public string Instrument_Code = "Instrument_Code";
            public string Instrument_Name = "Instrument_Name";
        }
    }

    #endregion

    #region PoOpInterface
    /// <summary>
    /// yz_opserface
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "yz_opserface")]
    public class PoOpInterface : BaseDataContract
    {
        /// <summary>
        /// Op_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Op_Id { get; set; }

        /// <summary>
        /// Order_Sn
        /// </summary>
        [EntityAttribute(FieldName = "order_sn", DbType = DbType.Double, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Double Order_Sn { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Op_Id = "Op_Id";
            public string Order_Sn = "Order_Sn";
        }
    }

    #endregion

    #region PoOpIcdBefore
    /// <summary>
    /// ops_before_code_list
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "ops_before_code_list")]
    public class PoOpIcdBefore : BaseDataContract
    {
        /// <summary>
        /// Op_Id
        /// </summary>
        [EntityAttribute(FieldName = "op_id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Op_Id { get; set; }

        /// <summary>
        /// Diag_Before_Code
        /// </summary>
        [EntityAttribute(FieldName = "diag_before_code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Diag_Before_Code { get; set; }

        /// <summary>
        /// Diag_Before_Name
        /// </summary>
        [EntityAttribute(FieldName = "diag_before_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Diag_Before_Name { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Op_Id = "Op_Id";
            public string Diag_Before_Code = "Diag_Before_Code";
            public string Diag_Before_Name = "Diag_Before_Name";
        }
    }

    #endregion

    #endregion

    #region EntityCpAccessIcd
    /// <summary>
    /// EntityCpAccessIcd
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "cpAccessicd")]
    public class EntityCpAccessIcd : BaseDataContract
    {
        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Type { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Icd
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icd", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Icd { get; set; }

        /// <summary>
        /// Icdname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Icdname { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Type = "Type";
            public string Cpid = "Cpid";
            public string Icd = "Icd";
            public string Icdname = "Icdname";
            public string Typename = "Typename";
        }
        [DataMember]
        public System.String Typename { get; set; }
    }
    #endregion

    #region EntityCpVariation
    /// <summary>
    /// EntityCpVariation
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpVariation")]
    public class EntityCpVariation : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Varinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "varinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Varinfo { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "scope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Scope { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Cpid = "Cpid";
            public string Varinfo = "Varinfo";
            public string Scope = "Scope";
            public string Scopename = "Scopename";
            public string Sortno = "Sortno";
        }
        /// <summary>
        /// Scopename 使用范围 0 公用 1 医嘱 2 草药处方
        /// </summary>
        [DataMember]
        public System.String Scopename { get; set; }

        [DataMember]
        public int Sortno { get; set; }
    }

    #endregion

    #region EntityCpOutCriterion
    /// <summary>
    /// EntityCpOutCriterion
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpOutcriterion")]
    public class EntityCpOutCriterion : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Criinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "criinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Criinfo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Cpid = "Cpid";
            public string Criinfo = "Criinfo";
            public string Sortno = "Sortno";
        }
        [DataMember]
        public int Sortno { get; set; }
    }
    #endregion

    #region EntityCpStatIndex
    /// <summary>
    /// EntityCpStatIndex
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpStatindex")]
    public class EntityCpStatIndex : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Typeid { get; set; }

        /// <summary>
        /// Statcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "statcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Statcode { get; set; }

        /// <summary>
        /// Statname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "statname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Statname { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Cpid = "Cpid";
            public string Typeid = "Typeid";
            public string Statcode = "Statcode";
            public string Statname = "Statname";
            public string Typename = "Typename";
        }
        /// <summary>
        /// Typename
        /// </summary>
        [DataMember]
        public System.String Typename { get; set; }
    }

    #endregion

    #region EntityCpDnwork
    /// <summary>
    /// EntityCpDnwork
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "cpDnwork")]
    public class EntityCpDnwork : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Classid { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Typeid { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Workdesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "workdesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Workdesc { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Casecode { get; set; }

        /// <summary>
        /// Casename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Casename { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal Isrequired { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Classid = "Classid";
            public string Typeid = "Typeid";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Workdesc = "Workdesc";
            public string Casecode = "Casecode";
            public string Casename = "Casename";
            public string Isrequired = "Isrequired";

            public string Classname = "Classname";
            public string Typename = "Typename";
            public string Requirename = "Requirename";
        }
        [DataMember]
        public System.String Classname { get; set; }
        [DataMember]
        public System.String Typename { get; set; }
        [DataMember]
        public System.String Requirename { get; set; }

    }
    #endregion

    #region EntityCpOrder
    /// <summary>
    /// EntityCpOrder
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpOrder")]
    public class EntityCpOrder : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Orderclassid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderclassid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Orderclassid { get; set; }

        /// <summary>
        /// Ordertypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordertypeid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Ordertypeid { get; set; }

        /// <summary>
        /// Ordertypename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ordertypename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Ordertypename { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosagescale
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosagescale", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal? Dosagescale { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Dosageunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Dosageunitname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Days
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "days", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal? Days { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal? Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal? Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Decimal? Total { get; set; }

        /// <summary>
        /// Packunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Packunitid { get; set; }

        /// <summary>
        /// Packunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String Packunitname { get; set; }

        /// <summary>
        /// Packqty
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packqty", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Decimal? Packqty { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Decimal Sortno { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentorderid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Parentorderid { get; set; }

        /// <summary>
        /// Skintestflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "skintestflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal Skintestflag { get; set; }

        /// <summary>
        /// Otherpackflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "otherpackflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Decimal? Otherpackflag { get; set; }

        /// <summary>
        /// Urgencyflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "urgencyflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Decimal? Urgencyflag { get; set; }

        /// <summary>
        /// Drugflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drugflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Decimal? Drugflag { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.Decimal Isrequired { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "packsn", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String Packsn { get; set; }

        /// <summary>
        /// Illstate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "illstate", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String Illstate { get; set; }

        /// <summary>
        /// Phyexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "phyexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.String Phyexam { get; set; }

        /// <summary>
        /// Othexam
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "othexam", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String Othexam { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "nodedays", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.Decimal Nodedays { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "pharmacyno", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.String Pharmacyno { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "caseid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.Decimal? Caseid { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "ordersn", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.Decimal? Ordersn { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Orderclassid = "Orderclassid";
            public string Ordertypeid = "Ordertypeid";
            public string Ordertypename = "Ordertypename";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Dosage = "Dosage";
            public string Dosagescale = "Dosagescale";
            public string Dosageunitid = "Dosageunitid";
            public string Dosageunitname = "Dosageunitname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Days = "Days";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Packunitid = "Packunitid";
            public string Packunitname = "Packunitname";
            public string Packqty = "Packqty";
            public string Sortno = "Sortno";
            public string Parentflag = "Parentflag";
            public string Parentorderid = "Parentorderid";
            public string Skintestflag = "Skintestflag";
            public string Otherpackflag = "Otherpackflag";
            public string Urgencyflag = "Urgencyflag";
            public string Drugflag = "Drugflag";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Entrustinfo = "Entrustinfo";
            public string Isrequired = "Isrequired";
            public string Packsn = "Packsn";
            public string Illstate = "Illstate";
            public string Phyexam = "Phyexam";
            public string Othexam = "Othexam";
            public string Nodedays = "Nodedays";
            public string Pharmacyno = "Pharmacyno";
            public string Caseid = "Caseid";
            public string Ordersn = "Ordersn";

            public string Checked = "Checked";
            public string Orderclassname = "Orderclassname";
            public string Skintestflagname = "Skintestflagname";
            public string Otherpackflagname = "Otherpackflagname";
            public string Urgencyflagname = "Urgencyflagname";
            public string Requirename = "Requirename";
            public string Isdrug = "Isdrug";
            public string IsTemplateItem = "IsTemplateItem";
        }
        [DataMember]
        public int Checked { get; set; }
        [DataMember]
        public System.String Orderclassname { get; set; }
        [DataMember]
        public System.String Skintestflagname { get; set; }
        [DataMember]
        public System.String Otherpackflagname { get; set; }
        [DataMember]
        public System.String Urgencyflagname { get; set; }
        [DataMember]
        public System.String Requirename { get; set; }
        [DataMember]
        public System.Decimal? Isdrug { get; set; }
        [DataMember]
        public int IsTemplateItem { get; set; }

    }

    #endregion

    #region EntityHerbalRecipeMain
    /// <summary>
    /// EntityHerbalRecipeMain
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpHerbalmain")]
    public class EntityHerbalRecipeMain : BaseDataContract
    {
        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Nodename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nodename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Nodename { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Recipename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Recipename { get; set; }

        /// <summary>
        /// Recipeattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? Recipeattributeid { get; set; }

        /// <summary>
        /// Recipetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal Recipetype { get; set; }

        /// <summary>
        /// Typeida
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeida", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Typeida { get; set; }

        /// <summary>
        /// Typeidb
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidb", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal Typeidb { get; set; }

        /// <summary>
        /// Typeidc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidc", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal Typeidc { get; set; }

        /// <summary>
        /// Begindatetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindatetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? Begindatetype { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime Begindate { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String Decoction { get; set; }

        /// <summary>
        /// Decoctionname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoctionname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Decoctionname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Freqid { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Freqname { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal? Dosage { get; set; }

        /// <summary>
        /// Dosageunitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String Dosageunitid { get; set; }

        /// <summary>
        /// Dosageunitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String Dosageunitname { get; set; }

        /// <summary>
        /// Packs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packs", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal Packs { get; set; }

        /// <summary>
        /// Outflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal Outflag { get; set; }

        /// <summary>
        /// Helpflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "helpflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Decimal Helpflag { get; set; }

        /// <summary>
        /// Recipemoney
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipemoney", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Decimal? Recipemoney { get; set; }

        /// <summary>
        /// Execdeptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String Execdeptid { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String Execdeptname { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String Entrustinfo { get; set; }

        /// <summary>
        /// Recordoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String Recordoperid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.DateTime? Recorddate { get; set; }

        /// <summary>
        /// Isrequired
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isrequired", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal Isrequired { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Recipecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String Recipecode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Cpid = "Cpid";
            public string Nodename = "Nodename";
            public string Recipeid = "Recipeid";
            public string Recipename = "Recipename";
            public string Recipeattributeid = "Recipeattributeid";
            public string Recipetype = "Recipetype";
            public string Typeida = "Typeida";
            public string Typeidb = "Typeidb";
            public string Typeidc = "Typeidc";
            public string Begindatetype = "Begindatetype";
            public string Begindate = "Begindate";
            public string Decoction = "Decoction";
            public string Decoctionname = "Decoctionname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Freqid = "Freqid";
            public string Freqname = "Freqname";
            public string Dosage = "Dosage";
            public string Dosageunitid = "Dosageunitid";
            public string Dosageunitname = "Dosageunitname";
            public string Packs = "Packs";
            public string Outflag = "Outflag";
            public string Helpflag = "Helpflag";
            public string Recipemoney = "Recipemoney";
            public string Execdeptid = "Execdeptid";
            public string Execdeptname = "Execdeptname";
            public string Entrustinfo = "Entrustinfo";
            public string Recordoperid = "Recordoperid";
            public string Recorddate = "Recorddate";
            public string Isrequired = "Isrequired";
            public string Status = "Status";
            public string Recipecode = "Recipecode";
            public string Isappend = "Isappend";
            public string IsNew = "IsNew";
        }
        [DataMember]
        public System.Int32 Isappend { get; set; }
        [DataMember]
        public bool IsNew { get; set; }
    }

    #endregion

    #region EntityHerbalRecipeDetail
    /// <summary>
    /// EntityHerbalRecipeDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpHerbaldetail")]
    public class EntityHerbalRecipeDetailCP : BaseDataContract
    {
        /// <summary>
        /// Recipesubid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipesubid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Recipesubid { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Recipeid { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Groupno { get; set; }

        /// <summary>
        /// Orderdicid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Orderdicid { get; set; }

        /// <summary>
        /// Orderdicname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderdicname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Orderdicname { get; set; }

        /// <summary>
        /// Orderprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderprtname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Orderprtname { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Spec { get; set; }

        /// <summary>
        /// Unitid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Unitid { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Unitname { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Usageid { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Usagename { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal Amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal Price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal Total { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? Parentflag { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Parentid { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "comment", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String Comment { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Recipesubid = "Recipesubid";
            public string Recipeid = "Recipeid";
            public string Groupno = "Groupno";
            public string Orderdicid = "Orderdicid";
            public string Orderdicname = "Orderdicname";
            public string Orderprtname = "Orderprtname";
            public string Spec = "Spec";
            public string Unitid = "Unitid";
            public string Unitname = "Unitname";
            public string Usageid = "Usageid";
            public string Usagename = "Usagename";
            public string Amount = "Amount";
            public string Price = "Price";
            public string Total = "Total";
            public string Parentflag = "Parentflag";
            public string Parentid = "Parentid";
            public string Sortno = "Sortno";
            public string Comment = "Comment";
        }
    }

    #endregion

    #region EntityCpSyndrome
    /// <summary>
    /// EntityCpSyndrome
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cpSyndrome")]
    public class EntityCpSyndrome : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal Serno { get; set; }

        /// <summary>
        /// Cpid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cpid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal Cpid { get; set; }

        /// <summary>
        /// Syncode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "syncode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Syncode { get; set; }

        /// <summary>
        /// Synname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "synname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Synname { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Serno = "Serno";
            public string Cpid = "Cpid";
            public string Syncode = "Syncode";
            public string Synname = "Synname";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Status = "Status";
        }
    }

    #endregion

    #endregion

    #region 草药

    /// <summary>
    /// EntityHerbalRecipeType
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicHerbalrecipetype")]
    public class EntityHerbalRecipeType : BaseDataContract
    {
        /// <summary>
        /// Hrtypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrtypeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Hrtypeid { get; set; }

        /// <summary>
        /// Hrtypecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrtypecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Hrtypecode { get; set; }

        /// <summary>
        /// Hrtypename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrtypename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Hrtypename { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Decid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Decid { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Hrtypeid = "Hrtypeid";
            public string Hrtypecode = "Hrtypecode";
            public string Hrtypename = "Hrtypename";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Decid = "Decid";
            public string Status = "Status";
        }
    }

    /// <summary>
    /// EntityDecoction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDecoction")]
    public class EntityDecoction : BaseDataContract
    {
        /// <summary>
        /// Decid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal Decid { get; set; }

        /// <summary>
        /// Deccode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deccode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Deccode { get; set; }

        /// <summary>
        /// Decname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Decname { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal Typeid { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Decid = "Decid";
            public string Deccode = "Deccode";
            public string Decname = "Decname";
            public string Typeid = "Typeid";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Status = "Status";
        }
    }

    #endregion
    
}
