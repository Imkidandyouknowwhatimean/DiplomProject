using System.Data;
using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditTutor : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string id;
        public EditTutor()
        {
            InitializeComponent();
        }
        //Код для метода очистки полей
        public void ClearFields()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
        }
        //Код для кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Код для кнопки добавления руководителя
        private void AddTutorButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Surname = SurnameTextBox.Text;
            var Patronymic = PatronymicTextBox.Text;
            var Phone = PhoneTextBox.Text;
            var Email = EmailTextBox.Text;

            string querrystring = $"UPDATE tutor set " +
                $"name = '{Name}', " +
                $"surname = '{Surname}', " +
                $"patronymic = '{Patronymic}', " +
                $"phone_number = '{Phone}', " +
                $"email = '{Email}'" +
                $"WHERE id = '{id}'";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Patronymic) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from tutor where email = '{Email}' and id <> {id}", EmailTextBox) == false)
            {
                MessageBox.Show("Пользователь с такой почтой уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    DataBaseCommands.ExecuteCommandAndAdapter(querrystring);

                    MessageBox.Show("Запись успешно отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DataBase.CloseConnection();
                    return;
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
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 15);
        }
        //Код загрузки формы
        private void EditTutor_Load(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 50;
            SurnameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
            PhoneTextBox.MaxLength = 15;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress;
            EmailTextBox.MaxLength = 50;

            DataBase.OpenConnection();

            string query = $"SELECT * FROM tutor where id = {id}";
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
                        EmailTextBox.Text = reader["email"].ToString() ?? string.Empty;
                    }
                }
                DataBase.CloseConnection();
            }
            catch
            {
                DataBase.CloseConnection();
            }
        }
        //Код выполняющийся при закрытии формы
        private void EditTutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}