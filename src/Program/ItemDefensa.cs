namespace Ucu.Poo.Roleplay;

public interface ItemDefensa : InterfaceDefensa, InterfaceItem

{   
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
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


    public ItemDefensa(string nombre, int valorDefensa, bool esMagico)
    {
        this.Nombre = nombre
        this.ValorDefensa = valorDefensa;
        this.EsMagico = esMagico;
    }
}