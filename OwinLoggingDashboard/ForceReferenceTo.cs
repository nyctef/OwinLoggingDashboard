using Microsoft.Owin.Host.HttpListener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinLoggingDashboard
{
    static class ForceReferenceTo
    {
        public static void MicrosoftOwinHostHttpListener()
        {
            var unused = typeof(OwinHttpListener);
        }
    }
}
