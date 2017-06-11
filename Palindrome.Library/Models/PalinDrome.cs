﻿namespace Palindrome.Library.Models
{
   public class PalinDrome
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"Text: {Text}, Index: {Index}, Length: {Length}";
        }

    
    }
}
