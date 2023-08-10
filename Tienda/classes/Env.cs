namespace Tienda.classes;

public static class Env
{
    private static string fileName = "productos.json"; 
    private static List<Producto> productos = new ();

    public static string FileName { get => fileName; set => fileName = value; }
    public static List<Producto> Productos {get => productos; set => productos = value; }
}
