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
    public double Subtotal { get; set;}
    

    public Producto ()
    {
        if (!File.Exists(Env.FileNamep))
        {
            File.WriteAllText(Env.FileNamep, "");
        }
    }
}
