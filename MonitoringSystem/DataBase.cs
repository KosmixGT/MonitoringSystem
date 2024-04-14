using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MonitoringSystem
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=MKVPC\SQLEXPRESS;Initial Catalog=MonitoringSystemDB;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        { 
            return sqlConnection;
        }
        public void CheckDBConnection()
        {
            System.Windows.Forms.MessageBox.Show($"{sqlConnection.State}");
        }
    }
}
