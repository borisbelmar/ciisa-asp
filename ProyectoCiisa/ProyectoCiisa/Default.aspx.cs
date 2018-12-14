using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCiisa
{
    public partial class _Default : Page
    {

        String strNombreUsuario = null;
        String strPasswordUsuario = null;

        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            this.strNombreUsuario = this.txtUsuario.Text;
            this.strPasswordUsuario = this.txtPassword.Text;
            //Response.Write("Bienvenido " + strNombreUsuario + ". Ingresaste con la contraseña: " + strPasswordUsuario);
            Response.Redirect("Datos.aspx");
        }
    }
}