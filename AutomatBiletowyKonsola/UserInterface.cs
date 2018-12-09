using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class UserInterface
    {
        private static Parser Parser = new Parser();

        public object Enumerations { get; private set; }

        public void PrintGreetings()
        {
            Console.WriteLine("#############");
            Console.WriteLine($"Hello there!");
            Console.WriteLine("#############");
            Task.Delay(500);
        }

        public void MainLoop()
        {
            while(true)
            {
                Console.Clear();
                string input = AskForAction();
                
                Parser.ParseCommand(input);
            }
            
        }

        public string AskForTicketType()
        {
            Console.WriteLine("Choose type of ticket:");
            foreach(TicketTypes ticketType in Enum.GetValues(typeof(TicketTypes)))
            {
                Console.WriteLine($"{(int)ticketType} - {Utils.GetDescription(ticketType)}");
            }
            return Console.ReadLine();
        }

        public string AskForAction()
        {
            Console.WriteLine("Choose desired action:");
            foreach (Commands action in Enum.GetValues(typeof(Commands)))
            {
                Console.WriteLine($"{(int)action} - {Utils.GetDescription(action)}");
            }
            return Console.ReadLine();
        }

        public string AskForLine()
        {
            Console.WriteLine("Please enter line number.");
            return Console.ReadLine();
        }

        public string AskForDiscount()
        {
            throw new NotImplementedException();
        }
        

    }
}
