using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AttachedMode.Services_HomeWork2
{
    public class DropTableDB
    {
        public static void Drop()
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
                MessageBox.Show("Ошибка подключения:{0}", exeption.Message);
                return;
            }

            SqlCommand command = new SqlCommand("Drop Table Gruppa", connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException exeption)
            {

                MessageBox.Show("Ошибка при удалении таблицы");
                return;
            }
            MessageBox.Show("Таблица удалена успешно");
        }
    }
}
