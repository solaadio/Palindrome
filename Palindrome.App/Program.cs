using System;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.App
{
    internal class Program
    {
        private static void Main()
        {
            var sampleString = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            Console.WriteLine($"Sample String: {sampleString}");

            IPalindromeLibrary library = new PalindromeLibrary();
            var longest = library.FindNthLongestPalindromes(sampleString, 3);

            Console.WriteLine("\n\n");
            foreach (var palinDrome in longest)
            {
                Console.WriteLine(palinDrome);
            }

            Console.WriteLine("\n\nPress Enter to EXIT");
            Console.ReadLine();
        }
     
    }
}
