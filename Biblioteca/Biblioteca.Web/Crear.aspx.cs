using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca.Web
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ServiceReferenceCliente.ClienteSClient cliente = new ServiceReferenceCliente.ClienteSClient();
            int id = int.Parse(txtId.Text);
            int edad = int.Parse(txtEdad.Text);
            string nombre = txtNombre.Text;

            bool estado = cliente.create(edad,id,nombre);
            if (estado==true)
            {
                lblMsj.Text = "Agregado";
            }
            else
            {
                lblMsj.Text = "Error al guardar";
            }
        }
    }
}