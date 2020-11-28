using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testAssp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (ReyesMagosEntities db = new ReyesMagosEntities())
            {
                try
                {
                    Vecinos vecino = new Vecinos();
                    vecino.nombre = txtNombre.Text;
                    vecino.apellidoPaterno = txtapellidoPaterno.Text;
                    vecino.apellidoMaterno = txtapellidoMaterno.Text;
                    vecino.Clave_colonia = Convert.ToInt32(txtColonia.Text);
                    vecino.Clave_Ciudad = Convert.ToInt32(txtCiudad.Text);
                    vecino.Clave_ReyMago = Convert.ToInt32(txtRey.Text);
                    vecino.Clave_grupo = Convert.ToInt32(txtGrupo.Text);

                    db.Vecinos.Add(vecino);
                    db.SaveChanges();

                }
                catch
                {
                    string script = string.Format("alert('EL ID NO EXISTE O A INGRESADO UNA LETRA EN LUGAR DE NUMERO');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }


            }


        }
    }
}