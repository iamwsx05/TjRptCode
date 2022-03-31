using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Common.Entity
{
    #region 登录人信息
    /// <summary>
    /// 登录人信息
    /// </summary>
    public class GlobalLogin
    {
        /// <summary>
        /// 登录人信息
        /// </summary>
        public static EntityLogin objLogin = null;

        static string _SkinName = "Office 2010 Blue";

        /// <summary>
        /// 默认主题
        /// </summary>
        public static string SkinName
        {
            get { return _SkinName; }
            set { _SkinName = value; }
        }

        /// <summary>
        /// 混合色.值
        /// </summary>
        public static string SkinMaskColorValue { get; set; }

        /// <summary>
        /// 混合色
        /// </summary>
        public static System.Drawing.Color SkinMaskColor
        {
            get
            {
                if (!string.IsNullOrEmpty(SkinMaskColorValue))
                {
                    string[] val = SkinMaskColorValue.Split('|');
                    if (val.Length == 5)
                    {
                        return System.Drawing.Color.FromArgb(Function.Int(val[1]), Function.Int(val[2]), Function.Int(val[3]), Function.Int(val[4]));
                    }
                }
                return new System.Drawing.Color();
            }
        }

        /// <summary>
        /// 混合色2.值
        /// </summary>
        public static string SkinMaskColorValue2 { get; set; }
        /// <summary>
        /// 混合色2
        /// </summary>
        public static System.Drawing.Color SkinMaskColor2
        {
            get
            {
                if (!string.IsNullOrEmpty(SkinMaskColorValue2))
                {
                    string[] val = SkinMaskColorValue2.Split('|');
                    if (val.Length == 5)
                    {
                        return System.Drawing.Color.FromArgb(Function.Int(val[1]), Function.Int(val[2]), Function.Int(val[3]), Function.Int(val[4]));
                    }
                }
                return new System.Drawing.Color();
            }
        }

        /// <summary>
        /// 电话服务IP
        /// </summary>
        public static string TelServiceIp { get; set; }
    }
    #endregion

}
