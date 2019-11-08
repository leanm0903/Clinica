using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    class Conexion
    {
        #region "Patron Singleton"
        private static Conexion conexion = null;
        public Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion==null)
            {
                conexion = new Conexion();

            }
            return conexion; 
        }


        #endregion
        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=Clinica;Trusted_Connection=True;MultipleActiveResultSets=true";
            return conexion;
                }
    }
}
   
