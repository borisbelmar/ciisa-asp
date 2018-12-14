using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class Operacion
    {
        public bool InsertVendedores(string usuario, string password, string correo, string fono)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "Insert into Vendedores values('"+usuario+"', '"+password+"', '"+correo+"', '"+fono+"')";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
