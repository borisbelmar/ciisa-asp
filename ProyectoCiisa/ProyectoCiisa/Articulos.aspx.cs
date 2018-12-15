using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace ProyectoCiisa
{
    public partial class _Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string nombre, descripcion, ficha, valor, fecha, foto;
            nombre = txtNombreArticulo.Text;
            descripcion = txtDescripcion.Text;
            ficha = txtFicha.Text;
            valor = txtValor.Text;
            fecha = txtFecha.Text;
            foto = imagePreview.ImageUrl;

            if (txtNombreArticulo.Text != "" && txtValor.Text != "" && txtFecha.Text != "")
            {
                if (op.InsertArticulo(nombre, descripcion, ficha, valor, fecha, foto))
                {
                    Response.Write("<script>window.alert('Ingresado')</script>");
                    txtID.Text = "";
                    txtNombreArticulo.Text = "";
                    txtDescripcion.Text = "";
                    txtFicha.Text = "";
                    txtValor.Text = "";
                    txtFecha.Text = "";
                    imagePreview.ImageUrl = "~/img/upload-placeholder.png";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló el ingreso')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Porfavor ingrese Nombre, Valor y Fecha')</script>");
            }
        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            if (subirFoto.HasFile)
            {
                string nombre_archivo = System.IO.Path.GetFileName(subirFoto.FileName);
                subirFoto.SaveAs(Server.MapPath("~/img/") + nombre_archivo);

                string ruta_archivo = "~/img/" + nombre_archivo;
                imagePreview.ImageUrl = ruta_archivo;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string id, nombre, descripcion, ficha, valor, fecha, foto;
            id = txtID.Text;
            nombre = txtNombreArticulo.Text;
            descripcion = txtDescripcion.Text;
            ficha = txtFicha.Text;
            valor = txtValor.Text;
            fecha = txtFecha.Text;
            foto = imagePreview.ImageUrl;

            if (txtID.Text != "")
            {
                if (op.ActualizarArticulo(id, nombre, descripcion, ficha, valor, fecha, foto))
                {
                    Response.Write("<script>window.alert('Actualizado')</script>");
                    txtID.Text = "";
                    txtNombreArticulo.Text = "";
                    txtDescripcion.Text = "";
                    txtFicha.Text = "";
                    txtValor.Text = "";
                    txtFecha.Text = "";
                    imagePreview.ImageUrl = "~/img/upload-placeholder.png";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló la actualización')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Ingrese ID del Artículo')</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            string id;
            id = txtID.Text;

            if (txtID.Text != "")
            {
                if (op.EliminarArticulo(id))
                {
                    Response.Write("<script>window.alert('Eliminado el registro ID " + id + "')</script>");
                    txtID.Text = "";
                    txtNombreArticulo.Text = "";
                    txtDescripcion.Text = "";
                    txtFicha.Text = "";
                    txtValor.Text = "";
                    txtFecha.Text = "";
                    imagePreview.ImageUrl = "~/img/upload-placeholder.png";
                }
                else
                {
                    Response.Write("<script>window.alert('Falló la eliminación')</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('Ingrese ID')</script>");
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            if (txtID.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                Articulo articulo = Operacion.ConsultarArticulo(id);
                if (articulo != null)
                {
                    txtID.Text = articulo.StrID;
                    txtNombreArticulo.Text = articulo.StrNombre;
                    txtDescripcion.Text = articulo.StrDescripcion;
                    txtFicha.Text = articulo.StrFichaTecnica;
                    txtFecha.Text = articulo.StrFecha;
                    txtValor.Text = articulo.StrValor;
                    imagePreview.ImageUrl = articulo.StrImagen;
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