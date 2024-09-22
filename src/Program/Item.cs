using System;
using System.Numerics;

namespace Ucu.Poo.Roleplay;

public class Item
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

    public bool validacion(string nombre, int valorAtaque, int valorDefensa, bool esMagico)
    {
        bool valido = false;
	    
        if (valorAtaque > 0 && valorDefensa > 0 && nombre != null)
        {
            valido = true;
        }

        return valido;
    }
	
    public Item(string nombre, int valorataque, int valordefensa, bool esMagico)
    {
        bool valor = validacion(nombre, valorataque, valordefensa, esMagico);
        if (valor)
        {
            this.Nombre = nombre;
            this.ValorAtaque = valorataque;
            this.ValorDefensa = valordefensa;
            this.EsMagico = esMagico;
        }
    }
}