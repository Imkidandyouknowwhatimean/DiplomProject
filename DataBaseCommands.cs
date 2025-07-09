using System.Data;
using System.Globalization;
using Npgsql;
namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public class DataBaseCommands
    {
        DataBase DataBase = new DataBase();
        //Функция проверки id в базе даннных
        public bool CheckId(string querrystring, TextBox Tb)
        {
            DataBase.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dataTable = new DataTable();
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataBase.CloseConnection();
                    return false;
                }
                else
                {
                    MessageBox.Show("Номера не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tb.Text = "";
                    DataBase.CloseConnection();
                    return true;
                }
            }
            catch
            {
                return true;
            }
        }
        //Функция возврата id в базе данных
        public string GetId(string querrystring)
        {
            string id;
            DataBase.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());
            id = Convert.ToString(command.ExecuteScalar());
            return id;
        }
        //функция проверки параметра из принимаемой строки
        public bool Checker(string querrystring, TextBox Tb)
        {
            DataBase.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                DataBase.CloseConnection();
                return false;
            }
            else
            {
                DataBase.CloseConnection();
                return true;
            }
        }
        //Функция проверки даты на правильный ввод
        public bool IsValidDate(string Date)
        {
            DateTime createDate;
            if (!DateTime.TryParseExact(Date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out createDate))
            {
                MessageBox.Show("Неверный формат даты. Пожалуйста, используйте формат 'дд.мм.гггг'.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                DataBase.CloseConnection();
                return false;
            }
            else 
            {
                return true;
            }
        }
        //Функция создания SQL-команды и адаптера
        public void ExecuteCommandAndAdapter(string querrystring)
        {
            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
        //Функция удаления строки из базы данных
        public void DeleteRow(string querrystring, TextBox Tb)
        {
            DataBase.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand(querrystring, DataBase.GetConnection());

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Строка не была удалена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DataBase.CloseConnection();
                return;
            }
            else
            {

                MessageBox.Show("Строка успешно удалена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
                Tb.Text = "";
                return;

            }
        }
        //Функция сортировки по id 
        public string Sorting(string querrystring, string orderByColumn, string sortDirection)
        {
            DataBase.OpenConnection();

            string orderByClause = $"ORDER BY {orderByColumn} {sortDirection}";
            string querry = $"{querrystring} {orderByClause}";

            DataBase.CloseConnection();

            return querry;
        }
        //Функция заполнения полей таблиц
        public string FillFields(string querry, ComboBox NameCb)
        {
            DataBase.OpenConnection();

            NpgsqlCommand command = new NpgsqlCommand(querry, DataBase.GetConnection());
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    NameCb.Items.Add(reader.GetValue(0).ToString());
                }
            }

            DataBase.CloseConnection();

            return querry;
        }
        //Функция для поиска в базе данных
        public bool Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Введите строку для поиска!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
