using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Simples_para_lojas.Database_files.DAL
{
    class Connection
    {
        SqlConnection sqlCon = new SqlConnection();
        public Connection()
        {
            sqlCon.ConnectionString = @"Data Source=DESKTOP-VAUO858\SQLEXPRESS;Initial Catalog=SimpleERP;Integrated Security=True"; 
        }

        public SqlConnection Connect()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            return sqlCon;
        }
        public void Disconnect()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Close();
            }
        }
    }
}
