using System.Data;
using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class ManageGroups : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();

        public string querry = null!;
        public string tableName = "group";
        public string searchTerm = null!;
        public ManageGroups()
        {
            InitializeComponent();
        }
        //Код для кнопки добавления группы
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.ShowDialog();
        }
        //Код для кнопки редактирования группы
        private void EditGroupButton_Click(object sender, EventArgs e)
        {
            if (DataBaseCommands.CheckId($"select * from \"group\" where id = '{EditGroupTextBox.Text}'", EditGroupTextBox) == false)
            {
                EditGroup edit = new EditGroup();
                edit.id = EditGroupTextBox.Text;
                edit.ShowDialog();
            }
            else
            {
                return;
            }
        }
        private void ManageGroups_Load(object sender, EventArgs e)
        {
            EditGroupTextBox.MaxLength = 10;
            DeleteGroupTextBox.MaxLength = 10;
            DeleteGroupAndStudentsTextBox.MaxLength = 10;

            querry = $"SELECT g.id, g.short_name, g.code, g.create_date, s.name AS speciality_name, CONCAT(t.name, ' ', t.surname) AS tutor_full_name " +
                     $"FROM \"group\" g " +
                     $"LEFT JOIN speciality s ON g.speciality_id = s.id " +
                     $"LEFT JOIN tutor t ON g.tutor_id = t.id ";

            CreateColumns();
            RefreshDataGrid(dataGridView1, DataBaseCommands.Sorting(querry, "id", "ASC"));
        }
        //Метод для создания столбцов таблицы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Code", "Код");
            dataGridView1.Columns.Add("Create Date", "Дата создания");
            dataGridView1.Columns.Add("Speciality", "Специалньость");
            dataGridView1.Columns.Add("Tutor", "Руководитель");

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[4].Width = 275;
            dataGridView1.Columns[5].Width = 150;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            EditGroupTextBox.MaxLength = 5;
            DeleteGroupTextBox.MaxLength = 5;
            DeleteGroupAndStudentsTextBox.MaxLength = 5;

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        //Метод для чтения строк базы данных
        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            DateTime createDate = record.IsDBNull(3) ? DateTime.MinValue : record.GetDateTime(3);

            //"dd.MM.yyyy"
            string formattedDate = createDate.ToString("dd.MM.yyyy");

            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), formattedDate, record.IsDBNull(4) ? DBNull.Value : record.GetString(4), record.IsDBNull(5) ? DBNull.Value : record.GetString(5));
        }
        //Метод обновления данных таблицы
        public void RefreshDataGrid(DataGridView dgv, string queryString, string searchTerm = null)
        {
            dgv.Rows.Clear();
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, DataBase.GetConnection()))
            {
                // Add the parameter if searchTerm is provided
                if (searchTerm != null)
                {
                    command.Parameters.AddWithValue("@searchTerm", searchTerm);
                }
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
        }
        //Код метода сортировки групп сверху вниз по id
        private void SortUpButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, DataBaseCommands.Sorting(querry, "id", "ASC"));
        }
        //Код метода сортировки групп снизу вверх по id
        private void SortDownButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, DataBaseCommands.Sorting(querry, "id", "DESC"));
        }
        //Код для кнопки обновления таблицы
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, querry);
        }
        //Код для удаления группы
        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            if (DeleteGroupTextBox.Text != null)
            {
                try
                {
                    if (DataBaseCommands.CheckId($"select * from \"group\" where id = '{DeleteGroupTextBox.Text}'", DeleteGroupTextBox) == false)
                    {
                        DataBaseCommands.DeleteRow($"Delete from \"group\" where id = '{DeleteGroupTextBox.Text}'", DeleteGroupTextBox);
                        RefreshDataGrid(dataGridView1, querry);
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
                return;
            }
        }
        //Код для удаления группы и студентов 
        private void DeleteGroupAndStudentsButton_Click(object sender, EventArgs e)
        {
            if (DeleteGroupAndStudentsTextBox.Text != null)
            {
                try
                {
                    if (DataBaseCommands.CheckId($"select * from \"group\" where id = '{DeleteGroupAndStudentsTextBox.Text}'", DeleteGroupAndStudentsTextBox) == false)
                    {
                        string querrystring = $"Delete from student where group_id = '{DeleteGroupAndStudentsTextBox.Text}';" +
                                              $"Delete from \"group\" where id = '{DeleteGroupAndStudentsTextBox.Text}'";

                        DataBaseCommands.DeleteRow(querrystring, DeleteGroupTextBox);
                        RefreshDataGrid(dataGridView1, querry);
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
                return;
            }
        }
        //Код выполняемый после закрытия формы
        private void ManageGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
        //Код для кнопки поиска по базу данных
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm) || DataBaseCommands.Search(searchTerm) == true)
            {

                string searchQuery = $"SELECT g.id, g.short_name, g.code, g.create_date, s.name AS speciality_name, CONCAT(t.name, ' ', t.surname) AS tutor_full_name " +
                                     $"FROM \"group\" g " +
                                     $"LEFT JOIN speciality s ON g.speciality_id = s.id " +
                                     $"LEFT JOIN tutor t ON g.tutor_id = t.id " +
                                     $"WHERE g.short_name ILIKE @searchTerm " +
                                     $"OR s.name ILIKE @searchTerm " +
                                     $"OR t.name ILIKE @searchTerm " +
                                     $"OR t.surname ILIKE @searchTerm";

                searchTerm = "%" + searchTerm + "%";

                RefreshDataGrid(dataGridView1, searchQuery, searchTerm);
            }
            else
            {
                RefreshDataGrid(dataGridView1, querry);
            }
        }
    }
}
