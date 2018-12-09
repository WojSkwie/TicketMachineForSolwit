using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class UserInterface
    {
        private Parser Parser = new Parser();

        public void PrintGreetings()
        {
            Console.WriteLine("#############");
            Console.WriteLine($"Hello there!");
            Console.WriteLine("#############");
        }

        public void AskForAction()
        {
            while(true)
            {
                Console.WriteLine("Choose action:");
                string input = Console.ReadLine();
                Parser.ParseCommand(input);
            }
            
        }
    }
}
