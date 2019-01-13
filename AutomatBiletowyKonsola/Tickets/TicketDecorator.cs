using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public abstract class TicketDecorator : Ticket
    {
        protected Ticket Ticket;

        protected TicketDecorator(Ticket ticket) : base(ticket.Price)
        {
            this.Ticket = ticket;
        }
    }
}
