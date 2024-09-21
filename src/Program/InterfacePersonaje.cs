namespace Ucu.Poo.Roleplay;

public interface InterfacePersonaje
{   
    public int ValorAtaque();
    public int ValorArmor();
    public void Heal();
    public void RestarVida(int daño);

    public void Atacar(InterfacePersonaje personaje);
    public void AddItem(Item nombre);
    public void DeleteItem(Item nombre);
    
    
}