using System.Collections.Generic;
using Palindrome.Library.Models;

namespace Palindrome.Library.Abstractions
{
    public interface IPalindromeLibrary
    {
        IEnumerable<PalinDrome> FindPalindromeList(string inputString);

        IEnumerable<PalinDrome> FindLongestPalindromes(string inputString, int topNthLongest);

    }
}
