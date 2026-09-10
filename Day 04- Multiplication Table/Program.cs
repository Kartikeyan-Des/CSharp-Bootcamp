using System;
using System.Collections.Generic;


namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Multiplication Table");
            int num = Convert.ToInt32(Console.ReadLine());

            

            for(int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");
            }
            
        }
    }
}