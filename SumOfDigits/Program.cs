using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            if (n1!=0 && n2!=0)
            {
                int total = n1 + n2;
                Console.WriteLine("Total of two numbers is " + total);
                Console.ReadKey();
            }
            else
            {
                Console.Write("You entered both 0 value.");
                Console.Read();
            }
        }
    }
}
