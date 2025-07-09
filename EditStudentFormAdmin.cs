using Npgsql;
using System.Data;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditStudentFormAdmin : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string id = null!;
        public EditStudentFormAdmin()
        {
            InitializeComponent();
        }
        //Код для кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Код очисткий полей
        public void ClearFields()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            AddmissionBaseComboBox.SelectedIndex = -1;
            AddressTextBox.Text = "";
            RecordBookTextBox.Text = "";
            CertificateTextBox.Text = "";
            PassportTextBox.Text = "";
            PasswordTextBox.Text = "";
            GroupComboBox.SelectedIndex = -1;
        }
        //Код для кнопки редактирования студента
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Surname = SurnameTextBox.Text;
            var Patronymic = PatronymicTextBox.Text;
            var Phone = PhoneTextBox.Text;
            var Email = EmailTextBox.Text;
            var AddmissionBase = AddmissionBaseComboBox.SelectedItem;
            var Address = AddressTextBox.Text;
            var RecordBook = RecordBookTextBox.Text;
            var Certificate = CertificateTextBox.Text;
            var Passport = PassportTextBox.Text;
            var Password = PasswordTextBox.Text;
            var Group = GroupComboBox.SelectedItem;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Patronymic) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email) || AddmissionBaseComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(RecordBook) || string.IsNullOrEmpty(Certificate) || string.IsNullOrEmpty(Passport) || string.IsNullOrEmpty(Password) || GroupComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from student where email = '{Email}' AND id <> {id}", EmailTextBox) == false)
            {
                MessageBox.Show("Пользователь с такой почтой уже существует!", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                            $"email = '{Email}', " +
                            $"admission_base = {AddmissionBase}, " +
                            $"address = '{Address}', " +
                            $"record_book_number = {RecordBook}, " +
                            $"certificate_code = {Certificate}, " +
                            $"passport_number = '{Passport}', " +
                            $"password = '{Password}', " +
                            $"group_id = '{DataBaseCommands.GetId($"select id from \"group\" where short_name = '{Group}'")}' where id = '{DataBaseCommands.GetId($"select id from student where id = '{id}'")}'";

                    DataBaseCommands.ExecuteCommandAndAdapter(querrystring);

                    MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //Метод загрузки формы
        private void EditStudentFormAdmin_Load(object sender, EventArgs e)
        {
            AddmissionBaseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            DataBase.OpenConnection();

            DataBaseCommands.FillFields($"select short_name from \"group\"", GroupComboBox);

            AddmissionBaseComboBox.Items.Add("11");
            AddmissionBaseComboBox.Items.Add("9");

            NameTextBox.MaxLength = 50;
            SurnameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
            PhoneTextBox.MaxLength = 15;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress_1;
            EmailTextBox.MaxLength = 50;
            AddressTextBox.MaxLength = 50;
            RecordBookTextBox.MaxLength = 10;
            RecordBookTextBox.KeyPress += RecordBookTextBox_KeyPress;
            CertificateTextBox.MaxLength = 10;
            CertificateTextBox.KeyPress += CertificateTextBox_KeyPress;
            PassportTextBox.MaxLength = 10;
            PassportTextBox.KeyPress += PassportTextBox_KeyPress;
            PasswordTextBox.MaxLength = 30;

            DataBase.OpenConnection();

            string query = $"SELECT s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, s.passport_number, s.password, g.short_name AS group_id " +
                           $"FROM student s " +
                           $"LEFT JOIN \"group\" g ON s.group_id = g.id " +
                           $"WHERE s.id = {id}";

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
                        AddmissionBaseComboBox.Text = reader["admission_base"].ToString() ?? string.Empty;
                        AddressTextBox.Text = reader["address"].ToString() ?? string.Empty;
                        RecordBookTextBox.Text = reader["record_book_number"].ToString() ?? string.Empty;
                        CertificateTextBox.Text = reader["certificate_code"].ToString() ?? string.Empty;
                        PassportTextBox.Text = reader["passport_number"].ToString() ?? string.Empty;
                        PasswordTextBox.Text = reader["password"].ToString() ?? string.Empty;
                        GroupComboBox.Text = reader["group_id"].ToString() ?? string.Empty;
                    }
                }
                DataBase.CloseConnection();
            }
            catch
            {
                DataBase.CloseConnection();
            }
        }
        //Метод задания ограничений при вводе символов для поля Номер зачетной книжки
        private void RecordBookTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Метод задания ограничений при вводе символов для поля Номер аттестата
        private void CertificateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Метод задания ограничений при вводе символов для поля Серия, номер паспорта
        private void PassportTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Метод задания ограничений при вводе символов для поля Номер телефона
        private void PhoneTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 15);
        }
        //Код выполняющийся при закрытии формы
        private void EditStudentFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
