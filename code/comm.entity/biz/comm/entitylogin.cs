using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 登录信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityLogin : BaseDataContract
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [DataMember]
        public string EmpId { get; set; }
        /// <summary>
        /// 员工工号
        /// </summary>
        [DataMember]
        public string EmpNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DataMember]
        public string EmpName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Sex { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [DataMember]
        public string Birthday { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [DataMember]
        public string IdCard { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [DataMember]
        public string Tel { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        [DataMember]
        public string Addr { get; set; }
        /// <summary>
        /// 身份标识：0 在职 1 实习 2 试用 3 进修 4 退休 5 返聘 6 离职
        /// </summary>
        [DataMember]
        public string IdentityFlag { get; set; }
        /// <summary>
        /// 技术职称代码
        /// </summary>
        [DataMember]
        public string TechLevelCode { get; set; }
        /// <summary>
        /// 技术职称名称
        /// </summary>
        [DataMember]
        public string TechLevelName { get; set; }
        /// <summary>
        /// 行政职务代码
        /// </summary>
        [DataMember]
        public string AdminlevelCode { get; set; }
        /// <summary>
        /// 行政职务名称
        /// </summary>
        [DataMember]
        public string AdminlevelName { get; set; }
        /// <summary>
        /// 系统登录密码
        /// </summary>
        [DataMember]
        public string Pwd { get; set; }
        /// <summary>
        /// 系统登录时间
        /// </summary>
        [DataMember]
        public string LoginTime { get; set; }
        /// <summary>
        /// 登录工作站Mac地址
        /// </summary>
        [DataMember]
        public string Mac { get; set; }
        /// <summary>
        /// 登录工作站IP地址
        /// </summary>
        [DataMember]
        public string IP { get; set; }
        /// <summary>
        /// 登录工作站名称
        /// </summary>
        [DataMember]
        public string HostName { get; set; }
        /// <summary>
        /// 职工标识: 1 医生；2 护士；3 行政后勤；9 管理员
        /// </summary>
        [DataMember]
        public int EmpFlag { get; set; }
        /// <summary>
        /// CA微缩图
        /// </summary>
        [DataMember]
        public string SignKeyID { get; set; }
        /// <summary>
        /// 默认科室ID
        /// </summary>
        [DataMember]
        public int DeptID { get; set; }
        /// <summary>
        /// 默认科室CODE
        /// </summary>
        [DataMember]
        public string DeptCode { get; set; }
        /// <summary>
        /// 默认科室名称
        /// </summary>
        [DataMember]
        public string DeptName { get; set; }
        /// <summary>
        /// 默认病区ID
        /// </summary>
        [DataMember]
        public int AreaID { get; set; }
        /// <summary>
        /// 默认病区名称
        /// </summary>
        [DataMember]
        public string AreaName { get; set; }
        /// <summary>
        /// 默认专业组ID
        /// </summary>
        [DataMember]
        public int TermID { get; set; }

        /// <summary>
        /// 所属科室列表
        /// </summary>
        [DataMember]
        public List<EntityCodeDepartment> lstDept { get; set; }
        /// <summary>
        /// 所属病区列表
        /// </summary>
        [DataMember]
        public List<EntityArea> lstArea { get; set; }
        /// <summary>
        /// 所属角色ID列表
        /// </summary>
        [DataMember]
        public List<string> lstRoleID { get; set; }
        /// <summary>
        /// 实习生(医师、护士)标志
        /// </summary>
        [DataMember]
        public bool TraineeFlag { get; set; }
        /// <summary>
        /// 密码启用时间
        /// </summary>
        [DataMember]
        public DateTime? PwdUseDate { get; set; }
        /// <summary>
        /// 密码有效期
        /// </summary>
        [DataMember]
        public int PwdValidDays { get; set; }
        /// <summary>
        /// 账户锁定状态
        /// </summary>
        [DataMember]
        public bool AcctLock { get; set; }

        /// <summary>
        /// 处方权
        /// </summary>
        [DataMember]
        public List<string> Prescription { get; set; }

        /// <summary>
        /// 药品(用药)权
        /// </summary>
        [DataMember]
        public List<string> MedLimits { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        [DataMember]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 职工类型： 01 医生； 02 护士； .... 
        /// </summary>
        [DataMember]
        public string clsCode { get; set; }
    }

}
