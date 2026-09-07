using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 4, 6, 8, 10 };

            int sum = 0;

            for(int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine ($"The Total sum of Array is :  {sum}");
        }
    }
}