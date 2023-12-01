using FluentAssertions;
using Xunit;

namespace PasswordValidator.test
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void ValidateThatPasswordIsStrongEnough()
        {
            PasswordValidator.IsStrongPassword("Abcd1234").Should().BeTrue();
        }
        
        [Fact]
        public void ValidateThatPasswordIsNotLongEnough()
        {
            PasswordValidator.IsStrongPassword("Ola_k_").Should().BeFalse();
        }
        
        [Fact]
        public void ValidateThatPasswordHasNotAnUppercaseLetter()
        {
            PasswordValidator.IsStrongPassword("abcd1234").Should().BeFalse();
        }

        [Fact]
        public void ValidateThatPasswordHasNotALowercaseLetter()
        {
            PasswordValidator.IsStrongPassword("ABCD1234").Should().BeFalse();
        }

        [Fact]
        public void ValidateThatPasswordHasNotANumber()
        {
            PasswordValidator.IsStrongPassword("ABCDabcd").Should().BeFalse();
        }
    }
}