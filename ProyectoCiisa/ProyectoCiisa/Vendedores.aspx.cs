using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace ProyectoCiisa
{
    public partial class _Vendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string usuario, password, correo, fono;
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            correo = txtCorreo.Text;
            fono = txtFono.Text;

            if (txtUsuario.Text != "" && txtPassword.Text != "" && txtCorreo.Text != "" && txtFono.Text != "")
            {
                if (op.InsertVendedores(usuario, password, correo, fono))
                {
                    Response.Write("<script>window.alert('Ingresado')</script>");
                    txtID.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtCorreo.Text = "";
                    txtFono.Text = "";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Ingrese Usuario, contraseña, correo y teléfono')</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string id, usuario, password, correo, fono;
            id = txtID.Text;
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            correo = txtCorreo.Text;
            fono = txtFono.Text;

            if (txtID.Text != "")
            {
                if (op.ActualizarVendedores(id, usuario, password, correo, fono))
                {
                    Response.Write("<script>window.alert('Actualizado')</script>");
                    txtID.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtCorreo.Text = "";
                    txtFono.Text = "";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Porfavor, ingrese ID')</script>");
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string id;
            id = txtID.Text;

            if (txtID.Text != "")
            {
                if (op.EliminarVendedores(id))
                {
                    Response.Write("<script>window.alert('Eliminado el registro ID " + id + "')</script>");
                    txtID.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtCorreo.Text = "";
                    txtFono.Text = "";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló el borrado')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Porfavor, ingrese ID')</script>");
            }   
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            if (txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                Vendedor vendedor = Operacion.ConsultarVendedor(id);
                if (vendedor != null)
                {
                    txtID.Text = vendedor.StrID;
                    txtUsuario.Text = vendedor.StrUsuario;
                    txtPassword.Text = vendedor.StrPassword;
                    txtCorreo.Text = vendedor.StrCorreo;
                    txtFono.Text = vendedor.StrFono;
                }
                else
                {
                    Response.Write("<script>window.alert('Falló la consulta')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Porfavor, ingrese ID')</script>");
            }
        }
    }
}