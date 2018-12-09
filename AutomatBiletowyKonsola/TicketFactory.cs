using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public enum TicketTypes
    {
        [Description("One way ticket")]
        oneWay = 0,
        [Description("One hour ticket")]
        hourly = 1,
        [Description("Monthly ticket")]
        monthly = 2
    }
    public class TicketFactory
    {
        private static UserInterface UserInterface = new UserInterface();
        private static Parser Parser = new Parser();
        public Ticket CreateTicket(TicketTypes type)
        {
            Ticket ticketToReturn;
            switch (type)
            {
                case TicketTypes.oneWay:
                    string line = UserInterface.AskForLine();
                    ticketToReturn = new OneWayTicket(line);
                    break;
                case TicketTypes.hourly:
                    ticketToReturn = new HourTicket();
                    break;
                case TicketTypes.monthly:
                    string dateToParse = UserInterface.AskForStartDate();
                    var parsedDate = Parser.ParseDate(dateToParse);
                    ticketToReturn = new MonthlyTicket(parsedDate);
                    break;
                default:
                    ticketToReturn = new HourTicket();
                    break;
            }
            return ticketToReturn;
        }
    }
}
