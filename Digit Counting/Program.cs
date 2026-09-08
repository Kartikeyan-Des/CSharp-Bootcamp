using System;
using System.Collections.Generic;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to find no of digits it hold");
            int num =Convert.ToInt32(Console.ReadLine());

            int digits = 0;


            while(num > 0)
            {
                num = num / 10;

                digits++;   
            }

            Console.WriteLine($"The Digit for is : {digits}");
        }
    }
}