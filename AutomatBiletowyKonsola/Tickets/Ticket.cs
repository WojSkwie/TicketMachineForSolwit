using System;

namespace TicketMachineConsole
{
    public abstract class Ticket
    {
        private Random Random = new Random();
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
            BoughtAt = DateTime.Now.AddDays(Random.Next(100, 1000));
            Price = price;
            LoggingMessage = $"Ticket {Name} Bought at {BoughtAt}. ";
        }
    }
}

