using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String for Palindrome Check");
            string? str1 = Console.ReadLine();

            int left = 0;
            int right = str1.Length - 1;
            bool Palindrome = true;

            while (left < right)
            {
                if (str1[left] != str1[right])
                {
                    Palindrome = false;
                    break;
                }
                left = left + 1;
                right = right - 1;
            }
             if (Palindrome == true)
            {
                Console.WriteLine($"{str1} is a Plaindrome!");
            }
            else
            {
                Console.WriteLine($"{str1} is not a Palindrome");
            }

        }
    }
}