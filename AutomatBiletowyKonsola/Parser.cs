using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public enum Commands
    {
        [Description("Buy ticket")]
        buyTicket = 1,
        [Description("Exit Program")]
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

                    string discountToParse = UserInterface.AskForDiscount();
                    Discounts desiredDiscount = ParseDiscount(discountToParse);
                    var discountDecorator = new DiscountDecorator(ticket, desiredDiscount);

                    Logger.LogTicket(discountDecorator);
                    UserInterface.PrintingPrompt();
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
        public DateTime ParseDate(string input)
        {
            if (!DateTime.TryParse(input, out DateTime parsedDate)) 
            {
                parsedDate = new DateTime();
            }
            return parsedDate;

        }

        public Discounts ParseDiscount(string input)
        {
            if (!int.TryParse(input, out int discountNumber))
            {
                discountNumber = (int)Discounts.student;
            }

            if (!Enum.IsDefined(typeof(TicketTypes), discountNumber))
            {
                discountNumber = (int)Discounts.student;
            }

            Discounts desiredType = (Discounts)discountNumber;
            return desiredType;
        }
    }
}
