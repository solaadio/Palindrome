using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.Tests
{
    [TestClass]
    public class ProvidedSamplesTests
    {
        [TestMethod]
        public void Test_01_VerifyThatProvidedSampleReturnsProvidedOutput()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            const int longest3 = 3;


            // Act
            var longest3Palindromes = library.FindLongestPalindromes(sampleString, longest3).ToList();


            // Assert
            Assert.AreEqual(3, longest3Palindromes.Count);

            Assert.AreEqual("hijkllkjih", longest3Palindromes[0].Text);
            Assert.AreEqual(23, longest3Palindromes[0].Index);
            Assert.AreEqual(10, longest3Palindromes[0].Length);


            Assert.AreEqual("defggfed", longest3Palindromes[1].Text);
            Assert.AreEqual(13, longest3Palindromes[1].Index);
            Assert.AreEqual(8, longest3Palindromes[1].Length);


            Assert.AreEqual("abccba", longest3Palindromes[2].Text);
            Assert.AreEqual(5, longest3Palindromes[2].Index);
            Assert.AreEqual(6, longest3Palindromes[2].Length);

        }

        [TestMethod]
        public void Test_02_VerifyThatProvidedSampleReturnsSixPalindromes()
        {

            // Arrange
            IPalindromeLibrary library = new PalindromeLibrary();
            var sampleString = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";


            // Act
            var allPalinDromes = library.FindPalindromeList(sampleString).ToArray();
            foreach (var palinDrome in allPalinDromes)
            {
                Console.WriteLine(palinDrome);
            }



            // Assert
            Assert.AreEqual(6, allPalinDromes.Length);

        }
    }
}
