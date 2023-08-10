namespace Tienda.classes;
public class Producto
{
    public int CodProducto { get; set;}
    public string Nombre { get; set;}
    public int Stock { get; set;}
    public int StockMin { get; set;}
    public int StockMax { get; set;}
    public double PrecioVenta { get; set;}
    public double PrecioCompra { get; set;}
    public int IdCategoria { get; set;}
    

    public Producto ()
    {
        if (!File.Exists(Env.FileName))
        {
            File.WriteAllText(Env.FileName, "");
        }
    }
    public Producto (int codProducto, string nombre, int stock, int stockMin, int stockMax, double precioVenta, double precioCompra, int idCategoria)
    {
        CodProducto = codProducto;
        Nombre = nombre;
        Stock = stock;
        StockMin = stockMin;
        StockMax = stockMax;
        PrecioVenta = precioVenta;
        PrecioCompra = precioCompra;
        IdCategoria = idCategoria;
    }

    public double CalcularSubtotal()
    {
        return PrecioVenta * Stock;
    }
    
}
