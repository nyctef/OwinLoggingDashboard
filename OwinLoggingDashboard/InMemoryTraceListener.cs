using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinLoggingDashboard
{
    class InMemoryTraceListener : TraceListener
    {
        private readonly List<string> m_Messages = new List<string>();
        private string m_CurrentMessage = "";

        public IEnumerable<string> Messages { get { return m_Messages; } }

        public override void Write(string message)
        {
            m_CurrentMessage += message;
        }

        public override void WriteLine(string message)
        {
            m_Messages.Add(m_CurrentMessage + message);
        }
    }
}
