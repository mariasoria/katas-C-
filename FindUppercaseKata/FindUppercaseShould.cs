using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace FindUppercaseKata
{
    public class FindUppercaseShould
    {
        [Fact]
        public void FindWhereTheUppercaseIs()
        {
            FindUppercase.Execute("Hello").Should().BeEquivalentTo(new List<int>() { 0 });
            FindUppercase.Execute("Hello World").Should().BeEquivalentTo(new List<int>() { 0, 6 });
            FindUppercase.Execute("CodEWaRs").Should().BeEquivalentTo(new List<int>() { 0, 3, 4, 6 });
            FindUppercase.Execute("Hello my friend, Hello World")
                .Should().BeEquivalentTo(new List<int>() { 0, 17, 23 });
        }
    }
}