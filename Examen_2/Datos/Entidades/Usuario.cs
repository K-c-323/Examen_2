using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Clave { get; set; }

        public Usuario()
        {

        }

        public Usuario(string codigo, string nombre, string clave)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
        }
    }
}
