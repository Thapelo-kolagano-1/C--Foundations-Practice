using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions

{
    class Program
    {
        static void Main(string[] args)
            
        {
            /*
            Console.WriteLine(" Thapelo's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            String userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "you won a new car!";
                Console.WriteLine(message);

            }
            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);


            }

            else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);


            }

            else
            {
                string message = "Sorry, we ddint understand.";
                //message += "You loose.";
                Console.WriteLine(message);
            }

            Console.ReadLine();

            */

            Console.WriteLine(" Thapelo's Big Giveaway");
             Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";

            // Console.Write("You won a ");
            // Console.Write(message);
            // Console.Write(".");

            Console.WriteLine("You won a {0}.", message);
            Console.ReadLine();
          

    }
    }

}