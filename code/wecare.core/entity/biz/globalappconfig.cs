using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 本地参数类
    /// </summary>
    public class GlobalAppConfig
    {
        /// <summary>
        /// 系统运行模式: 2 CS; 3 CSS
        /// </summary>
        public static int RunningMode { get; set; }

        /// <summary>
        /// 本地参数
        /// </summary>
        public static List<EntityAppConfig> AppConfig { get; set; }

        /// <summary>
        /// 初始化密码
        /// </summary>
        public const string INIT_PWD = "888888";

        /// <summary>
        /// 路程路径标识符
        /// </summary>
        public const string CP_SIGN = "^";

        public static List<EntityAccount> AccountFuncs { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public static string MidderServerIP = string.Empty;
    }
}
