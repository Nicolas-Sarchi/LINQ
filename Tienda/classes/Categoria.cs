namespace Tienda.classes;

public class Categoria
{
    public int Id { get; set;}
    public string Descripcion { get; set;}
    public Categoria()
    {
        if (!File.Exists(Env.FileNameC))
        {
            File.WriteAllText(Env.FileNameC, "");
        }
    }
}
