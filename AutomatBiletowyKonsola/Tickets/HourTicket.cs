using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class HourTicket : Ticket
    {
        public TimeSpan ValidUntil { get; private set; }

        public HourTicket() : base(3.5)
        {
            ValidUntil = new TimeSpan(1, 0, 0);
            LoggingMessage = string.Concat(base.LoggingMessage, $"Valid for {ValidUntil}.");
        }
    }
}
