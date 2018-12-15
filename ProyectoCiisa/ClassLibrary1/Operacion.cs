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

        public bool login(string usuario, string password)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "SELECT * FROM Administradores WHERE admin_usuario='"+usuario+"' and admin_password='"+password+"'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                SqlDataReader loginData = cmd.ExecuteReader();
                if(loginData.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                // int n = cmd.ExecuteNonQuery();
                // return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertVendedores(string usuario, string password, string correo, string fono)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "INSERT INTO Vendedores VALUES('"+usuario+"', '"+password+"', '"+correo+"', '"+fono+"')";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarVendedores(string id, string usuario, string password, string correo, string fono)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "UPDATE Vendedores SET vendedores_usuario = '"+ usuario +"', vendedores_password = '"+ password + "', vendedores_correo = '" + correo + "' , vendedores_fono = '" + fono + "' WHERE vendedores_ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarVendedores(string id)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "DELETE FROM Vendedores WHERE vendedores_ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Vendedor ConsultarVendedor(int id)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "select * from Vendedores where vendedores_ID='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int intFilasAfectadas = cmd.ExecuteNonQuery();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.StrID = Convert.ToString(sqlDataReader.GetInt32(0));
                    vendedor.StrUsuario = sqlDataReader.GetString(1);
                    vendedor.StrPassword = sqlDataReader.GetString(2);
                    vendedor.StrCorreo = sqlDataReader.GetString(3);
                    vendedor.StrFono = sqlDataReader.GetString(4);

                    sqlDataReader.Close();
                    return vendedor;
                }
                else
                {
                    sqlDataReader.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool InsertArticulo(string nombre, string descripcion, string ficha, string valor, string fecha, string foto)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "INSERT INTO Articulos(articulos_nombre, articulos_descripcion, articulos_ficha, articulos_valor, articulos_fecha, articulos_foto) VALUES('" + nombre + "', '" + descripcion + "', '" + ficha + "', '" + valor + "', '"+ fecha + "' , '" + foto + "')";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarArticulo(string id, string nombre, string descripcion, string ficha, string valor, string fecha, string foto)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "UPDATE Articulos SET articulos_nombre = '"+ nombre +"', articulos_descripcion = '"+ descripcion +"', articulos_ficha = '"+ ficha +"', articulos_valor = '"+ valor +"', articulos_fecha = '"+ fecha +"', articulos_foto = '"+ foto +"'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarArticulo(string id)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "DELETE FROM Articulos WHERE articulos_ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Articulo ConsultarArticulo(int id)
        {
            Conexion cn = new Conexion();
            try
            {
                string sql = "select * from Articulos where articulos_ID='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn.getConexion());
                int intFilasAfectadas = cmd.ExecuteNonQuery();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.StrID = Convert.ToString(sqlDataReader.GetInt32(0));
                    articulo.StrNombre = sqlDataReader.GetString(1);
                    articulo.StrDescripcion = sqlDataReader.GetString(2);
                    articulo.StrFichaTecnica = sqlDataReader.GetString(3);
                    articulo.StrValor = sqlDataReader.GetString(4);
                    articulo.StrFecha = sqlDataReader.GetString(5);
                    articulo.StrImagen = sqlDataReader.GetString(6);

                    sqlDataReader.Close();
                    return articulo;
                }
                else
                {
                    sqlDataReader.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
