using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.Tests.UnitTests.SpecialCases
{
    [TestClass]
    public class SpecialCasesTest
    {
        [TestMethod]
        public void Test_01_verify_that_abcdefg_Returns_no_palindrome()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "abcdefg";
            const int longest3 = 1;


            // Act
            var longest3Palindromes = library.FindNthLongestPalindromes(sampleString, longest3).ToList();
            foreach (var palinDrome in longest3Palindromes)
            {
                Console.WriteLine(palinDrome);
            }


            // Assert
            Assert.AreEqual(0, longest3Palindromes.Count);


        }

        [TestMethod]
        public void Test_02_verify_that_empty_string_Returns_no_palindrome()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "";
            const int longest3 = 1;


            // Act
            var longest3Palindromes = library.FindNthLongestPalindromes(sampleString, longest3).ToList();
            foreach (var palinDrome in longest3Palindromes)
            {
                Console.WriteLine(palinDrome);
            }


            // Assert
            Assert.AreEqual(0, longest3Palindromes.Count);


        }

        [TestMethod]
        public void Test_03_verify_that_spaces_string_Returns_one_palindrome()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "        ";
            const int longest3 = 1;


            // Act
            var longest3Palindromes = library.FindNthLongestPalindromes(sampleString, longest3).ToList();
            foreach (var palinDrome in longest3Palindromes)
            {
                Console.WriteLine(palinDrome);
            }


            // Assert
            Assert.AreEqual(1, longest3Palindromes.Count);


        }

    }
}
