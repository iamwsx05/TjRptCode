using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ServiceModel;

namespace weCare
{
    public class ProxyUpdate
    {
        public ItfUpdate Service = null;

        public ProxyUpdate()
        {
            Service = WCFEndpoint.Fac<ItfUpdate>().CreateChannel(WCFEndpoint.CommEndpointAddress(this.GetType().Name));
        }

        public void Dispose()
        {
            if (Service != null)
            {
                Service = null;
            }
        } 
    }
}
