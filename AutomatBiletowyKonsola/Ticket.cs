using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public abstract class Ticket
    {
        public string Name { get; protected set; }
        protected double _Price;
        public virtual double Price
        {
            get
            {
                return _Price;
            }
            protected set
            {
                _Price = value;
            }
        }
        private DateTime _BoughtAt;
        public string LoggingMessage { get; protected set; }

        public DateTime BoughtAt
        {
            get { return _BoughtAt; }
            private set { _BoughtAt = value; }
        }

        protected Ticket(double price)
        {
            BoughtAt = DateTime.Now;
            Price = price;
            LoggingMessage = $"Ticket {Name} Bought at {BoughtAt}. ";
        }
    }
}

