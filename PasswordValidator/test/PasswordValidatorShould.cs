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
            PasswordValidator.IsStrongPassword("AbcdefGhijKlmnopQRsTuvwxyZ1234567890").Should().BeTrue();
            PasswordValidator.IsStrongPassword("Ab1!@#$%^&*()-_+={}[]|\\:;?/>.<,").Should().BeTrue();
        }

        [Fact]
        public void ValidateThatPasswordIsNotLongEnough()
        {
            PasswordValidator.IsStrongPassword("Abcd123").Should().BeFalse();
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

        [Fact]
        public void ValidateWeakPasswords()
        {
            PasswordValidator.IsStrongPassword("abcdefghij").Should().BeFalse();
            PasswordValidator.IsStrongPassword("ABCDEFGHIJ").Should().BeFalse();
            PasswordValidator.IsStrongPassword("1234567890").Should().BeFalse();
            PasswordValidator.IsStrongPassword("AbcdefGhijKlmnopQRsTuvwxyZ").Should().BeFalse();
            PasswordValidator.IsStrongPassword("!@#$%^&*()-_+={}[]|\\:;?/>.<,").Should().BeFalse();
        }
    }
}