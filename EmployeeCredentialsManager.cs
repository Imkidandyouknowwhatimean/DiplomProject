namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public static class EmployeeCredentialsManager
    {
        private static string employeeLogin = "employee";     // default login
        private static string employeePassword = "employee";  // default password
        static EmployeeCredentialsManager()
        {
            var creds = CredentialsStorage.LoadCredentials(CredentialsStorage.filePathEmployee);
            if (creds.HasValue)
            {
                employeeLogin = creds.Value.login;
                employeePassword = creds.Value.password;
            }
        }
        //Метод установки данных сотрудника
        public static void SetCredentials(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Логин не может быть пустым");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Пароль не может быть пустым");

            employeeLogin = login;
            employeePassword = password;
            SaveCredentials();
        }
        //Метод для проверки данных на валидность 
        public static bool ValidateCredentials(string login, string password)
        {
            return login == employeeLogin && password == employeePassword;
        }
        //Метод смены пароля
        public static void ChangePassword(string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("Пароль не может быть пустым");
            employeePassword = newPassword;
            SaveCredentials();
        }
        //Метод получения логина сотрудника
        public static string GetLogin() => employeeLogin;
        //Метод получения пароля сотрудника
        public static string GetPassword() => employeePassword;
        //Метод сохранения данных сотрудника
        public static void SaveCredentials() => CredentialsStorage.SaveCredentials(employeeLogin, employeePassword, CredentialsStorage.filePathEmployee);
    }
}
