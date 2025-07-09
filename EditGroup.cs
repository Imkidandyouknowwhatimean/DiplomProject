using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditGroup : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string id = null!;
        public EditGroup()
        {
            InitializeComponent();
        }
        //Код загрузки формы
        private void EditGroup_Load(object sender, EventArgs e)
        {
            TutorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            DataBase.OpenConnection();

            DataBaseCommands.FillFields($"select name from speciality", SpecialtyComboBox);
            DataBaseCommands.FillFields($"select id from tutor", TutorComboBox);

            NameTextBox.MaxLength = 5;
            CodeTextBox.MaxLength = 10;
            DateTextBox.MaxLength = 9;
            CodeTextBox.KeyPress += CodeTextBox_KeyPress;

            string query = $"SELECT g.short_name, g.code, g.create_date, s.name AS specialty, " +
                $"t.id AS tutor " +
                $"FROM \"group\" g " +
                $"LEFT JOIN speciality s ON g.speciality_id = s.id " +
                $"LEFT JOIN tutor t ON g.tutor_id = t.id " +
                $"WHERE g.id = {id}";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, DataBase.GetConnection());
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameTextBox.Text = reader["short_name"].ToString() ?? string.Empty;
                        CodeTextBox.Text = reader["code"].ToString() ?? string.Empty;
                        DateTextBox.Text = reader["create_date"].ToString() ?? string.Empty;
                        SpecialtyComboBox.Text = reader["specialty"].ToString() ?? string.Empty;
                        TutorComboBox.Text = reader["tutor"].ToString() ?? string.Empty;
                    }
                }
                DateTextBox.Text = DateTextBox.Text.Substring(0, DateTextBox.Text.Length - 8);
                DataBase.CloseConnection();
            }
            catch
            {
                DataBase.CloseConnection();
            }
        }
        //Метод задания ограничений при вводе символов для поля Код
        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
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
        //Код для кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Код кнопки добавления редактирования группы
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
            else if (DataBaseCommands.Checker($"select * from \"group\" where code = '{Code}' and id <> {id}", CodeTextBox) == false)
            {
                MessageBox.Show("Группа с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(DataBaseCommands.IsValidDate(Date) == false)
            {
                return;
            }
            else
            {
                
                try
                {
                    string querrystring = $"update \"group\" set " +
                            $"short_name = '{Name}', " +
                            $"code = '{Code}', " +
                            $"create_date = '{Date}', " +
                            $"speciality_id = '{DataBaseCommands.GetId($"select id from speciality where name = '{Specialty}'")}', " +
                            $"tutor_id = '{Tutor}' " +
                            $"where id = '{DataBaseCommands.GetId($"select id from \"group\" where id = '{id}'")}'";

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
        //Код выполняющийся при закрытии формы
        private void EditGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}

