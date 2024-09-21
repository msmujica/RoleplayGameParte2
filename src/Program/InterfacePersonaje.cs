namespace Ucu.Poo.Roleplay;

public interface InterfacePersonaje
{   
    
    string Name { get; set; }
    string Genero { get; set; }
    int Edad { get; set; }
    int Hp { get; set; }
    int Dmg { get; set; }
    bool EstoyVivo { get; set; }
    
    public int ValorAtaque();
    public int ValorArmor();
    public void Heal();
    public void RestarVida(int daño);

    public void Atacar(InterfacePersonaje personaje);
    public void AddItem(Item nombre);
    public void DeleteItem(Item nombre);
    
    
}