using Npgsql;
namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    internal class DataBase
    {
        //Создание соединения с базой данных
        NpgsqlConnection connection = new NpgsqlConnection($"Host=localhost; Port=5432; Username=postgres; Password=admin; Database=UchetStudentov");
        //Открытие соединения
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //Закрытие соединения
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //Возвращение строки подключения
        public NpgsqlConnection GetConnection() => connection;
        //Очистка соединения
        public void ClearConnection()
        {
            CloseConnection();
            connection.Dispose(); 

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    }
}
