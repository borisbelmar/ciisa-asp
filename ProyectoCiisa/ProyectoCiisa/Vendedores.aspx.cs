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

        protected void btnVendedores_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string usuario, password, correo, fono;
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            correo = txtCorreo.Text;
            fono = txtFono.Text;
            if (op.InsertVendedores(usuario, password, correo, fono)) {
                Response.Write("<script>window.alert('Ingresado')</script>");
            } else
            {
                Response.Write("<script>window.alert('Falló')</script>");
            }
        }
    }
}