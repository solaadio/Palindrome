using System;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.App
{
    class Program
    {
        static void Main()
        {
            var sampleString = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

             // str = "addcdxddf";

         //    str = "abcbcabbacba";

           // str = "stresseddesserts";

        //    str = "bananas";

          //  str = "abba";

            sampleString = "abracadabra";

            sampleString = "HYTBCABADEFGHABCDEDCBAGHTFYW1234567887654321ZWETYGDE";

            sampleString = "abcccdeed";


            sampleString = "abaaaa";


            Console.WriteLine(sampleString);

            IPalindromeLibrary library = new PalindromeLibrary();

            var longest = library.FindPalindromeList(sampleString);

            foreach (var palinDrome in longest)
            {
                Console.WriteLine(palinDrome);
            }

            Console.WriteLine("\n\n\n\n");

            longest = library.FindLongestPalindromes(sampleString, 3);

            foreach (var palinDrome in longest)
            {
                Console.WriteLine(palinDrome);
            }

            Console.ReadLine();



        }

     
    }

   
}
