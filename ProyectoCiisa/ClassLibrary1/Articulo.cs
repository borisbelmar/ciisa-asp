using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Articulo
    {
        private string strID;
        private string strNombre;
        private string strDescripcion;
        private string strFicha;
        private string strValor;
        private string strFecha;
        private string strImagen;

        public Articulo()
        {

        }

        public Articulo(string strID, string strNombre, string strDescripcion, string strFichaTecnica, string strValor, string strFecha, string StrImagen)
        {
            this.StrID = strID;
            this.StrNombre = strNombre;
            this.StrDescripcion = strDescripcion;
            this.StrFichaTecnica = strFichaTecnica;
            this.StrValor = strValor;
            this.StrFecha = strFecha;
            this.StrImagen = StrImagen;
        }

        public string StrID { get => strID; set => strID = value; }
        public string StrNombre { get => strNombre; set => strNombre = value; }
        public string StrDescripcion { get => strDescripcion; set => strDescripcion = value; }
        public string StrFichaTecnica { get => strFicha; set => strFicha = value; }
        public string StrValor { get => strValor; set => strValor = value; }
        public string StrFecha { get => strFecha; set => strFecha = value; }
        public string StrImagen { get => strImagen; set => strImagen = value; }
    }
}
