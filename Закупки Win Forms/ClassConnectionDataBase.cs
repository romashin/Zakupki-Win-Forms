using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{    
    class DB
    {
       NpgsqlConnection sqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;Database=zakupkiDB;User Id = alexxmsk; Password = 2321");
        public void openConnnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        public void closeConnnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        public NpgsqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
