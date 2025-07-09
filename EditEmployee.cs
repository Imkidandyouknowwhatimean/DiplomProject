namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }
        //Код загрузки формы
        private void EditEmployee_Load(object sender, EventArgs e)
        {
            TextBoxLogin.Text = EmployeeCredentialsManager.GetLogin();
        }
        //Код кнопки значения по умолчанию
        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            TextBoxLogin.Text = "employee";
            TextBoxPassword.Text = "employee";
        }
        //Код кнопки редактирвоания параметров
        private void EditButton_Click(object sender, EventArgs e)
        {
            string Login = TextBoxLogin.Text;
            string Password = TextBoxPassword.Text;
            try
            {
                EmployeeCredentialsManager.SetCredentials(Login, CredentialsStorage.HashPassword(Password));
                Journal journal = new Journal();
                journal.login = Login;
                this.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
