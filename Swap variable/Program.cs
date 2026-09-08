using System;
using System.Collections.Generic;


namespace swapVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            a = a + b;

            b = a - b;

            a = a - b;

            
            Console.WriteLine($"val of a: {a}");
            Console.WriteLine($"val of b: {b}");
        }
    }
}