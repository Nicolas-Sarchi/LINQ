using Tienda.classes;
using Tienda.view;
internal class Program
{
    private static void Main(string[] args)
    {
        TiendaABS tienda = new TiendaABS();
        MenuPrincipal menuPrincipal = new();
        int opcion;

        do
        {
            opcion = MenuPrincipal.MostrarMenu();

            switch (opcion)
            {
                case 1:

                    tienda.RegistrarProducto();
                    break;
                case 2:

                    tienda.RegistrarCategoria();
                    break;
                case 3:
                    tienda.ListarCategorias();
                    break;
                case 4:
                    tienda.ListarProductos();
                    break;
                default:
                    break;
            }


        } while (opcion != 6);

    }
}