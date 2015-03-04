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

        public IEnumerable<string> Messages { get { return m_Messages; } }

        public override void Write(string message)
        {
            if (!m_Messages.Any()) m_Messages.Add("");
            m_Messages[m_Messages.Count - 1] += message;
        }

        public override void WriteLine(string message)
        {
            m_Messages.Add(message);
        }
    }
}
