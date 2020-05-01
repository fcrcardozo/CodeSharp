using CSharpReference.LeetCode._1108;
using FluentAssertions;
using Xunit;

namespace CodeSharp.Tests.LeetCode._1108
{
    public class DefangingAnIpAddressTests
    {
        [Theory]
        [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
        [InlineData("255.100.50.0", "255[.]100[.]50[.]0")]
        public void GivenAValidIPv4IpAddressMustReturnADefangedVersionOfThatIpAddress(string input, string output)
        {
            //Given
            var defagingAnIpAddress = new DefangingAnIpAddress();
            
            //When
            var result = defagingAnIpAddress.DefangIPaddr(input);

            //Then
            result.Should().Be(output);
        }
    }
}