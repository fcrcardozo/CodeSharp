using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpReference.LeetCode._3._Longest_Substring_Without_Repeating_Characters
{
    public class LongestSubstringWithoutRepeatingCharacters: ICode
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longestValue = 0;
            var sub = string.Empty;
            var word = s;
            
            while (word.Length > 0 && sub.Length < word.Length)
            {
                foreach (var t in word)
                {
                    if (sub.Contains(t) && sub.Length != 0)
                    {
                        if (sub.Length > longestValue)
                        {
                            longestValue = sub.Length;
                        }                            
                        sub = string.Empty;
                    }

                    sub += t.ToString();
                }
                if (sub.Length > longestValue)
                {
                    longestValue = sub.Length;
                }                            
                sub = string.Empty;
                word = word.Substring(1);
            }

            return longestValue;
        }
        public void Execute()
        {
            Console.WriteLine(LengthOfLongestSubstring("aab"));
            Console.WriteLine(LengthOfLongestSubstring("au"));
            Console.WriteLine(LengthOfLongestSubstring(" "));
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(LengthOfLongestSubstring(""));
        }
    }
}