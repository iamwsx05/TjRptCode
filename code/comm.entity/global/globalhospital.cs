using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 全局医院类
    /// </summary>
    public class GlobalHospital
    {
        /// <summary>
        /// 当前医院枚举
        /// </summary>
        public static EnumHospitalCode Current { get; set; }

        /// <summary>
        /// 组织机构系统编码
        /// </summary>
        public static string OrgSysCode
        {
            get
            {
                if (GlobalHospital.objHospital != null)
                    return GlobalHospital.objHospital.Orgsyscode;
                else
                    return string.Empty;
            }
            set { ;}
        }
        /// <summary>
        /// 医院名称
        /// </summary>
        public static string HospitalName
        {
            get
            {
                if (GlobalHospital.objHospital != null)
                    return GlobalHospital.objHospital.Hospitalname;
                else
                    return string.Empty;
            }
            set { ;}
        }

        /// <summary>
        /// 医院信息
        /// </summary>
        public static EntityHospital objHospital = null;

        /// <summary>
        /// 医院类型编码: 0001 增城妇幼保健院
        /// </summary>
        public static string HospitalCode
        {
            get
            {
                string strCode = "9999";
                string strHospitalName = string.Empty;

                if (GlobalHospital.objHospital != null)
                    strCode = GlobalHospital.objHospital.Orgcode;

                //if (GlobalHospital.objHospital != null)
                //{
                //    strHospitalName = GlobalHospital.objHospital.Hospitalname;
                //}
                //else if (!string.IsNullOrEmpty(HospitalName))
                //{
                //    strHospitalName = HospitalName;
                //}

                return strCode;
            }
        }

        /// <summary>
        /// 通过enum获取医院编码
        /// </summary>
        /// <param name="enu"></param>
        /// <returns></returns>
        public static string GetCode(EnumHospitalCode enu)
        {
            return Convert.ToInt32(enu).ToString();
        }

        /// <summary>
        /// 通过code获取医院枚举对象
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumHospitalCode GetEnum(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return EnumHospitalCode.未定义;
            }
            else
            {
                foreach (int val in Enum.GetValues(typeof(EnumHospitalCode)))
                {
                    if (code == val.ToString())
                    {
                        return (EnumHospitalCode)Enum.Parse(typeof(EnumHospitalCode), code);
                    }
                }
            }
            return EnumHospitalCode.未定义;
        }

        public static EntityHospitalPwd GetPassword(EnumHospitalCode current)
        {
            EntityHospitalPwd vo = new EntityHospitalPwd();
            switch (current)
            {
                case EnumHospitalCode.演示医院:
                    break;
                default:
                    break;
            }
            return vo;
        }
    }

    /// <summary>
    /// 医院编码
    /// </summary>
    public enum EnumHospitalCode
    { 
        演示医院 = 8005, 
        未定义 = 0
    }

    public class EntityHospitalPwd
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }

}
