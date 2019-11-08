using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN
    {
        private static  EmpleadoLN objEmpleado;
        #region "Patron singleton"
        private EmpleadoLN()
        {

        }
        public static EmpleadoLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }
            return objEmpleado;
        }
        public Empleado AccesoSistema (string user,string passw)
        {
            Empleado empleado;
            try
            {
             empleado = EmpleadoDao.getInstance().AccesoSistema(user, passw);

            }
            catch (Exception e)
            {

                throw e;
            }
            return empleado;
        }
        #endregion
    }
}
