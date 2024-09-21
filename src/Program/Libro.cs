using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace Ucu.Poo.Roleplay;

public class Libros
{
    private string nombreLibro;
    private ArrayList hechizos;

    public string NombreLibro
    {
        get { return nombreLibro; }
        set { nombreLibro = value; }
    }

    public ArrayList SetHechizos
    {
        get { return hechizos; }
        set { hechizos = value; }
    }

    public Libros(string nombreLibro)
    {
        this.NombreLibro = nombreLibro;
        this.hechizos = new ArrayList();
    }

    public string AddHechizo(Hechizos ponerHechizo)
    {
        bool existe = false;

        foreach (var g in this.hechizos)
        {
            if (((Hechizos)g).NombreHechizo == ponerHechizo.NombreHechizo)
            {
                Console.WriteLine("Ya tiene el hechizo");
                existe = true;
                return "Ya tiene el hechizo";
            }
        }

        if (!existe)
        {
            this.SetHechizos.Add(ponerHechizo);
        }
        
        return $"{ponerHechizo.NombreHechizo}";
    }

    public string DeleteHechizos(Hechizos sacarHechizo)
    {
        foreach (var g in this.hechizos)
        {
            if (((Hechizos)g).NombreHechizo == sacarHechizo.NombreHechizo)
            {
                this.SetHechizos.Remove(sacarHechizo);
            }
            else
            {
                return "No puedes eliminar un hechizo que no existe";
            }
        }

        return "Eliminado";
    }

    public string MisHechizos()
    {
        StringBuilder mostrar = new StringBuilder();
        foreach (var hechizo in this.SetHechizos)
        {
            mostrar.Append(hechizo);
        }
        return $"Los hechizos que tienes son {mostrar}";
    }
}