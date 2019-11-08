using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaAccesoDatos;
using CapaEntidades;

namespace Clinica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string usu, pass;
            usu = txtUsuario.Text;
            pass = txtPassword.Text;
            Empleado emp = EmpleadoDao.getInstance().AccesoSistema(usu, pass);

            Response.Redirect(url: "panel general.aspx");
            
           

            

        }
    }
}