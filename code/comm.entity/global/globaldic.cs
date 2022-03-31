using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// GlobalDic
    /// </summary>
    public class GlobalDic
    {
        /// <summary>
        /// 全院科室
        /// </summary>
        public static List<EntityCodeDepartment> DataSourceDepartment { get; set; }

        /// <summary>
        /// 全院科室--属性
        /// </summary>
        //public static List<EntityDeptattribute> DataSourceDeptAttri { get; set; }

        /// <summary>
        /// 全院病区
        /// </summary>
        public static List<EntityArea> DataSourceArea { get; set; }

        /// <summary>
        /// 全院科室--病区
        /// </summary>
        //public static List<EntityDeptArea> DataSourceDeptArea { get; set; }

        /// <summary>
        /// 职工--全院
        /// </summary>
        public static List<EntityCodeOperator> DataSourceEmployee { get; set; }

        /// <summary>
        /// 职工--医生
        /// </summary>
        public static List<EntityCodeOperator> DataSourceDoctor { get; set; }

        /// <summary>
        /// 职工--护士
        /// </summary>
        public static List<EntityCodeOperator> DataSourceNurse { get; set; }

        /// <summary>
        /// 职工--科室
        /// </summary>
        public static List<EntityPlusOperator> DataSourceEmpDept { get; set; }

        /// <summary>
        /// 职工--角色
        /// </summary>
        public static List<EntityDefOperatorRole> DataSourceEmpRole { get; set; }

        /// <summary>
        /// 员工-科室对应
        /// </summary>
        public static List<EntityDefDeptemployee> DataSourceDefDeptEmployee { get; set; }
         
        
        /// <summary>
        /// ICD
        /// </summary>
        public static List<EntityIcd> DataSourceICD { get; set; }

        /// <summary>
        /// 用法字典
        /// </summary>
        public static List<EntityCodeDirection> DataSourceDicDirection { get; set; }

        /// <summary>
        /// 频率字典
        /// </summary>
        public static List<EntityCodeFrequency> DataSourceDicFrequency { get; set; }

        /// <summary>
        /// 配置参数
        /// </summary>
        public static List<EntityDefConfiguration> DataSourceDefConfiguration { get; set; }

        /// <summary>
        /// 系统参数---全局职工角色信息
        /// </summary>
        public static System.Collections.Generic.Dictionary<string, List<string>> dicEmpRole { get; set; }

        /// <summary>
        /// 职称字典
        /// </summary>
        public static List<EntityCodeRank> DataSourceRank { get; set; }

        /// <summary>
        /// 费别字典
        /// </summary>
        public static List<EntityCodeFee> DataSourceDicFee { get; set; }

        /// <summary>
        /// 婚姻字典
        /// </summary>
        public static List<EntityCodeMarry> DataSourceDicMarry { get; set; }

        /// <summary>
        /// 职业字典
        /// </summary>
        public static List<EntityCodeJob> DataSourceDicJob { get; set; }

        /// <summary>
        /// 民族字典
        /// </summary>
        public static List<EntityCodeNation> DataSourceDicNation { get; set; }

        /// <summary>
        /// 国籍字典
        /// </summary>
        public static List<EntityCodeCountry> DataSourceDicCountry { get; set; }

        /// <summary>
        /// 通用字典
        /// </summary>
        public static List<EntityCommonDic> DataSourceDicCommon { get; set; }

        public static List<EntityDw> DataSourceDw { get; set; }


    }
}
