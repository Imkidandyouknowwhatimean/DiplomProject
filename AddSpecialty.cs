namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class AddSpecialty : Form
    {
        DataBase DataBase = new DataBase();
        KeysHelper KeysHelper = new KeysHelper();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        public AddSpecialty()
        {
            InitializeComponent();
        }
        //Метод для очистки полей
        public void ClearFields()
        {
            DescriptionTextBox.Text = "";
            CodeTextBox.Text = "";
            QualificationTextBox.Text = "";
            NameTextBox.Text = "";
        }
        //Метод задания ограничений при вводе символов для поля Код
        private void EditCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Код кнопки добавления специальности
        private void AddSpecialtyButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Qualification = QualificationTextBox.Text;
            var Code = CodeTextBox.Text;
            var Description = DescriptionTextBox.Text;

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Qualification) || string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from speciality where code = '{Code}'", CodeTextBox) == false)
            {
                MessageBox.Show("Специальность с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    DataBaseCommands.ExecuteCommandAndAdapter($"insert into speciality(name, qualification, code, description) VALUES('{Name}','{Qualification}','{Code}','{Description}')");

                    MessageBox.Show("Запись учпешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //Метод задания ограничений при вводе символов для поля Код
        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.SetOnlyDigitsKeys(sender, e);
        }
        //Код кнопки для очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Метод загрузки формы
        private void AddSpecialty_Load(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 50;
            QualificationTextBox.MaxLength = 50;
            CodeTextBox.MaxLength = 10;
            CodeTextBox.KeyPress += CodeTextBox_KeyPress;
            DescriptionTextBox.MaxLength = 50;
        }
        //Код выполняющийся при закрытии формы
        private void AddSpecialty_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
