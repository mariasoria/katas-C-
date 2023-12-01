using System.Text.RegularExpressions;

namespace PasswordValidator
{
    public static class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            return password.Length > 8 && HasUppercaseLetter(password);
        }
        
        private static bool HasUppercaseLetter(string password)
        {
            return Regex.IsMatch(password, @"[A-Z]");
        }
    }
}