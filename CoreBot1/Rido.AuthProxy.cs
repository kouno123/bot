using System;
using System.Net;

namespace Rido.AuthProxy
{
    public class AuthProxyModule : IWebProxy
    {
        ICredentials crendential = new NetworkCredential("proxy.user", "password");
        public ICredentials Credentials
        {
            get
            {
                return crendential;
            }
            set
            {
                crendential = value;
            }
        }
        public Uri GetProxy(Uri destination)
        {
            return new Uri("http://proxy:8080", UriKind.Absolute);
        }
        public bool IsBypassed(Uri host)
        {
            return host.IsLoopback;
        }
    }
}