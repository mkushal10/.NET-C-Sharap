using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1 p1 = new Program1();
            p1.Method();
        }
    }
    class Program1
    {
        public void Method()
        {
            Console.Write("Please enter number 1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter number 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("You have 0.");
                Console.Read();
            }
            else
            {
                int result = num1 / num2;
                Console.WriteLine("Total is " + result);
                Console.Read();
            }
        }
    }
}