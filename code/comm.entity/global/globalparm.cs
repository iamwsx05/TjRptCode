using System.Data;
using System.Collections.Generic;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 全局系统参数
    /// </summary>
    public class GlobalParm
    {
        /// <summary>
        /// 系统参数
        /// </summary>
        public static System.Collections.Generic.Dictionary<int, string> dicSysParameter = new Dictionary<int, string>();

        public static int MdiParentSubH { get; set; }

        public static int MdiParentSubW { get; set; }

        /// <summary>
        /// 弹出窗口打开
        /// </summary>
        public static bool IsPopupOpening { get; set; }

        #region 医嘱类
        /// <summary>
        /// 文字(描述)医嘱字典ID
        /// </summary>
        public const string DESC_ORDER_CODE = "999999";

        /// <summary>
        /// 医嘱.草药处方ID
        /// </summary>
        public const string DESC_HERBAL_CODE = "999998";

        /// <summary>
        /// 同组医嘱缺省ID
        /// </summary>
        public const int DEFAULT_GROUP_ORDERID = -99;

        #region Order

        /// <summary>
        /// 医嘱.长嘱字典
        /// </summary>
        public static DataTable DataSourceOrderL { get; set; }

        /// <summary>
        /// 医嘱.临嘱字典
        /// </summary>
        public static DataTable DataSourceOrderT { get; set; }

        /// <summary>
        /// 医嘱.用法字典
        /// </summary>
        public static DataTable DataSourceUsage { get; set; }

        /// <summary>
        /// 医嘱.频率
        /// </summary>
        public static DataTable DataSourceFreq { get; set; }

        /// <summary>
        /// 医嘱.执行科室字典
        /// </summary>
        public static DataTable DataSourceExecDept { get; set; }

        /// <summary>
        /// 显示列.长嘱
        /// </summary>
        public static string ShowColumnOrderL { get; set; }

        /// <summary>
        /// 显示列.临嘱
        /// </summary>
        public static string ShowColumnOrderT { get; set; }

        /// <summary>
        /// 显示列.用法
        /// </summary>
        public static string ShowColumnUsage { get; set; }

        /// <summary>
        /// 显示列.频率
        /// </summary>
        public static string ShowColumnFreq { get; set; }

        /// <summary>
        /// 显示列.执行科室
        /// </summary>
        public static string ShowColumnExecDept { get; set; }

        #endregion

        #endregion

        /// <summary>
        /// 全局界面签名状态.是否成功标志
        /// </summary>
        public static bool FormSignStatusIsSuccess { get; set; }

        public static string PrintFileDir = System.Windows.Forms.Application.StartupPath + "\\print";
        public static string PrintFileName = "emr xtrareport";

        /// <summary>
        /// 是否演示版本
        /// </summary>
        public static bool IsDemoVersion = false;

        #region 病理分类
        /// <summary>
        /// 病理分类
        /// </summary>
        public static List<weCare.Core.Entity.EntityPisClass> PisClass { get; set; }

        #endregion

        /// <summary>
        /// 系统菜单
        /// </summary>
        public static System.Collections.Generic.Dictionary<string, EntityAccount> dicSysMenu = new Dictionary<string, EntityAccount>();

    }
}
