using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinLoggingDashboard
{
    public class Dashboard : IDisposable
    {
        private readonly IDisposable m_WebApp;

        public Dashboard(IDisposable webApp)
        {
            m_WebApp = webApp;
        }

        public static Dashboard Start(string binding = "http://localhost:12345")
        {
            return new Dashboard(WebApp.Start<Startup>(binding));
        }

        public void Dispose()
        {
            m_WebApp.Dispose();
        }

        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                app.UseErrorPage();
                app.UseWelcomePage("/");
            }
        }
    }
}
