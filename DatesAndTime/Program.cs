﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    { 
        static void Main(string[] args) 
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
                Console.ReadLine();
        }
    }
}