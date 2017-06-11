using System.Collections.Generic;
using Palindrome.Library.Models;

namespace Palindrome.Library.Abstractions
{
    public interface IPalindromeLibrary
    {
        IEnumerable<PalinDrome> FindPalindromeList(string inputString);

        IEnumerable<PalinDrome> FindNthLongestPalindromes(string inputString, int topNthLongest);

    }
}
