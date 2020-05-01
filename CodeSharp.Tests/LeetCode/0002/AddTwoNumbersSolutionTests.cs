using System.Collections.Generic;
using CSharpReference.LeetCode._0002;
using FluentAssertions;
using Xunit;

namespace CodeSharp.Tests.LeetCode._0002
{
    public class AddTwoNumbersSolutionTests
    {
        [Theory]
        [InlineData(new[]{2,4,3}, new[]{5,6,4}, "708")]
        [InlineData(new[]{1,8}, new[]{0}, "18")]
        [InlineData(new[]{9, 8}, new[]{1}, "09")]
        [InlineData(new[]{0,8,6,5,6,8,3,5,7}, new[]{6,7,8,0,8,5,8,9,7}, "6556442551")]
        [InlineData(new[]{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1}, new[]{5,6,4}, "6640000000000000000000000000001")]
        public void AddTwoNumbers(int[] n1, int[] n2, string mustBe)
        {
            
            
            var addTwoNumbers = new AddTwoNumbersSolution();

            var l1 = AddTwoNumbersSolution.CreateListNodes(n1);
            var l2 = AddTwoNumbersSolution.CreateListNodes(n2);

            var lResult = addTwoNumbers.AddTwoNumbers(l1, l2);


            var result = AddTwoNumbersSolution.GetAllNumbersListNode(lResult, new List<int>());
            result.Should().Be(mustBe);
        }
    }
}