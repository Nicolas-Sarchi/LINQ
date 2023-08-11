namespace Tienda.view;
public class MenuPrincipal
{
public MenuPrincipal(){}

    public static int MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\n--------------- Suer Tienda ABS ----------------");
        Console.WriteLine($"1. Registrar Producto");
        Console.WriteLine($"2. Registrar Categorìa");
        Console.WriteLine($"3. Listar Categorìas");
        Console.WriteLine($"4. Listar Productos");
        Console.WriteLine("5. Costo Total del Inventario");
        Console.WriteLine($"6. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }
}
