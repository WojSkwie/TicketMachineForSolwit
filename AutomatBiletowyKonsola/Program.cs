using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatBiletowyKonsola
{
    class Program
    {
        //private UserInterface UserInterface;

        static void Main(string[] args)
        {
            var UserInterface = new UserInterface();
            UserInterface.PrintGreetings();
            if (args.Count() == 0)
            {
                Console.WriteLine("podaj");
            }
            Console.ReadLine();

        }
    }
}
