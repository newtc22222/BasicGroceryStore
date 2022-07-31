using System.Net.Mail;

namespace BasicGroceryStore
{
    internal static class Checking
    {
        /// <summary>
        /// Checking Email Valid (for staff and supplier).
        /// Source: https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
