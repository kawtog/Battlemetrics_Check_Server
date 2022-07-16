using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlemetrics_Check_Server.Property
{
    public class Report_BackgroundWorker
    {
        public string Event { get; set; }
        public string Message { get; set; }
        public string IP_Address { get; set; }
        public string Value { get; set; }
        public string Error { get; set; }
        public Server_Info server_Info { get; set; }
    }
}
