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
            var values = new List<int>();
            var sub = string.Empty;
            var word = s;
            var subStringCases = new List<string>();
            
            while (word.Length > 0)
            {
                subStringCases.Add(word);
                word = word.Substring(1);
            }

            Parallel.ForEach(subStringCases, subString =>
            {
                foreach (var t in subString)
                {
                    if (sub.Contains(t) && sub.Length != 0)
                    {
                        values.Add(sub.Length);
                        sub = string.Empty;
                    }

                    sub += t.ToString();
                }
                values.Add(sub.Length);
                sub = string.Empty;
            });

            return values.Any() ? values.Max() : 0;
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