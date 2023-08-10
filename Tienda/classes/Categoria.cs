namespace Tienda.classes;

public class Categoria
{
    public int Id { get; set;}
    public string Descripcion { get; set;}

    public Categoria (int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}
