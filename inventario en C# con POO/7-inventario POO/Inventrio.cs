using System;
using System.Collections.Generic;

public class Inventario 
{
   public List<Producto> ListadeProductos { get; set; }
   public Inventario()
   {
      ListadeProductos = new List<Producto>();

      Producto a = new Producto("001", "iPhone xPlus", 10);
      Producto b = new Producto("002", "Laptop Dell Latitude", 15);
      Producto c = new Producto("003", "Monitor LG QLedg", 12);
      Producto d = new Producto("004", "MouseMouse optico Ergonomic", 100);
      Producto e = new Producto("005", "Headset bits", 50);

      ListadeProductos.Add(a);
      ListadeProductos.Add(b);
      ListadeProductos.Add(c);
      ListadeProductos.Add(d);
      ListadeProductos.Add(e);
   }
      
    public void listarProductos() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("***************THE PAWER***************");
        Console.WriteLine("*       Listado de Productos       *");
        Console.WriteLine("***************THE PAWER***************");
        Console.WriteLine("* Codigo, Descripcion y Existencia *");
        Console.WriteLine("***************THE PAWER***************");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    producto.Existencia = producto.Existencia + cantidad;
                } else {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

    public void ingresoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("***************THE PAWER****************");
        Console.WriteLine("* Ingreso de Productos al Inventario *");
        Console.WriteLine("****************THE PAWER****************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

    public void salidaDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("****************THE PAWER****************");
        Console.WriteLine("* Salida de Productos del Inventario *");
        Console.WriteLine("****************THE PAWER****************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }
    
    public void ajusteNegativoDelInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("****************THE PAWER****************");
        Console.WriteLine("*   Ajuste Negativo del Inventario   *");
        Console.WriteLine("****************THE PAWER****************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }

    public void ajustePositivoDelInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("****************THE PAWER****************");
        Console.WriteLine("*   Ajuste Positivo del Inventario   *");
        Console.WriteLine("****************THE PAWER****************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

}