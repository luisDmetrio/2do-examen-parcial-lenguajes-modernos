using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testAssp
{
    public partial class Actualizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (ReyesMagosEntities actualizar = new ReyesMagosEntities())
            {
                try
                {
                    int idUsuario = Convert.ToInt32(txtIDmod.Text);
                    Response.Write("Eligio al usuario= " + txtIDmod.Text);
                    Vecinos vecinoChido = actualizar.Vecinos.Where(v => v.ID_Vecino == idUsuario).First();

                    if (txtNombre.Text.Length != 0)
                    {
                        vecinoChido.nombre = txtNombre.Text;
                    }


                    if (txtapellidoPaterno.Text.Length != 0)
                    {
                        vecinoChido.apellidoPaterno = txtapellidoPaterno.Text;
                    }



                    if (txtapellidoMaterno.Text.Length != 0)
                    {
                        vecinoChido.apellidoMaterno = txtapellidoMaterno.Text;
                    }

                actualizar.Entry(vecinoChido).State = System.Data.Entity.EntityState.Modified;
                actualizar.SaveChanges();

                }
                catch
                {
                    Response.Write("El ID solicitado no existe");
                    string script = string.Format("alert('EL ID NO EXISTE O A INGRESADO UNA LETRA EN LUGAR DE NUMERO');");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }

            }



        }
    }
}