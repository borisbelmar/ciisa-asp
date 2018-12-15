using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Conexion
    {
        public SqlConnection getConexion()
        {
            try
            {
                string sqlServer1 = @"Data Source=PC-BORIS\SQLSERVER;Initial Catalog=CiisaTech;Integrated Security=True";
                string sqlServer2 = @"Data Source=DESKTOP-D2JGCDB\MSSQLSERVER1;Initial Catalog=CiisaTech;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(sqlServer2);
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
