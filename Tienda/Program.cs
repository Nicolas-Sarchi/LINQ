using Tienda.classes;
using Tienda.view;


_ = new MenuPrincipal();
int opcion;
Env.CargarCategorias();
Env.CargarProductos();

do
{
    opcion = MenuPrincipal.MostrarMenu();

    switch (opcion)
    {
        case 1:
            Env.RegistrarProducto();
            break;
        case 2:
            Env.RegistrarCategoria();
            break;
        case 3:
            Env.ListarCategorias();
            break;
        case 4:
            Env.ListarProductos();
            break;
        case 5:
            Env.CostoTotalInventario();
            break;
        default:
            break;
    }

} while (opcion != 6);
