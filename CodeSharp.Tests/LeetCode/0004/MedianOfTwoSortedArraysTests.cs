using CSharpReference.LeetCode._0004;
using FluentAssertions;
using Xunit;

namespace CodeSharp.Tests.LeetCode._0004
{
    public class MedianOfTwoSortedArraysTests
    {
        [Theory]
        [InlineData(new[]{1,3}, new[]{2}, 2.0)]
        [InlineData(new[]{1,2}, new[]{3, 4}, 2.5)]
        [InlineData(new[]{1,2}, new[]{1, 2}, 1.5)]
        public void MustFindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            var sut = new MedianOfTwoSortedArrays();
            
            var result = sut.FindMedianSortedArrays(nums1, nums2);

            result.Should().Be(expected);
        } 
    }
}