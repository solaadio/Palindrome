using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.Tests.UnitTests.OnePalindromeSample
{
    [TestClass]
    public class OnePalindromeSampleTests
    {
        [TestMethod]
        public void Test_01_verify_that_bananas_Returns_anana()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "bananas";
            const int longest3 = 3;


            // Act
            var longest3Palindromes = library.FindNthLongestPalindromes(sampleString, longest3).ToList();
            foreach (var palinDrome in longest3Palindromes)
            {
                Console.WriteLine(palinDrome);
            }


            // Assert
            Assert.AreEqual(1, longest3Palindromes.Count);

            Assert.AreEqual("anana", longest3Palindromes[0].Text);
            Assert.AreEqual(1, longest3Palindromes[0].Index);
            Assert.AreEqual(5, longest3Palindromes[0].Length);

            

        }

        [TestMethod]
        public void Test_02_verify_that_banana_returns_one_plaindrome()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "bananas";


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
