using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to open this program?\nType Yes for run.");
            string input = Console.ReadLine();
            while (input=="Yes")
            {
                Console.Write("Enter first digit: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second digit: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("\n");

                if (num1 == 0 || num2 == 0)
                {
                    if (num1 != 0 && num2 != 0)
                    {
                        Console.WriteLine("You have insert 0 on both numbers.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You have insert zero.\nSo, you will get output as 0.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    int total = num1 * num2;
                    Console.WriteLine("Total number is " + total);
                    Console.ReadKey();
                }
            }
        }
    }
}
