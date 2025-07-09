namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public static class AdminCredentialsManager
    {
        private static string adminLogin = "admin";     // default login
        private static string adminPassword = "admin";  // default password
        static AdminCredentialsManager()
        {
            var creds = CredentialsStorage.LoadCredentials(CredentialsStorage.filePathAdmin);
            if (creds.HasValue)
            {
                adminLogin = creds.Value.login;
                adminPassword = creds.Value.password;
            }
        }
        //Метод установки данных администратора
        public static void SetCredentials(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Логин не может быть пустым");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Пароль не может быть пустым");

            adminLogin = login;
            adminPassword = password;
            SaveCredentials();
        }
        //Метод для проверки данных на валидность 
        public static bool ValidateCredentials(string login, string password)
        {
            return login == adminLogin && password == adminPassword;
        }
        //Метод смены пароля
        public static void ChangePassword(string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("Пароль не может быть пустым");
            adminPassword = newPassword;
            SaveCredentials();
        }
        //Метод получения логина администратора
        public static string GetLogin() => adminLogin;
        //Метод получения пароля администратора
        public static string GetPassword() => adminPassword;
        //Метод сохранения данных администратора
        public static void SaveCredentials() => CredentialsStorage.SaveCredentials(adminLogin, adminPassword, CredentialsStorage.filePathAdmin);
    }
}
