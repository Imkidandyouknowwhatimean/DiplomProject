using Npgsql;
using System.Data;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class Form1 : Form
    {
        DataBase DataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AuthButton_Click(object sender, EventArgs e) //Код для кнопки авторизации
        {
            var Login = TextBoxLogin.Text;
            var Password = TextBoxPassword.Text;

            string querrystring = $"select * from Student where email = '{Login}' and password = '{Password}'";

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataBase.OpenConnection();

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно!", $"Вы вошли в систему под записью студента", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Journal Transition = new Journal();
                Transition.login = Login;
                Transition.ShowDialog();
                this.Hide();

                return;
            }
            if (CredentialsStorage.HashPassword(Password) == AdminCredentialsManager.GetPassword() && Login == AdminCredentialsManager.GetLogin())
            {
                MessageBox.Show("Успешный вход!", "Вы вошли под записью администратора", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Journal Transition = new Journal();
                Transition.login = Login;
                Transition.ShowDialog();
                this.Hide();

                return;
            }
            if(CredentialsStorage.HashPassword(Password) == EmployeeCredentialsManager.GetPassword() && Login == EmployeeCredentialsManager.GetLogin())
            {
                MessageBox.Show("Успешный вход!", "Вы вошли под записью сотрудника организации", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Journal Transition = new Journal();
                Transition.login = Login;
                Transition.ShowDialog();
                this.Hide();

                return;
            }
            else
            {
                MessageBox.Show("Вход не был выполнен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
