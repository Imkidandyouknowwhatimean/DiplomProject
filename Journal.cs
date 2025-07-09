using Npgsql;
using System.Data;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class Journal : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();
        public Journal()
        {
            InitializeComponent();
        }
        public string login = null!;
        private static string tableName = "student";
        private string querry = null!;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Journal_Load(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            EditStudentTextBox.MaxLength = 10;
            DeleteStudentTextBox.MaxLength = 10;

            if (login == AdminCredentialsManager.GetLogin())
            {
                querry = $" SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                    $" s.passport_number, s.password, g.short_name " +
                    $" FROM student s " +
                    $" LEFT JOIN \"group\" g ON s.group_id = g.id ";
                ChangeLoginOrPasswordAdmin.Visible = true;
                editEmployeeButton.Visible = true;

                LoadDataBase(querry);

                DataBase.CloseConnection();

                return;
            }
            if (login == EmployeeCredentialsManager.GetLogin())
            {
                querry = $" SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                    $" s.passport_number, s.password, g.short_name " +
                    $" FROM student s " +
                    $" LEFT JOIN \"group\" g ON s.group_id = g.id ";
                ChangeLoginOrPasswordAdmin.Visible = false;
                ManageGroupsButton.Enabled = false;
                ManageSpecialtyButton.Enabled = false;
                ManageTutorsButton.Enabled = false;
                editEmployeeButton.Visible = true;

                LoadDataBase(querry);

                DataBase.CloseConnection();

                return;
            }
            else
            {
                querry = $" SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                    $" s.passport_number, s.password, g.short_name " +
                    $" FROM student s " +
                    $" LEFT JOIN \"group\" g ON s.group_id = g.id " +
                    $" WHERE s.email = '{login}'";

                ChangeLoginOrPasswordAdmin.Visible = false;
                ManageGroupsButton.Enabled = false;
                ManageSpecialtyButton.Enabled = false;
                ManageTutorsButton.Enabled = false;
                DeleteStudentTextBox.Enabled = false;
                AddStudentButton.Enabled = false;
                DeleteStudentButton.Enabled = false;
                SortComboBox.Enabled = false;
                SortButton.Enabled = false;
                SortButtonUp.Enabled = false;
                SortButtonDown.Enabled = false;
                searchButton.Enabled = false;
                searchTextBox.Enabled = false;
                editEmployeeButton.Visible = false;

                LoadDataBase(querry);

                DataBase.CloseConnection();
                return;
            }
        }
        //Метод загрузки базы данных
        private void LoadDataBase(string querry)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1, tableName, querry);

            DataBaseCommands.FillFields("select short_name from \"group\"", SortComboBox);
        }
        //Метод для создания столбцов таблицы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Surname", "Фамилия");
            dataGridView1.Columns.Add("Patronymic", "Отчество");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Base", "База поступления");
            dataGridView1.Columns.Add("Address", "Адрес");
            dataGridView1.Columns.Add("RecordBook number", "Номер зачетной книжки");
            dataGridView1.Columns.Add("Certificate", "Номер аттестата");
            dataGridView1.Columns.Add("Passport", "Серия, номер паспорта");
            dataGridView1.Columns.Add("Password", "Пароль");
            dataGridView1.Columns.Add("Group", "Группа");

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 75;
            dataGridView1.Columns[6].Width = 40;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 75;
            dataGridView1.Columns[10].Width = 75;
            dataGridView1.Columns[11].Width = 75;
            dataGridView1.Columns[12].Width = 60;

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ScrollBars = ScrollBars.Both;

        }
        //Метод чтения строк из базы данных
        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7),
                record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), record.GetString(11), record.IsDBNull(12) ? DBNull.Value : record.GetString(12));
        }
        //Метод обновления таблицы
        public void RefreshDataGrid(DataGridView dgv, string table, string querrystring)
        {
            dgv.Rows.Clear();

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            DataBase.OpenConnection();

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
            }
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            DataBase.CloseConnection();
        }
        //Код для кнопки добавления студента
        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm<AddStudentForm>();
        }
        //Код для кнопки редактирования студента
        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            if (login == AdminCredentialsManager.GetLogin() && EditStudentTextBox != null || login == EmployeeCredentialsManager.GetLogin() && EditStudentTextBox != null)
            {
                if (DataBaseCommands.CheckId($"select * from student where id = '{EditStudentTextBox.Text}'", EditStudentTextBox) == false)
                {
                    EditStudentFormAdmin edit = new EditStudentFormAdmin();
                    edit.id = EditStudentTextBox.Text;
                    edit.ShowDialog();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                string querrystring = $"select id from student where email = '{login}'";
                DataBase.OpenConnection();

                NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                DataTable table = new DataTable();

                EditStudentTextBox.Text = command.ExecuteScalar().ToString();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                DataBase.CloseConnection();

                EditStudentFormStudent edit = new EditStudentFormStudent();
                edit.id = EditStudentTextBox.Text;
                edit.ShowDialog();
                return;

            }
        }
        //Код для кнопки удаления студента
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (login == AdminCredentialsManager.GetLogin() && DeleteStudentTextBox != null || login == EmployeeCredentialsManager.GetLogin() && DeleteStudentTextBox != null)
            {
                try
                {
                    if (DataBaseCommands.CheckId($"select * from student where id = '{DeleteStudentTextBox.Text}'", DeleteStudentTextBox) == false)
                    {
                        DataBaseCommands.DeleteRow($"Delete from student where id = '{DeleteStudentTextBox.Text}'", DeleteStudentTextBox);
                        RefreshDataGrid(dataGridView1, tableName, querry);
                    }
                    else
                    {
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Введите число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Функция проверки роли пользователя
        private bool UserCheck(string login)
        {
            if (login == AdminCredentialsManager.GetLogin() || login == EmployeeCredentialsManager.GetLogin())
            {
                return true;

            }
            else
            {
                MessageBox.Show("У вас недостаточно прав!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Метод для отображения формы
        private void ShowForm<T>() where T : Form, new()
        {
            if (UserCheck(login) == true)
            {
                T form = new T();
                form.ShowDialog();
            }
        }
        //Код для кнопки управление группами
        private void ManageGroupsButton_Click(object sender, EventArgs e)
        {
            ShowForm<ManageGroups>();
        }
        //Код для кнопки управление специальностями
        private void ManageSpecialtyButton_Click(object sender, EventArgs e)
        {
            ShowForm<ManageSpecialty>();
        }
        //Код для кнопки управление руководилетями групп
        private void ManageTutorsButton_Click(object sender, EventArgs e)
        {
            ShowForm<ManageTutors>();
        }
        //Код для кнопки сортировки по группам
        private void SortButton_Click(object sender, EventArgs e)
        {
            string Group = SortComboBox.Text;
            string querrystring;

            DataBase.OpenConnection();
            if (login == AdminCredentialsManager.GetLogin() || login == EmployeeCredentialsManager.GetLogin())
            {

                NpgsqlCommand command = new NpgsqlCommand();
                if (string.IsNullOrEmpty(Group))
                {
                    command = new NpgsqlCommand(querry, DataBase.GetConnection());
                    RefreshDataGrid(dataGridView1, tableName, querry);

                    DataBase.CloseConnection();
                    return;
                }
                else
                {
                    querrystring = $"select id from \"group\" where short_name = '{Group}'";
                    command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

                    querrystring = $"SELECT " +
                                   $"   s.id, " +
                                   $"   s.name, " +
                                   $"   s.surname, " +
                                   $"   s.patronymic, " +
                                   $"   s.phone_number, " +
                                   $"   s.email, " +
                                   $"   s.admission_base, " +
                                   $"   s.address, " +
                                   $"   s.record_book_number, " +
                                   $"   s.certificate_code, " +
                                   $"   s.passport_number, " +
                                   $"   s.password, " +
                                   $"   g.short_name AS group_short_name " +
                                   $"FROM " +
                                   $"   student s " +
                                   $"JOIN " +
                                   $"   \"group\" g ON s.group_id = g.id " +
                                   $"WHERE " +
                                   $"   g.short_name = '{Group}'";
                    command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

                    RefreshDataGrid(dataGridView1, tableName, querrystring);

                    DataBase.CloseConnection();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Отказано в доступе", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Код для кнопки обновления таблицы
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, tableName, querry);
        }
        //Код для кнопки сортировки по id сверху вниз
        private void SortButtonUp_Click(object sender, EventArgs e)
        {
            querry = $" SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                    $" s.passport_number, s.password, g.short_name " +
                    $" FROM student s " +
                    $" JOIN \"group\" g ON s.group_id = g.id ";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "ASC"));
        }
        //Код для кнопки сортировки по id снизу вверх
        private void SortButtonDown_Click(object sender, EventArgs e)
        {
            querry = $" SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                    $" s.passport_number, s.password, g.short_name " +
                    $" FROM student s " +
                    $" JOIN \"group\" g ON s.group_id = g.id ";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "DESC"));
        }
        //Код выполняемый при закрытии формы 
        private void Journal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Код для кнопки редактирования данных администратора
        private void ChangeLoginOrPasswordAdmin_Click(object sender, EventArgs e)
        {
            ShowForm<EditAdmin>();
        }
        //Код для кнопки поиска по базе данных
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (DataBaseCommands.Search(searchTextBox.Text) == true)
            {
                string searchQuery = $"SELECT s.id, s.name, s.surname, s.patronymic, s.phone_number, s.email, s.admission_base, s.address, s.record_book_number, s.certificate_code, " +
                         $"s.passport_number, s.password, g.short_name " +
                         $"FROM student s " +
                         $"LEFT JOIN \"group\" g ON s.group_id = g.id " +
                         $"WHERE s.name ILIKE '%{searchTextBox.Text}%' OR " +
                         $"s.surname ILIKE '%{searchTextBox.Text}%' OR " +
                         $"s.patronymic ILIKE '%{searchTextBox.Text}%' OR " +
                         $"s.email ILIKE '%{searchTextBox.Text}%'";
                RefreshDataGrid(dataGridView1, tableName, searchQuery);
            }
            else
            {
                RefreshDataGrid(dataGridView1, tableName, querry);
            }
        }
        //Код для кнопки редактирования данных сотрудника
        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            ShowForm<EditEmployee>();
        }
    }
}
