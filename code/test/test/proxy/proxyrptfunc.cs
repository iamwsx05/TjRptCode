using weCare.Core.Entity;
using weCare.Core.Utils;
using Microsoft.Practices.Unity;
using System;
using RtpFunc.Itf;

namespace RptFunc
{
    public class ProxyRptFunc : IDisposable
    {
        public ItfRptFunc Service = null;

        public ProxyRptFunc()
        {
            if (GlobalAppConfig.RunningMode == 2)
            {
                Service = Function.UnitySection("unity.xml", "unityRptFunc", "rptFunc").Resolve<ItfRptFunc>();
            }
            else if (GlobalAppConfig.RunningMode == 3)
            {
                try
                {
                    Service = WcfEndpoint.Fac<ItfRptFunc>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
                    Service.Verify();
                }
                catch
                {
                    if (WcfEndpoint.AllowChange)
                    {
                        WcfEndpoint.ChangeServer();
                        Service = WcfEndpoint.Fac<ItfRptFunc>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
                    }
                }
            }
        }

        public void Dispose()
        {
            if (Service != null)
            {
                Service.Dispose();
                Service = null;
            }
        }

    }
}
