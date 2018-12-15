using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace ProyectoCiisa
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string usuario, password;
            usuario = txtUsuario.Text;
            password = txtPassword.Text;
            if (op.login(usuario, password))
            {
                Response.Redirect("Datos.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Datos Incorrectos')</script>");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}