using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number Factorial :  ");
            int num = Convert.ToInt32(Console.ReadLine());

            long fact = 1;

            while(num > 1)
            {
                fact = fact * num;
                num--;  
            }

            Console.WriteLine("Factorial is : " + fact);


        }
    }
}