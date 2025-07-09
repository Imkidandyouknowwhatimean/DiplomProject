namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
        }
        //Код кнопки редактирвоания параметров
        private void EditButton_Click(object sender, EventArgs e)
        {
            string Login = TextBoxLogin.Text;
            string Password = TextBoxPassword.Text;
            try
            {
                AdminCredentialsManager.SetCredentials(Login, CredentialsStorage.HashPassword(Password));
                Journal journal = new Journal();
                journal.login = Login;
                this.Close();
            }
            catch
            {
                return;
            }
        }
        //Код загрузки формы
        private void EditAdmin_Load(object sender, EventArgs e)
        {
            TextBoxLogin.Text = AdminCredentialsManager.GetLogin();
        }
        //Код кнопки значения по умолчанию
        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            TextBoxLogin.Text = "admin";
            TextBoxPassword.Text = "admin";
        }
    }
}
