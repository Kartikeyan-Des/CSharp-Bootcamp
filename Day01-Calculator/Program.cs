using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            string? operation = Console.ReadLine();

            Console.WriteLine("Enter number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if(operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*"){
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error!...  Invalid Operation");
                return;
            }
            Console.WriteLine($"The Operation result is : {result}");
        }
    }
}