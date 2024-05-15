using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            int number1 = 4;
            int number2 = 5;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {
            }
            else if (number3 == 16)
            {
            }
            */

           
           /*
           int[] numbers = new int[5];
           numbers[0] = 4;
           numbers[1] = 8;
           numbers[2] = 15;
           numbers[3] = 16;
           numbers[4] = 23;
           //numbers[5] = 42;

           Console.WriteLine(numbers[1]);
           Console.WriteLine(numbers.Length); //check number of items in the array
           Console.ReadLine();
           */


           //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
           string[] names = new string[] { "thapelo", "lebo", "joy", "KG" };

           /*
           for (int i = 0; i < names.Length; i++)
           {
               Console.WriteLine(names[i]);
           }
           Console.ReadLine();
           */

           /*
           foreach(string name in names)
           {
               Console.WriteLine(name);
           }
           Console.ReadLine();
           */

           string Thapelo = "Failure is normal but it should not be made a norm.";

            char[] charArray = Thapelo.ToCharArray();
            Array.Reverse(charArray); //  to reverse string Thapelo characters

            foreach (char Thapelochar in charArray)
            {
                Console.Write(Thapelochar);
            }
            Console.ReadLine();


        }
    }
}