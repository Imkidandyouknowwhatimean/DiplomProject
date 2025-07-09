using System.Text;
using System.Security.Cryptography;
namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public static class CredentialsStorage
    {
        public static readonly string filePathAdmin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "admin_credentials.dat");
        public static readonly string filePathEmployee = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employee_credentials.dat");

        //Метод сохранения логина и пароля
        public static void SaveCredentials(string login, string password, string filePath)
        {
            var hashedPassword = HashPassword(password);
            var plainText = $"{login}\n{password}";
            var encryptedData = Protect(Encoding.UTF8.GetBytes(plainText));

            File.WriteAllBytes(filePath, encryptedData);
        }
        //Метод подгрузки данных
        public static (string login, string password)? LoadCredentials(string filePath)
        {
            if (!File.Exists(filePath))
                return null;
            try
            {
                var encryptedData = File.ReadAllBytes(filePath);
                var decryptedBytes = Unprotect(encryptedData);
                var decryptedText = Encoding.UTF8.GetString(decryptedBytes);
                var parts = decryptedText.Split(new[] { '\n' }, 2);

                if (parts.Length == 2)
                {
                    return (parts[0], parts[1]);
                }
            }
            catch
            { 
            }
            return null;
        }
        //Метод защиты данных при переводе в другую кодировку и хешировании 
        private static byte[] Protect(byte[] data)
        {
            return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        }
        //Метод снятия защиты данных при переводе в другую кодировку и хешировании
        private static byte[] Unprotect(byte[] data)
        {
            return ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
        }
        //Метод хеширования пароля
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
