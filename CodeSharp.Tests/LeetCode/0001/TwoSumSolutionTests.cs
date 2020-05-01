using CSharpReference.LeetCode._0001;
using FluentAssertions;
using Xunit;

namespace CodeSharp.Tests.LeetCode._0001
{
    public class TwoSumSolutionTests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[]{ 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[]{ 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[]{ 0, 1 })]
        public void TwoSumBruteForce(int[] nums, int target, int[] mustBe)
        {
            //Given
            var twoSumSolution = new TwoSumSolution();

            //When
            var result = twoSumSolution.BruteForce(nums, target);

            //Then
            result.Should().HaveCount(2);
            result[0].Should().Be(mustBe[0]);
            result[1].Should().Be(mustBe[1]);
        }
        
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[]{ 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[]{ 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[]{ 0, 1 })]
        public void TwoSumHashMap(int[] nums, int target, int[] mustBe)
        {
            //Given
            var twoSumSolution = new TwoSumSolution();

            //When
            var result = twoSumSolution.HashMap(nums, target);

            //Then
            result.Should().HaveCount(2);
            result[0].Should().Be(mustBe[0]);
            result[1].Should().Be(mustBe[1]);
        }
    }
}