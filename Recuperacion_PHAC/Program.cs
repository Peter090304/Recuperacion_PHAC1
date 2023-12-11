namespace Recuperacion_PHAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario.InsertarProducto("Producto A", 50);
            inventario.InsertarProducto("Producto B", 30);
            inventario.InsertarProducto("Producto C", 70);
            inventario.InsertarProducto("Producto D", 25);
            inventario.InsertarProducto("Producto E", 60);
            inventario.InsertarProducto("Producto F", 40);
            inventario.InsertarProducto("Producto G", 55);
            inventario.InsertarProducto("Producto H", 35);
            inventario.InsertarProducto("Producto I", 45);
            inventario.InsertarProducto("Producto J", 65);
            inventario.MostrarInventario();
            inventario.OrdenarInventario();
            Console.WriteLine("Inventario ordenado:");
            inventario.MostrarInventario();
            Console.Write("\nIngrese el precio a buscar: ");
            double precioBuscado;
            while (!double.TryParse(Console.ReadLine(), out precioBuscado))
            {
                Console.Write("Ingrese un valor válido para el precio: ");
            }

            Nodo nodoEncontrado = inventario.BuscarPorPrecio(precioBuscado);

            if (nodoEncontrado != null)
            {
                Console.WriteLine($"\nProducto con precio {precioBuscado} encontrado: Nombre: {nodoEncontrado.Nombre}, Precio: {nodoEncontrado.Precio}");
            }
            else
            {
                Console.WriteLine($"\nNo se encontró ningún producto con precio {precioBuscado}.");
            }
        }
    }
}







