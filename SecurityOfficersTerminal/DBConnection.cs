using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityOfficersTerminal
{
    class DBConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-AI3C159; Initial Catalog = TheKepeerPRO; Trusted_Connection=True");

        public void openConnection() // открытие подключения
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection() // закрытие подключения
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // возвращаем строку подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
