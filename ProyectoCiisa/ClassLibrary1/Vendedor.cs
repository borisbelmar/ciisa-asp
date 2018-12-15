using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string strID;
        private string strUsuario;
        private string strPassword;
        private string strCorreo;
        private string strFono;

        public Vendedor()
        {

        }

        public Vendedor(string strID, string strUsuario, string strPassword, string strCorreo, string strFono)
        {
            this.StrID = strID;
            this.StrUsuario = strUsuario;
            this.StrPassword = strPassword;
            this.StrCorreo = strCorreo;
            this.StrFono = strFono;
        }

        public string StrID { get => strID; set => strID = value; }
        public string StrUsuario { get => strUsuario; set => strUsuario = value; }
        public string StrPassword { get => strPassword; set => strPassword = value; }
        public string StrCorreo { get => strCorreo; set => strCorreo = value; }
        public string StrFono { get => strFono; set => strFono = value; }
    }
}
