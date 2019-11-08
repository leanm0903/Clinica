using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public void SetEmpleado(int Id,string Nombre,string Apellido,string Usuario,String Clave)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Usuario = Usuario;
            this.Id = Id;
            this.Clave = Clave;
             

        }
        }
  
}
