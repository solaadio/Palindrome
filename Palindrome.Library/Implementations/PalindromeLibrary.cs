﻿using System.Collections.Generic;
using System.Linq;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Models;

namespace Palindrome.Library.Implementations
{
    public class PalindromeLibrary : IPalindromeLibrary
    {
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
                    int currentPalindromeLength = forwardString.Length;
                    temporaryPalinDrome = new PalinDrome
                    {
                        Text = forwardString,
                        Length = currentPalindromeLength,
                        Index = i
                    };

                    // move search pointer forward to the end of newly found palindrome
                    //i = i + currentPalindromeLength - 1;

                    // exit the inner loop
                    //break;
                }
                if (temporaryPalinDrome != null)
                {
                    palindromeList.Add(temporaryPalinDrome);
                    i = i + temporaryPalinDrome.Length - 1;
                }
            }
            return palindromeList;
        }

        public IEnumerable<PalinDrome> FindLongestPalindromes(string inputString, int topNthLongest)
        {
            return FindPalindromeList(inputString).OrderByDescending(palindrome => palindrome.Length).Take(topNthLongest);
        }
    }
}
