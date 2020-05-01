using System.Collections.Generic;

namespace CSharpReference.LeetCode._0001
{
    public class TwoSumSolution
    {
        public int[] BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i != j && (nums[i] + nums[j]) == target)
                    {
                        return new[] { i, j };
                    }
                }

            return new int[] {0, 0};
        }
        
        public int[] HashMap(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new[] { map[complement], i };
                }
                map.TryAdd(nums[i], i);
            }

            return new int[] {0, 0};
        }
    }
}