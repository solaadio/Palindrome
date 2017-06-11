using System;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.App
{
    class Program
    {
        static void Main()
        {
            var str = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

             // str = "addcdxddf";

         //    str = "abcbcabbacba";

           // str = "stresseddesserts";

        //    str = "bananas";

          //  str = "abba";


            Console.WriteLine(str);

            IPalindromeLibrary library = new PalindromeLibrary();

            var longest = library.FindPalindromeList(str);

            foreach (var palinDrome in longest)
            {
                Console.WriteLine(palinDrome);
            }

            Console.WriteLine("\n\n\n\n");

            longest = library.FindLongestPalindromes(str, 3);

            foreach (var palinDrome in longest)
            {
                Console.WriteLine(palinDrome);
            }

            Console.ReadLine();



        }

     
    }

   
}
