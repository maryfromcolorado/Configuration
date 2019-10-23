using System.Security;

namespace finitelogic.Common.Configuration
{
    public static class StringExtensions
    {
        public static SecureString MakeSecureString(this string value)
        {
            if (value == null)
            {
                return null;
            }
            SecureString secure = new SecureString();
            for (int i = 0; i < value.Length; i++)
            {
                secure.AppendChar(value[i]);
            }
            return secure;

        }
    }
}
