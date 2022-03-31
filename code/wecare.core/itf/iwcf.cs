using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace weCare.Core.Itf
{
    /// <summary>
    /// 服务契约基类
    /// </summary>
    [System.ServiceModel.ServiceContract]
    public interface IWcf : IDisposable
    {
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool Verify();

        /// <summary>
        /// (中间层)服务器时间
        /// </summary>
        /// <returns></returns>
        //[OperationContract]
        //DateTime ServerTime();
    }
}
