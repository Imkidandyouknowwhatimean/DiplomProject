using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class EditSpecialty : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string id = null!;
        public EditSpecialty()
        {
            InitializeComponent();
        }
        //Метод очистки полей
        public void ClearFields()
        {
            NameTextBox.Text = "";
            QualificationTextBox.Text = "";
            CodeTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }
        //Метод задания ограничений при вводе символов для поля Код
        private void EditCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysHelper.FixedLengthAndOnlyDigits(sender, e, 10);
        }
        //Код для кнопки очистки полей
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Код для кнопки добавления специальности
        private void AddSpecialtyButton_Click(object sender, EventArgs e)
        {
            var Name = NameTextBox.Text;
            var Qualification = QualificationTextBox.Text;
            var Code = CodeTextBox.Text;
            var Description = DescriptionTextBox.Text;

            string querrystring = $"UPDATE speciality set " +
                $"name = '{Name}', " +
                $"qualification = '{Qualification}', " +
                $"code = '{Code}', " +
                $"description = '{Description}' " +
                $"WHERE id = '{id}'";

            DataBase.OpenConnection();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Qualification) || string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataBaseCommands.Checker($"select * from speciality where code = '{Code}' and id <> {id}", CodeTextBox) == false)
            {
                MessageBox.Show("Специальность с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Код загрузки формы
        private void EditSpecialty_Load(object sender, EventArgs e)
        {
            NameTextBox.MaxLength = 50;
            QualificationTextBox.MaxLength = 50;
            CodeTextBox.MaxLength = 10;
            CodeTextBox.KeyPress += EditCodeTextBox_KeyPress;
            DescriptionTextBox.MaxLength = 50;

            DataBase.OpenConnection();

            string query = $"SELECT * FROM speciality where id = {id}";
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, DataBase.GetConnection());
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameTextBox.Text = reader["name"].ToString() ?? string.Empty;
                        QualificationTextBox.Text = reader["qualification"].ToString() ?? string.Empty;
                        CodeTextBox.Text = reader["code"].ToString() ?? string.Empty;
                        DescriptionTextBox.Text = reader["description"].ToString() ?? string.Empty;
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
        private void EditSpecialty_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
    }
}
