using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace AttachedMode.Services_HomeWork2
{
    public class CreatedDB
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
                if (exeption.Number == 4060)
                {
                    MessageBox.Show("Подождите идет создание базы данных");
                    connection.Close();
                    settings = ConfigurationManager.ConnectionStrings["tmpDataBase"];

                    connectionString = settings.ConnectionString;
                    connection = new SqlConnection(connectionString);
                    SqlCommand cmdCreateDataBase = new SqlCommand(string.Format("CREATE DATABASE [{0}]", "Database"), connection);
                    connection.Open();
                    MessageBox.Show("Посылаем запрос");
                    cmdCreateDataBase.ExecuteNonQuery();
                    connection.Close();
                    Thread.Sleep(2000);

                    settings = ConfigurationManager.ConnectionStrings["DataBase"];
                    connectionString = settings.ConnectionString;
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                }
            }
            finally
            {
                MessageBox.Show("Соединение успешно произведено");
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
