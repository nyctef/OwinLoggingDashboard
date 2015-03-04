using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinLoggingDashboard
{
    class LoggingDisplayMiddleware : OwinMiddleware
    {
        public LoggingDisplayMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public async override Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);
        }
    }
}
