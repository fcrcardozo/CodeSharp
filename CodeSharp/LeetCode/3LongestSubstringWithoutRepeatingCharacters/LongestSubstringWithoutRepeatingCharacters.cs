using System;
using System.Collections.Generic;

namespace CSharpReference.LeetCode._3LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharacters: ICode
    {
        public int LengthOfLongestSubstringBruteForceSlow(string s)
        {
            var longestValue = 0;
            var length = s.Length;
            
            if (length == 0)
                return 0;

            for (var startIndex = 0; startIndex < length; startIndex++)
            {
                for (var endIndex = startIndex + 1; endIndex <= length; endIndex++)
                {
                    if (AllUnique(s, startIndex, endIndex))
                    {
                        longestValue = Math.Max(longestValue, endIndex - startIndex);
                    };
                } 
            }

            return longestValue;
        }
        public int LengthOfLongestSubstringBruteForceMedium(string s)
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
        
        public int LengthOfLongestSubstringSlidingWindow(string s)
        {
            var longestValue = 0;
            var subs = new List<char>();
            foreach (var c in s)
            {
                if (subs.Contains(c))
                {
                    // subs = subs.Skip(subs.FindIndex(x => x == c) + 1).ToList(); slow :x
                    subs.RemoveRange(0, subs.FindIndex(x => x == c) + 1);
                }
                subs.Add(c);
                longestValue = Math.Max(longestValue, subs.Count);
            }

            return longestValue;
        }

        private static bool AllUnique(string characters, int start, int end)
        {
            var subs = new HashSet<char>();
            for (var i = start; i < end; i++)
            {
                var t = characters[i];
                if (subs.Contains(t))
                {
                    return false;
                }
                subs.Add(t);
            }

            return true;
        }
        private static void SetLogestValue(ref List<char> sub, ref int longestValue)
        {
            if (sub.Count > longestValue)
            {
                longestValue = sub.Count;
            }

            sub = new List<char>();
        }

        public int LengthOfLongestSubstringSlidingWindowOptimized(string s)
        {
            int ans = 0;
            int start = 0; 

            IDictionary<char, int> map = new Dictionary<char, int>();

            for (int j = 0; j < s.Length; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    if (map[s[j]] >= start)
                    {
                        start = map[s[j]];
                    }
                }

                ans = Math.Max(ans, j - start + 1);
                map[s[j]] = j + 1;
            }

            return ans;
        }

        public int LengthOfLongestSubstringSlidingWindowOptimizedASCII(string s)
        {
            int longestValue = 0, end = 0, start = 0;
            var characters = new int[128];
            var length = s.Length;

            for (; end < length; end++)
            {
                start = Math.Max(characters[s[end]], start);
                longestValue = Math.Max(longestValue, end - start + 1);
                characters[s[end]] = end + 1;
            }

            return longestValue;
        }

        public void Execute()
        {
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow("aab"));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow("au"));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow(" "));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow("pwwkew"));
            Console.WriteLine(LengthOfLongestSubstringSlidingWindow(""));
        }
    }
}