using OwinLoggingDashboard;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string endpoint = "http://localhost:12345/";
            using (var dashboard = Dashboard.Start(endpoint))
            {
                Process.Start(endpoint);
                Console.ReadLine();
            }

        }
    }
}
