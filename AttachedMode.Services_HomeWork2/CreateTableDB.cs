using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AttachedMode.Services_HomeWork2
{
    public class CreateTableDB
    {
        public static void Create()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DataBase"];

            var connectionString = settings.ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException exeption)
            {
                MessageBox.Show($"Ошибка подключения:\n {exeption.Message}");
                return;
            }

            SqlCommand command = new SqlCommand("CREATE TABLE Gruppa (Id int not null primary key identity, Name char(60) not null)", connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при создании таблицы");
                return;
            }

            MessageBox.Show("Таблица создана успешно\n");
        }
    }
}
