using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserInterface = new UserInterface();
            UserInterface.PrintGreetings();
            UserInterface.AskForAction();

        }
    }
}
