using CSharpReference.LeetCode._0226;
using FluentAssertions;
using FluentAssertions.Common;
using Xunit;

namespace CodeSharp.Tests.LeetCode._0226
{
    public class InvertBinaryTreeTests
    {
        [Fact]
        public void Invert_a_binary_tree()
        {
            //Given
            var invertBinaryTree = new InvertBinaryTree();

            
            
            var tree3 = new TreeNode(1);
            var tree4 = new TreeNode(3);
            var tree5 = new TreeNode(6);
            var tree6 = new TreeNode(9);
            
            var tree1 = new TreeNode(2, tree3, tree4);
            var tree2 = new TreeNode(7, tree5, tree6);
            
            var rootTree = new TreeNode(4, tree1, tree2);

            //When
            var result = invertBinaryTree.InvertTree(rootTree);

            //Then
            result.left.val.Should().Be(7);
            result.right.val.Should().Be(2);

            result.left.left.val.Should().Be(9);
            result.left.right.val.Should().Be(6);
            result.right.left.val.Should().Be(3);
            result.right.right.val.Should().Be(1);
        }
    }
}