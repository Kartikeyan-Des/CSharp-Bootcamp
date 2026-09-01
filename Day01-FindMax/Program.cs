using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 7, 3, 12, 9 };
            int max = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                //Console.WriteLine(num[i]);
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine("The maximum number is: " + max);
        }
    }
}