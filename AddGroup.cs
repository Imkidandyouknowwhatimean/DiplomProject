namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class AddGroup : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        ManageGroups ManageGroups = new ManageGroups();
        public AddGroup()
        {
            InitializeComponent();
        }
        //Метод загрузки формы
        private void AddGroup_Load(object sender, EventArgs e)
        {
            TutorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            DataBase.OpenConnection();

            DataBaseCommands.FillFields($"select name from speciality", SpecialtyComboBox);
            DataBaseCommands.FillFields($"select id from tutor", TutorComboBox);

            NameTextBox.MaxLength = 5;
            CodeTextBox.MaxLength = 10;
            CodeTextBox.KeyPress += CodeTextBox_KeyPress;

            DataBase.CloseConnection();
        }
        //Метод задания ограничений при вводе символов для поля Код
        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Код кнопки добавления группы
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Code = CodeTextBox.Text;
            var Date = DateTextBox.Text;
            var Tutor = TutorComboBox.SelectedItem;
            var Specialty = SpecialtyComboBox.SelectedItem;

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Date) || TutorComboBox.SelectedIndex == -1 || SpecialtyComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DataBaseCommands.Checker($"select * from \"group\" where code = '{Code}'", CodeTextBox) == false)
            {
                MessageBox.Show("Группа с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DataBaseCommands.IsValidDate(Date) == false)
            {
                return;
            }
            else
            {
                try
                {
                    string querrystring = $"insert into \"group\"(short_name, code, create_date, speciality_id, tutor_id)" +
                                          $"VALUES('{Name}', '{Code}', '{Date}', " +
                                          $"{DataBaseCommands.GetId($"select id from speciality where name = '{SpecialtyComboBox.Text}'")}, {Tutor})";

                    DataBaseCommands.ExecuteCommandAndAdapter(querrystring);

                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DataBase.CloseConnection();
                    return;
                }
                catch
                {
                    MessageBox.Show("Неверный формат записи", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataBase.CloseConnection();
                    return;
                }
            }
        }
        //Метод очистки полей
        public void ClearFields()
        {
            NameTextBox.Text = "";
            CodeTextBox.Text = "";
            DateTextBox.Text = "";
            SpecialtyComboBox.SelectedIndex = -1;
            TutorComboBox.SelectedIndex = -1;
        }
        //Код кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Код выполняемый при закрытии формы
        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
