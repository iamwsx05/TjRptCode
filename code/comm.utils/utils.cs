using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Utils;
using weCare.Core.Entity;
using Common.Entity;

namespace Common.Utils
{
    public class Utils
    {
        #region 服务器时间
        /// <summary>
        /// 服务器时间
        /// </summary>
        /// <returns></returns>
        public static DateTime ServerTime()
        {
            using (ProxyCommon proxy = new ProxyCommon())
            {
                return proxy.Service.GetServerTime();
            }
        }
        #endregion

        
    }
}
