using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class MonthlyTicket : Ticket
    {
        public DateTime StartDate { get; private set; }
        public MonthlyTicket(DateTime startDate) : base(88.0)
        {
            StartDate = startDate;
            LoggingMessage = string.Concat(base.LoggingMessage, $"Valid for a month starting from {StartDate}");
        }
    }
}
