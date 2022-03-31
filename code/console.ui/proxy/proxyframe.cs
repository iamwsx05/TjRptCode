using Console.Itf;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Microsoft.Practices.Unity;
using System;

namespace Console.Ui
{
    public class ProxyFrame : IDisposable
    {
        public ItfFrame Service = null;

        public ProxyFrame()
        {
            if (GlobalAppConfig.RunningMode == 2)
            {
                Service = Function.UnitySection("unity.xml", "unityConsole", "frame").Resolve<ItfFrame>();
            }
            else if (GlobalAppConfig.RunningMode == 3)
            {
                try
                {
                    Service = WcfEndpoint.Fac<ItfFrame>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
                    Service.Verify();
                }
                catch
                {
                    if (WcfEndpoint.AllowChange)
                    {
                        WcfEndpoint.ChangeServer();
                        Service = WcfEndpoint.Fac<ItfFrame>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
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
