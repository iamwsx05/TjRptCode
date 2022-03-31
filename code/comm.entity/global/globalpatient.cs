using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entity
{
    /// <summary>
    /// 全局病人类
    /// </summary>
    public class GlobalPatient
    {
        /// <summary>
        /// 当前病人信息
        /// </summary>
        public static EntityPatient currPatient = null;
        /// <summary>
        /// 初始密码-6个8
        /// </summary>
        public static string InitPwd = "888888";

    }
}
