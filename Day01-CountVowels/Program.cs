using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string? userInput = Console.ReadLine();
            string? LowercaseInput = userInput?.ToLower();

            int vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };    

            for (int i = 0;i < LowercaseInput.Length; i++)
            {
                if (vowels.Contains(LowercaseInput[i]))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"The number of vowels in the string is: {vowelCount} in the word : {LowercaseInput}");

        }
    }
}