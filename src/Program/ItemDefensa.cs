namespace Ucu.Poo.Roleplay;

public class ItemDefensa : InterfaceDefensa, InterfaceItem

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

    private int valordefensa;
    public int ValorDefensa
    {
        get { return valordefensa; }
        set { valordefensa = value; }
    }

    private bool esMagico;

    public bool EsMagico
    {
        get { return esMagico; }
        set { esMagico = value; }
    }
    
	
    public ItemDefensa(string nombre, int valordefensa, bool esMagico)
    {
            this.Nombre = nombre;
            this.ValorDefensa = valordefensa;
            this.EsMagico = esMagico;
    }
}