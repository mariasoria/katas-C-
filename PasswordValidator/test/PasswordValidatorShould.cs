using FluentAssertions;
using Xunit;

namespace PasswordValidator.test
{
    public class PasswordValidatorShould
    {
        [Fact]
        public void ValidateThatPasswordIsStrongEnough()
        {
            PasswordValidator.IsStrongPassword("Ola_k_as3").Should().BeTrue();
        }
        
        [Fact]
        public void ValidateThatPasswordIsNotLongEnough()
        {
            PasswordValidator.IsStrongPassword("Ola_k_").Should().BeFalse();
        }
        
        [Fact]
        public void ValidateThatPasswordHasNotAnUppercaseLetter()
        {
            PasswordValidator.IsStrongPassword("ola_k_as3").Should().BeFalse();
        }
    }
}