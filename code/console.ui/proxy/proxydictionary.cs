using Console.Itf;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Microsoft.Practices.Unity;
using System;

namespace Console.Ui
{
    public class ProxyDictionary : IDisposable
    {
        public ItfDictionary Service = null;

        public ProxyDictionary()
        {
            if (GlobalAppConfig.RunningMode == 2)
            {
                Service = Function.UnitySection("unity.xml", "unityConsole", "dictionary").Resolve<ItfDictionary>();
            }
            else if (GlobalAppConfig.RunningMode == 3)
            {
                try
                {
                    Service = WcfEndpoint.Fac<ItfDictionary>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
                    Service.Verify();
                }
                catch
                {
                    if (WcfEndpoint.AllowChange)
                    {
                        WcfEndpoint.ChangeServer();
                        Service = WcfEndpoint.Fac<ItfDictionary>().CreateChannel(WcfEndpoint.HisEndpointAddress(this.GetType().Name));
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
