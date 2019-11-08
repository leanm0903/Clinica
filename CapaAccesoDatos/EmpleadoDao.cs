using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaAccesoDatos
{
   public class EmpleadoDao
    {
        #region "Patron Singleton"
           private static EmpleadoDao daoEmpleado=null;
        private EmpleadoDao() { }
        public  static EmpleadoDao getInstance()
        {
            if (daoEmpleado==null)
            {
                daoEmpleado = new EmpleadoDao(); 
            }
            return daoEmpleado;
        }
        #endregion
        public Empleado AccesoSistema(string user,string pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Empleado objEmpleado = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
              
                if (dr.Read())
                {
                    objEmpleado = new Empleado();
                    objEmpleado.Id = Convert.ToInt32(dr["Id"].ToString());
                    objEmpleado.Usuario = dr["usuario"].ToString();
                    objEmpleado.Nombre = dr["Nombre"].ToString();
                    objEmpleado.Apellido = dr["Apellido"].ToString();

                    objEmpleado.Clave = dr["clave"].ToString();
                }
            }
            catch (Exception ex)
            {
                objEmpleado = null;
                throw ex;
            }
            finally {
                conexion.Close();
            }
            return objEmpleado;
        } 
            
        
    }
}
