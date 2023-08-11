using Newtonsoft.Json;

namespace Tienda.classes;

public static class Env
{
    private static string fileNamep = "productos.json";
    private static string fileNameC = "categorias.json";

    private static List<Producto> productos = new();
    private static List<Categoria> categorias = new();

    public static string FileNamep { get => fileNamep; set => fileNamep = value; }
    public static string FileNameC { get => fileNameC; set => fileNameC = value; }

    public static List<Producto> Productos { get => productos; set => productos = value; }
    public static List<Categoria> Categorias { get => categorias; set => categorias = value; }

    public static void RegistrarProducto()
    {
        Producto producto = new();
        Console.Clear();
        Console.WriteLine("************ Registro Productos *************");
        Console.Write("\nIngrese el còdigo del producto: ");
        producto.CodProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del producto: ");
        producto.Nombre = Console.ReadLine();
        Console.Write("Ingrese el Stock actual del producto: ");
        producto.Stock = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Stock Mìnimo que puede tener el producto: ");
        producto.StockMin = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Stock Maximo que puede tener el producto: ");
        producto.StockMax = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Precio de venta del producto: ");
        producto.PrecioVenta = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el Precio de compra del producto: ");
        producto.PrecioCompra = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ID de la categoria a la que pertenece el producto: ");
        producto.IdCategoria = int.Parse(Console.ReadLine());

        Productos.Add(producto);

        string json = JsonConvert.SerializeObject(Productos, Formatting.Indented);
        File.WriteAllText(FileNamep, json);
        Console.WriteLine("Producto agregado exitosamente");
        Console.ReadKey();
    }
    public static void RegistrarCategoria()
    {
        Console.Clear();
        Categoria categoria = new();
        Console.WriteLine("************ Registro Categorias *************");
        Console.Write("\nIngrese el id de la Categorìa: ");
        categoria.Id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la descripciòn de la categorìa: ");
        categoria.Descripcion = Console.ReadLine();
        Categorias.Add(categoria);

        string json = JsonConvert.SerializeObject(Categorias, Formatting.Indented);
        File.WriteAllText(FileNameC, json);
        Console.WriteLine("Categorìa agregada exitosamente");
        Console.ReadKey();
    }
    public static void CargarProductos()
    {

        using StreamReader reader = new(FileNamep);

        string json = reader.ReadToEnd();
        Productos = System.Text.Json.JsonSerializer.Deserialize<List<Producto>>(json, new System.Text.Json.JsonSerializerOptions()
        { PropertyNameCaseInsensitive = true }) ?? new List<Producto>();
    }

    public static void CargarCategorias()
    {

        using StreamReader reader = new(FileNameC);

        string json = reader.ReadToEnd();
        Categorias = System.Text.Json.JsonSerializer.Deserialize<List<Categoria>>(json, new System.Text.Json.JsonSerializerOptions()
        { PropertyNameCaseInsensitive = true }) ?? new List<Categoria>();
    }

    public static void ListarCategorias()
    {
        CargarCategorias();
        Console.WriteLine("{0, -30} {1, 10}", "ID categoria", "Nombre Categoria");
        foreach (Categoria categoria in Categorias)
        {
            Console.WriteLine("{0, -30} {1, 10}", categoria.Id, categoria.Descripcion);

        }
        Console.ReadKey();
    }
    public static void ListarProductos()
    {
        var Join = from p in Productos
                   join c in Categorias
                   on p.IdCategoria equals c.Id
                   select new
                   {
                       NombreProducto = p.Nombre,
                       IdProducto = p.CodProducto,
                       p.Stock,
                       NombreCategoria = c.Descripcion
                   };
        Console.Clear();

        Console.WriteLine("{0, 5} {1, 20} {2,20} {3,20} ", "ID Producto", "Nombre Producto", "Stock", "Categoria");

        foreach (var obj in Join)
        {
            Console.WriteLine("{0, 5} {1, 20} {2, 25} {3, 22}", obj.IdProducto, obj.NombreProducto, obj.Stock, obj.NombreCategoria);

        }
        Console.ReadKey();

    }

    public static void CostoTotalInventario()
    {
        double totalInventario = 0;
        Console.Clear();
        Console.WriteLine("************ Costo Total Inventario *************");
        Console.WriteLine("\n{0, 5} {1, 20} {2, 20} {3, 20} {4, 20}", "ID Producto", "Nombre Producto", "Stock","Precio Unitario" ,"Subtotal");

        foreach (Producto producto in Productos)
        {
            producto.Subtotal = producto.Stock * producto.PrecioVenta;
            totalInventario += producto.Subtotal;
            Console.WriteLine("{0, 5} {1, 20} {2, 25} {3, 20} {4, 21}", producto.CodProducto, producto.Nombre, producto.Stock,"$"+producto.PrecioVenta, "$"+producto.Subtotal);
        }
        Console.WriteLine("\nPrecio Total Inventario: ${0}", totalInventario);
        Console.ReadKey();
    }
}
