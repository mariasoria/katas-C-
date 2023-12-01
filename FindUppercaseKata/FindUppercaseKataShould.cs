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
            KataFindUppercase.Execute("Hello").Should().BeEquivalentTo(new List<int>() { 0 });
            KataFindUppercase.Execute("Hello World").Should().BeEquivalentTo(new List<int>() { 0, 6 });
            KataFindUppercase.Execute("Hello my friend, Hello World").Should().BeEquivalentTo(new List<int>() { 0, 17, 23 });
            KataFindUppercase.Execute("CodEWaRs").Should().BeEquivalentTo(new List<int>() { 0, 3, 4, 6 });
        }
    }
}