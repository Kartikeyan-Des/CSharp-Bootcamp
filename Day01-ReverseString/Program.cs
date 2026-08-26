using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");

            string? input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}