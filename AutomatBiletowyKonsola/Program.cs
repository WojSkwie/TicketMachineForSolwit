using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    class Program
    {
        private const int CorrectArgsCount = 4;
        private const int QuasiCorrectArgsCount = 3;
        static void Main(string[] args)
        {
            var UserInterface = new UserInterface();
            var Authentication = new Authentication();
            UserInterface.PrintGreetings();
            bool authStatus = false;
            while(!authStatus)
            {
                UserInterface.AskForAuthentication(out string username, out string password);
                authStatus = Authentication.Authenticate(username, password);
                Console.Clear();
            }
            
            UserInterface.MainLoop();

        }
    }
}
