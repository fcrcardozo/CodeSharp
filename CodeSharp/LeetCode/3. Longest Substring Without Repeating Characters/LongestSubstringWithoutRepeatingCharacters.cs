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
            var word = s;
            var subs = new List<char>();
            var count = 1;
            
            while (count <= s.Length && subs.Count < word.Length)
            {
                foreach (var t in word)
                {
                    if (subs.Contains(t) && subs.Count != 0)
                    {
                        SetLogestValue(ref subs, ref longestValue);
                    }
                    subs.Add(t);
                }
                SetLogestValue(ref subs, ref longestValue);
                word = s.Substring(count);
                count++;
            }

            return longestValue;
        }

        private static void SetLogestValue(ref List<char> sub, ref int longestValue)
        {
            if (sub.Count > longestValue)
            {
                longestValue = sub.Count;
            }

            sub = new List<char>();
        }

        public int faster(string input)
        {
            int length = input.Length, ans = 0;
            int start = 0; // i

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int j = 0; j < length; j++)
            {
                if(map.ContainsKey(input[j]))
                {
                    if(map[input[j]] >= start)
                    {
                        start = map[input[j]];
                    }
                }
                               
                ans = Math.Max(ans, j - start +1 );
                map[input[j]] = j+1;
            }
            return ans;
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