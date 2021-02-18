using System;
using System.Linq;

namespace CSharpReference.LeetCode._0004
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = nums1.Union(nums2).OrderBy(x => x).ToArray();
            var index = (int) Math.Floor(result.Count() / 2.0) - 1;
            

            if (result.Count() % 2 == 1)
            {
                return result[index + 1];
            }

            var a = result[index];
            var b = result[index + 1];

            return (a + b) / 2.0;
        } 
    }
}