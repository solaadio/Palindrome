﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.Tests.UnitTests.LongestEnglishPalindrome
{
    [TestClass]
    public class LongestEnglishWordPalindrome
    {
        [TestMethod]
        public void Test_01_verify_that_tattarrattat_Returns_tattarrattat()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "tattarrattat";
            const int longest3 = 1;


            // Act
            var longest3Palindromes = library.FindNthLongestPalindromes(sampleString, longest3).ToList();
            foreach (var palinDrome in longest3Palindromes)
            {
                Console.WriteLine(palinDrome);
            }


            // Assert
            Assert.AreEqual(1, longest3Palindromes.Count);

            Assert.AreEqual("tattarrattat", longest3Palindromes[0].Text);
            Assert.AreEqual(0, longest3Palindromes[0].Index);
            Assert.AreEqual(12, longest3Palindromes[0].Length);



        }

        [TestMethod]
        public void Test_02_verify_that_tattarrattat_returns_one_plaindrome()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "tattarrattat";


            // Act
            var allPalinDromes = library.FindPalindromeList(sampleString).ToArray();
            foreach (var palinDrome in allPalinDromes)
            {
                Console.WriteLine(palinDrome);
            }



            // Assert
            Assert.AreEqual(1, allPalinDromes.Length);

        }
    }
}
