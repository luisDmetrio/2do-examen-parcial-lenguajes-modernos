using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace testAssp
{
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ReyesMagosEntities bas = new ReyesMagosEntities())
            {
                try
                {
                    Vecinos vecin = bas.Vecinos.Find(Convert.ToInt32(txtEliminar.Text));
                    bas.Vecinos.Remove(vecin);
                    bas.SaveChanges();
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