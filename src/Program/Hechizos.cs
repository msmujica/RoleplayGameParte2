namespace Ucu.Poo.Roleplay;

public class Hechizos
{
    private string nombreHechizo;
    private int dañoHechizo;

    public string NombreHechizo
    {
        get { return nombreHechizo; }
        set { nombreHechizo = value; }
    }

    public int DañoHechizo
    {
        get { return dañoHechizo; }
        set { dañoHechizo = value; }
    }

    public Hechizos(string nombre, int daño)
    {
        this.NombreHechizo = nombre;
        this.DañoHechizo = daño;
    }
}