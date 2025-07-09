using System.Data;
using Npgsql;

namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public partial class ManageSpecialty : Form
    {
        DataBase DataBase = new DataBase();
        DataBaseCommands DataBaseCommands = new DataBaseCommands();
        KeysHelper KeysHelper = new KeysHelper();

        public string tableName = "speciality";
        public string querry;
        public ManageSpecialty()
        {
            InitializeComponent();
        }
        //Код для кнопки добавления специальности
        private void AddSpecialtyButton_Click(object sender, EventArgs e)
        {
            AddSpecialty add = new AddSpecialty();
            add.ShowDialog();
        }
        //Код для кнопки редактирвоания специальности
        private void EditSpecialtyButton_Click(object sender, EventArgs e)
        {
            if (DataBaseCommands.CheckId($"select * from speciality where id = '{EditSpecialtyTextBox.Text}'", EditSpecialtyTextBox) == false)
            {
                EditSpecialty edit = new EditSpecialty();
                edit.id = EditSpecialtyTextBox.Text;
                edit.ShowDialog();

            }
            else
            {
                return;
            }
        }
        //Код для кнопки удаления специальности
        private void DeleteSpecialtyButton_Click(object sender, EventArgs e)
        {
            if (DeleteSpecialtyTextBox.Text != null)
            {
                try
                {
                    if (DataBaseCommands.CheckId($"select * from speciality where id = '{DeleteSpecialtyTextBox.Text}'", DeleteSpecialtyTextBox) == false)
                    {
                        DataBaseCommands.DeleteRow($"Delete from speciality where id = '{DeleteSpecialtyTextBox.Text}'", DeleteSpecialtyTextBox);

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
        //Код для кнопки обновления таблицы
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, tableName, querry);
        }

        private void ManageSpecialty_Load(object sender, EventArgs e)
        {
            querry = $"SELECT * FROM speciality";

            EditSpecialtyTextBox.MaxLength = 10;
            DeleteSpecialtyTextBox.MaxLength = 10;

            CreateColumns();
            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "ASC"));
        }
        //Метод для создания столбцов таблицы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Qualification", "Квалификация");
            dataGridView1.Columns.Add("Code", "Код");
            dataGridView1.Columns.Add("Description", "Описание");

            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[1].Width = 200;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        //Метод для чтения строк из базы данных
        public void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4));
        }
        //Метод для обновления таблицы
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
        //Метод сортировки специалньостей сверху вниз по id
        private void SortUpButton_Click(object sender, EventArgs e)
        {
            querry = $"SELECT * FROM speciality";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "ASC"));
        }
        //Метод сортировки специалньостей сверху вниз по id
        private void SortDownButton_Click(object sender, EventArgs e)
        {
            querry = $"SELECT * FROM speciality";

            RefreshDataGrid(dataGridView1, tableName, DataBaseCommands.Sorting(querry, "id", "DESC"));
        }
        //Код выполняемый при закрытии формы 
        private void ManageSpecialty_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.ClearConnection();
        }
        //Код для кнопки поиска по базе данных
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm) || DataBaseCommands.Search(searchTerm) == true)
            {
                string searchQuery = $"SELECT * FROM speciality " +
                                     $"WHERE name ILIKE @searchTerm OR qualification ILIKE @searchTerm OR code::text ILIKE @searchTerm";
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
