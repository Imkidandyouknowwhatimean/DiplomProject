using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditStudentFormStudent : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string id = null!;
        public EditStudentFormStudent()
        {
            InitializeComponent();
        }
        //Метод для очистки полей
        public void ClearFields()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
        //Код кнопки добавления студента
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Surname = SurnameTextBox.Text;
            var Patronymic = PatronymicTextBox.Text;
            var Phone = PhoneTextBox.Text;
            var Address = AddressTextBox.Text;
            var Password = PasswordTextBox.Text;

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Patronymic) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string querrystring = $"update student set " +
                            $"name = '{Name}', " +
                            $"surname = '{Surname}', " +
                            $"patronymic = '{Patronymic}', " +
                            $"phone_number = '{Phone}', " +
                            $"address = '{Address}', " +
                            $"password = '{Password}' where id = '{DataBaseCommands.GetId($"select id from student where id = '{id}'")}'";

                    DataBaseCommands.ExecuteCommandAndAdapter(querrystring);

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Неверный формат записи", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                    DataBase.CloseConnection();
                    return;
                }
            }
        }
        //Метод задания ограничений при вводе символов для поля Номер телефона
        private void PhoneTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 15);
        }
        //Метод загрузки формы
        private void EditStudentFormStudent_Load(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 50;
            SurnameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
            PhoneTextBox.MaxLength = 15;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress_1;
            AddressTextBox.MaxLength = 50;
            PasswordTextBox.MaxLength = 30;

            DataBase.OpenConnection();

            string query = $"SELECT name, surname, patronymic, phone_number, address, password FROM student WHERE id = {id}";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, DataBase.GetConnection());
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameTextBox.Text = reader["name"].ToString() ?? string.Empty;
                        SurnameTextBox.Text = reader["surname"].ToString() ?? string.Empty;
                        PatronymicTextBox.Text = reader["patronymic"].ToString() ?? string.Empty;
                        PhoneTextBox.Text = reader["phone_number"].ToString() ?? string.Empty;
                        AddressTextBox.Text = reader["address"].ToString() ?? string.Empty;
                        PasswordTextBox.Text = reader["password"].ToString() ?? string.Empty;
                    }
                }
                DataBase.CloseConnection();
            }
            catch
            {

            }
        }
        //Код выполняющийся при закрытии формы
        private void EditStudentFormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
        //Код для кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
