using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class OneWayTicket : Ticket
    {
        public string Line { get; set; }

        public OneWayTicket(string line) : base(3.0)
        {
            Line = line;
            LoggingMessage = string.Concat(base.LoggingMessage, $"Line {Line}.");
        }
    }
}
