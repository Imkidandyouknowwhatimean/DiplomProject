using System.Data;
using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class ManageTutors : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();
        public ManageTutors()
        {
            InitializeComponent();
        }
        private static string tableName = "tutor";
        private string querry = null!;

        private void ManageTutors_Load(object sender, EventArgs e)
        {
            EditTutorTextBox.MaxLength = 10;
            DeleteTutorTextBox.MaxLength = 10;

            querry = $"SELECT * FROM tutor ";

            CreateColumns();
            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "ASC"));
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

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;

            EditTutorTextBox.MaxLength = 5;
            DeleteTutorTextBox.MaxLength = 5;

            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        //Метод чтения строк из базы данных
        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5));
        }
        //Метод обновления таблицы
        public void RefreshDataGrid(DataGridView dgv, string table, string queryString, string searchTerm = null)
        {
            dgv.Rows.Clear();
            using (NpgsqlCommand command = new NpgsqlCommand(queryString, DataBase.GetConnection()))
            {
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
        //Код кнопки добавления руководителя
        private void AddTutorButton_Click(object sender, EventArgs e)
        {
            AddTutor add = new AddTutor();
            add.ShowDialog();
        }
        //Код для кнопки редактирования руководителя
        private void EditTutorButton_Click(object sender, EventArgs e)
        {
            if (DataBaseCommands.CheckId($"select * from tutor where id = '{EditTutorTextBox.Text}'", EditTutorTextBox) == false)
            {
                EditTutor edit = new EditTutor();
                edit.id = EditTutorTextBox.Text;
                edit.ShowDialog();
            }
            else
            {
                return;
            }
        }
        //Код для кнопки сортировки руководителей сверху вниз по id 
        private void SortButtonUp_Click(object sender, EventArgs e)
        {
            querry = $"SELECT * FROM tutor";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "ASC"));

        }
        //Код для кнопки сортировки руководителей снизу вверх по id 
        private void SortButtonDown_Click(object sender, EventArgs e)
        {
            querry = $"SELECT * FROM tutor";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "DESC"));
        }
        //Код кнопки обновления 
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, tableName, querry);
        }
        //Код кнопки удаления руководителя
        private void DeleteTutorButton_Click(object sender, EventArgs e)
        {
            if (DeleteTutorTextBox.Text != null)
            {
                try
                {
                    if (DataBaseCommands.CheckId($"select * from tutor where id = '{DeleteTutorTextBox.Text}'", DeleteTutorTextBox) == false)
                    {
                        DataBaseCommands.DeleteRow($"Delete from tutor where id = '{DeleteTutorTextBox.Text}'", DeleteTutorTextBox);

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
                return;
            }
        }
        //Код выполняющийся при закрытии формы
        private void ManageTutors_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
        //Код кнопки поиска по базе данных
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm) || DataBaseCommands.Search(searchTerm) == true)
            {
                string searchQuery = $"SELECT * FROM tutor " +
                                     $"WHERE name ILIKE @searchTerm OR surname ILIKE @searchTerm OR patronymic ILIKE @searchTerm " +
                                     $"OR phone_number ILIKE @searchTerm OR email ILIKE @searchTerm";

                searchTerm = "%" + searchTerm + "%";

                RefreshDataGrid(dataGridView1, tableName, searchQuery, searchTerm);
            }
            else
            {
                RefreshDataGrid(dataGridView1, tableName, querry);
            }
        }
    }
}
