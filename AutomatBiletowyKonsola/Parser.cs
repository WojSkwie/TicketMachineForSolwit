using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public enum Commands
    {
        buyTicket = 1,
        exit = 0
    }

    public class Parser
    {
        private Logger Logger = Logger.Instance;
        private TicketFactory TicketFactory = new TicketFactory();
        private static UserInterface UserInterface = new UserInterface();

        public void ParseCommand(string command)
        {
            bool status = int.TryParse(command, out int commandNumber);
            if (!status)
            {
                return;
            }

            if(!Enum.IsDefined(typeof(Commands), commandNumber))
            {
                commandNumber = (int)Commands.buyTicket;
            }

            switch ((Commands)commandNumber)
            {
                case Commands.exit:
                    Environment.Exit(0);
                    break;
                case Commands.buyTicket:
                    string typeToParse = UserInterface.AskForTicketType();
                    TicketTypes type = ParseType(typeToParse);
                    Ticket ticket = TicketFactory.CreateTicket(type);
                    Logger.LogTicket(ticket);
                    break;
            }
        }

        public TicketTypes ParseType(string input)
        {
            if (!int.TryParse(input, out int ticketNumber))
            {
                ticketNumber = (int)TicketTypes.oneWay;
            }

            if(! Enum.IsDefined(typeof(TicketTypes), ticketNumber))
            {
                ticketNumber = (int)TicketTypes.oneWay;
            }

            TicketTypes desiredType = (TicketTypes)ticketNumber;
            return desiredType;
        }
    }
}
