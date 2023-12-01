using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace FindUppercaseKata
{
    public class FindUppercaseKataShould
    {
        [Fact]
        public void FindWhereTheUppercaseIs()
        {
            FindUppercaseKata.Execute("Hello").Should().BeEquivalentTo(new List<int>() { 0 });
            FindUppercaseKata.Execute("Hello World").Should().BeEquivalentTo(new List<int>() { 0, 6 });
            FindUppercaseKata.Execute("CodEWaRs").Should().BeEquivalentTo(new List<int>() { 0, 3, 4, 6 });
            FindUppercaseKata.Execute("Hello my friend, Hello World")
                .Should().BeEquivalentTo(new List<int>() { 0, 17, 23 });
        }
    }
}