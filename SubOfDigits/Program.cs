using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("---Welcome to the Program---");
            Console.WriteLine("----------------------------");

            Console.Write("Please enter number 1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter number 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            if (num1!=0 && num1!=0)
            {
                int total = num1 - num2;
                Console.WriteLine("Total number is "+ total);
                Console.ReadKey();
            }
            else
            {
                Console.Write("You have entered both 0 value in numbers.");
                Console.ReadKey();
            }
            Console.WriteLine("-----Thank you----");
            Console.WriteLine("--Kushal Neupane--");
        }
    }
}
