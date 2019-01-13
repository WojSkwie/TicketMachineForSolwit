using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public class Authentication
    {
        private const string SavedUser = "John";
        private const string SavedPassword = "Gret";
        public bool Authenticate(string user, string password)
        {
            if(user == SavedUser)
            {
                if(password == string.Empty || password == SavedPassword)
                {
                    return true;
                }
            }
            Console.WriteLine("Incorrect password or username");
            return false;
        }
    }
}
