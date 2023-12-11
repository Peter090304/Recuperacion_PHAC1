using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_PHAC
{
    public class Inventario
    {
        private Nodo primerNodo;

        public Inventario()
        {
            primerNodo = null;
        }

        public void InsertarProducto(string nombre, double precio)
        {
            Nodo nuevoNodo = new Nodo(nombre, precio);
            nuevoNodo.Siguiente = primerNodo;
            primerNodo = nuevoNodo;
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            Nodo actual = primerNodo;
            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.Nombre}, Precio: {actual.Precio}");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
        public void OrdenarInventario()
        {
            Nodo actual = primerNodo;
            while (actual != null)
            {
                Nodo minNodo = actual;
                Nodo comparador = actual.Siguiente;

                while (comparador != null)
                {
                    if (comparador.Precio < minNodo.Precio)
                    {
                        minNodo = comparador;
                    }
                    comparador = comparador.Siguiente;
                }
                string tempNombre = actual.Nombre;
                double tempPrecio = actual.Precio;

                actual.Nombre = minNodo.Nombre;
                actual.Precio = minNodo.Precio;

                minNodo.Nombre = tempNombre;
                minNodo.Precio = tempPrecio;

                actual = actual.Siguiente;
            }
        }
        public Nodo BuscarPorPrecio(double precioBuscado)
        {
            Nodo actual = primerNodo;
            while (actual != null)
            {
                if (actual.Precio == precioBuscado)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }
    }
}



    
    