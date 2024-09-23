namespace Ucu.Poo.Roleplay;

public interface ItemAtaqueDefensa : InterfaceAtaque, InterfaceDefensa, InterfaceItem

{
    {   
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private int ValorAtaque;

    public int valorAtaque
    {
        get { return valorAtaque; }
        set { valorAtaque = value}
    }
    private int ValorDefensa;
    
    public int valorDefensa
    {
        get { return valorDefensa; }
        set { valorDefensa = value }
    }
    
    private bool esMagico;

    public bool EsMagico
    {
        get { return esMagico; }
        set { esMagico = value; }
    }


    public ItemDefensa(string nombre, int valorAtaque, int valorDefensa, bool esMagico)
    {
        this.Nombre = nombre;
        this.ValorAtaque = valorAtaque;    
        this.ValorDefensa = valorDefensa;
        this.EsMagico = esMagico;
    }
}   
}