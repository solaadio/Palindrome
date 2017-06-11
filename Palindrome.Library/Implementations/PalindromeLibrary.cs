using System.Collections.Generic;
using System.Linq;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Models;

namespace Palindrome.Library.Implementations
{
    public class PalindromeLibrary : IPalindromeLibrary
    {
        /// <summary>
        /// FindPalindromeList
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public IEnumerable<PalinDrome> FindPalindromeList(string inputString)
        {
            List<PalinDrome> palindromeList = new List<PalinDrome>();
            const int minimumPalindromeLength = 2;


            for (int i = 0; i < inputString.Length ; i++)
            {
                PalinDrome temporaryPalinDrome = null;
                for (int j = i + minimumPalindromeLength; j <= inputString.Length; j++)
                {
                    string forwardString = inputString.Substring(i, j - i);
                    string reverseString = new string(forwardString.Reverse().ToArray());

                    if (forwardString != reverseString)
                        continue;

                    // we found a palindrome!!!!!
                    temporaryPalinDrome = new PalinDrome
                    {
                        Text = forwardString,
                        Length = forwardString.Length,
                        Index = i
                    };

                }
                if (temporaryPalinDrome != null)
                {
                    palindromeList.Add(temporaryPalinDrome);
                    i = i + temporaryPalinDrome.Length - 1;
                }
            }
            return palindromeList;
        }

        /// <summary>
        /// FindNthLongestPalindromes
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="topNthLongest"></param>
        /// <returns></returns>
        public IEnumerable<PalinDrome> FindNthLongestPalindromes(string inputString, int topNthLongest)
        {
            return FindPalindromeList(inputString).OrderByDescending(palindrome => palindrome.Length).Take(topNthLongest);
        }
    }
}
