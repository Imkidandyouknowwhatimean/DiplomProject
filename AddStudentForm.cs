namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class AddStudentForm : Form
    {
        DataBase DataBase = new DataBase();
        KeysHelper KeysHelper = new KeysHelper();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        public AddStudentForm()
        {
            InitializeComponent();
        }
        //Код кнопки добавления студента
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

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Patronymic) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email) || AddmissionBaseComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(RecordBook) || string.IsNullOrEmpty(Certificate) || string.IsNullOrEmpty(Passport) || string.IsNullOrEmpty(Password) || GroupComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from student where email = '{Email}'", EmailTextBox) == false)
            {
                MessageBox.Show("Пользователь с такой почтой уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string querrystring = $"insert into student(name, surname, patronymic, phone_number, email, admission_base, address, record_book_number, " +
                        $"certificate_code, passport_number, password, group_id)" +
                        $"VALUES('{Name}', '{Surname}', '{Patronymic}', '{Phone}', '{Email}', {AddmissionBase}, '{Address}', {RecordBook}, {Certificate}, {Passport}, '{Password}', " +
                        $"{DataBaseCommands.GetId($"select id from \"group\" where short_name = '{Group}'")})";

                    DataBaseCommands.ExecuteCommandAndAdapter(querrystring);

                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //Метод для очистки полей
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
        //Метод задания ограничений при вводе символов для поля Номер телефона
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 15);
        }
        //Метод загрузки формы
        private void AddStudentForm_Load(object sender, EventArgs e)
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
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress;
            EmailTextBox.MaxLength = 50;
            AddressTextBox.MaxLength = 50;
            RecordBookTextBox.MaxLength = 10;
            RecordBookTextBox.KeyPress += RecordBookTextBox_KeyPress;
            CertificateTextBox.MaxLength = 10;
            CertificateTextBox.KeyPress += CertificateTextBox_KeyPress;
            PassportTextBox.MaxLength = 10;
            PassportTextBox.KeyPress += PassportTextBox_KeyPress;
            PasswordTextBox.MaxLength = 30;

            DataBase.CloseConnection();
        }
        //Код кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
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
        //Код выполняющийся при закрытии формы
        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
