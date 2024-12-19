using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0, num2 = 0, result = 0;

                Console.WriteLine("\t\t\t\t\t-------- CALCULATOR --------\n");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nSelect an option: ");

                Console.WriteLine("Add: +");
                Console.WriteLine("Subtract: -");
                Console.WriteLine("Multiply: *");
                Console.WriteLine("Divide: /");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"\nYour result is {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"\nYour result is {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"\nYour result is {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"\nYour result is {result}");
                        break;
                    default:
                        Console.WriteLine("This option is not valid.");
                        break;

                }
                Console.WriteLine("Do you want to continue ? (1 = Yes, 2 = No) ");
            } while (Console.ReadLine() == "1");

            Console.WriteLine("THE END");

        }
    }
}
