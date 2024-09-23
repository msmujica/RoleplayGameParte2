namespace Ucu.Poo.Roleplay;

public class ItemAtacar : InterfaceAtaque, InterfaceItem
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private int valorataque;
    public int ValorAtaque
    {
        get { return valorataque; }
        set { valorataque = value; }
    }

    private bool esMagico;

    public bool EsMagico
    {
        get { return esMagico; }
        set { esMagico = value; }
    }
	
    public ItemAtacar(string nombre, int valorataque, bool esMagico)
    {
            this.Nombre = nombre;
            this.ValorAtaque = valorataque;
            this.EsMagico = esMagico;
     
    }
    
}