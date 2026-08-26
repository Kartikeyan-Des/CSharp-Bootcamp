using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvenOdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            string? result;

            if (num % 2 == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }

            Console.WriteLine($"The number {num} is {result}.");
        }
    }
}