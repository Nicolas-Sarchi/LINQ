using Tienda.classes;
namespace Tienda.classes;
public class TiendaABS
{
    public List<Producto> Productos { get; set; }
    public List<Categoria> Categorias { get; set; }


    public TiendaABS() { }

    public void RegistrarCategoria()
    {
        if (Categorias == null)
        {
           Categorias = new List<Categoria>();
        }
        Console.Clear();
        Console.WriteLine("************ Registro Categorias *************");
        Console.Write("\nIngrese el id de la Categorìa: ");
        int idCategoria = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la descripciòn de la categorìa: ");
        string descripcion = Console.ReadLine();

        Categoria categoria = new (idCategoria, descripcion);
        Categorias.Add(categoria);
        Console.WriteLine("Categorìa agregada exitosamente");
        Console.ReadKey();
    }

    public void RegistrarProducto()
    {
        if (Productos == null)
        {
            Productos = new List<Producto>();
        }
        Console.Clear();
        Console.WriteLine("************ Registro Productos *************");
        Console.Write("\nIngrese el còdigo del producto: ");
        int codProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el Stock actual del producto: ");
        int stock = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Stock Mìnimo que puede tener el producto: ");
        int stockMin = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Stock Maximo que puede tener el producto: ");
        int stockMax = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Precio de venta del producto: ");
        double precioVenta = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el Precio de compra del producto: ");
        double precioCompra = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ID de la categoria a la que pertenece el producto: ");
        int idCategoria = int.Parse(Console.ReadLine());

        Producto producto = new Producto(codProducto, nombre, stock, stockMin, stockMax, precioVenta, precioCompra, idCategoria);
        Productos.Add(producto);
        Console.WriteLine("Producto agregado exitosamente");
        Console.ReadKey();
    }

    public void ListarCategorias()
    {
        Console.WriteLine("{0, -30} {1, 10}", "ID categoria", "Nombre Categoria");
        foreach (Categoria categoria in Categorias)
        {
            Console.WriteLine("{0, -30} {1, 10}", categoria.Id, categoria.Descripcion);

        }
        Console.ReadKey();
    }

    public void ListarProductos()
    {
        var Join = from p in Productos
                      join c in Categorias
                      on p.IdCategoria equals c.Id 
                      select new { 
                                    NombreProducto = p.Nombre,
                                    IdProducto = p.CodProducto,
                                    Stock = p.Stock,
                                    NombreCategoria = c.Descripcion
                                };
        Console.Clear();                        

        Console.WriteLine("{0, 5} {1, 20} {2,20} {3,20} ", "ID Producto", "Nombre Producto", "Stock", "Categoria" );
        
        foreach (var obj in Join)
        {
            Console.WriteLine("{0, 5} {1, 20} {2, 25} {3, 22}", obj.IdProducto, obj.NombreProducto, obj.Stock, obj.NombreCategoria);

        }                   
        Console.ReadKey();

    }


    public void CostoTotalInventario()
    {
        double totalInventario;
        foreach (Producto producto in Productos)
        {
            
        }
    }
}
