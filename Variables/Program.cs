﻿using System;
using System.Collections.Generic;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);


            Console.ReadLine();
            */

            Console.WriteLine("what is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //ing myLastName;
            //onsole.Write("Type your Last name: ");
            //yLastName = Console.ReadLine();

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();


            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
             Console.ReadLine();
            


        }
    }

}