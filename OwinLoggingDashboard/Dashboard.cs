using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Diagnostics;

namespace OwinLoggingDashboard
{
    public class Dashboard : IDisposable
    {
        private readonly TraceListener m_Listener;
        private readonly IDisposable m_WebApp;

        public Dashboard(TraceListener listener, IDisposable webApp)
        {
            m_Listener = listener;
            m_WebApp = webApp;
        }

        public static Dashboard Start(string binding = "http://localhost:12345")
        {
            var listener = new InMemoryTraceListener();
            Trace.Listeners.Add(listener);
            var webapp = WebApp.Start(binding, app =>
               {
                   app.UseErrorPage();
                   app.Use(typeof(LoggingDisplayMiddleware), listener);
                   app.UseWelcomePage("/");
               });
            Trace.TraceInformation("Dashboard started at " + binding);
            return new Dashboard(listener, webapp);
        }

        public void Dispose()
        {
            Trace.Listeners.Remove(m_Listener);
            m_WebApp.Dispose();
        }
    }
}
