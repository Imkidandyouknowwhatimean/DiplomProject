namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class AddTutor : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();
        public AddTutor()
        {
            InitializeComponent();
        }
        //Метод очистки полей
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

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Patronymic) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from tutor where email = '{Email}'", EmailTextBox) == false)
            {
                MessageBox.Show("Пользователь с такой почтой уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string querrystring = $"insert into tutor(name, surname, patronymic, phone_number, email) VALUES('{Name}','{Surname}','{Patronymic}','{Phone}','{Email}')";

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
        //Код загрузки формы
        private void AddTutor_Load(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 50;
            SurnameTextBox.MaxLength = 50;
            PatronymicTextBox.MaxLength = 50;
            PhoneTextBox.MaxLength = 15;
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress;
            EmailTextBox.MaxLength = 50;
        }
        //Метод задания ограничений при вводе символов для поля Номер телефона
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 15);
        }
        //Код выполняющийся при закрытии формы
        private void AddTutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
