using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace PrimFactorsKata
{
    public class PrimeFactorsShould
    {
        [Fact]
        public void return_an_empty_list_if_it_has_no_primer_factors()
        {
            PrimeFactors.generate(1).Should().BeEmpty();
        }

        [Fact]
        public void return_the_input_number_if_it_has_only_one_prime_factor()
        {
            PrimeFactors.generate(2).Should().BeEquivalentTo(new List<int> { 2 });
            PrimeFactors.generate(3).Should().BeEquivalentTo(new List<int> { 3 });
        }

        [Fact]
        public void return_the_same_prime_factors_of_an_input_number()
        {
            PrimeFactors.generate(4).Should().BeEquivalentTo(new List<int> { 2, 2 });
            PrimeFactors.generate(8).Should().BeEquivalentTo(new List<int> { 2, 2, 2 });
            PrimeFactors.generate(9).Should().BeEquivalentTo(new List<int> { 3, 3 });
            PrimeFactors.generate(27).Should().BeEquivalentTo(new List<int> { 3, 3, 3 });
        }

        [Fact]
        public void find_different_prime_factors_of_an_input_number()
        {
            PrimeFactors.generate(6).Should().BeEquivalentTo(new List<int> { 2, 3 });
            PrimeFactors.generate(12).Should().BeEquivalentTo(new List<int> { 2, 2, 3 });
        }
    }
}