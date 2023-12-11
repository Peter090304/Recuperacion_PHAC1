using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_PHAC
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            Siguiente = null;
        }
    }
}
   
