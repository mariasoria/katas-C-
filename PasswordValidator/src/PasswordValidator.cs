using System.Text.RegularExpressions;

namespace PasswordValidator
{
    public static class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            return password.Length >= 8
                   && HasUppercaseLetter(password)
                   && HasLowercaseLetter(password)
                   && HasANumber(password);
        }

        private static bool HasUppercaseLetter(string password)
        {
            return Regex.IsMatch(password, "[A-Z]");
        }

        private static bool HasLowercaseLetter(string password)
        {
            return Regex.IsMatch(password, "[a-z]");
        }

        private static bool HasANumber(string password)
        {
            return Regex.IsMatch(password, "[0-9]");
        }
    }
}