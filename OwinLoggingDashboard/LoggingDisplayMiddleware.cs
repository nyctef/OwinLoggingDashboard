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
        private readonly InMemoryTraceListener m_Listener;

        public LoggingDisplayMiddleware(OwinMiddleware next, InMemoryTraceListener listener) : base(next)
        {
            m_Listener = listener;
        }

        public async override Task Invoke(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync(String.Join("\n", m_Listener.Messages));
            return;
        }
    }
}
