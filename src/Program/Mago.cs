using System.Collections;


namespace Ucu.Poo.Roleplay;


public class Mago : InterfacePersonaje
{
    private Libros libro;
    public Libros Libro
    {
        get { return libro; }
        set { libro = value;  }
    }
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string genero;
    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }
    private int edad;
    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
    private int hp;
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    private int dmg;
    
    public int Dmg
    {
        get { return dmg; }
        set { dmg = value; }
    }
    
    private ArrayList item;
    public ArrayList Item
    {
        get { return item; }
        set { item = value; }
    }

    private bool vivo;
    public bool Vivo
    {
        get { return vivo; }
        set { vivo = value; }
    }
    
    public Mago(string Name, string Genero, int Edad, Libros grimorio)
    {
        this.Name = Name;
        this.Genero = Genero;   
        this.Edad = Edad;
        this.Dmg = 10;
        this.Hp = 100;
        this.Item = new ArrayList();
        this.Vivo = true;
        this.Libro = grimorio;
    }

    public int ValorAtaque()
    {   
        //Devuelve el daño que puede causar el Mago
        return this.Dmg;
    }

    public int ValorArmor()
    {
        //Devuelve la vida restante del Mago
        return this.Hp;
    }
    
    public void Atacar(InterfacePersonaje personaje)
    {   
        //Solo funciona si el elfo esta vivo
        if (this.Vivo == true){
            // Al recibir daño, se reduce la vida
            personaje.RestarVida(this.Dmg);
        }
        else
        {
            //No atacara si estas muerto
            Console.WriteLine("Estas Muerto.");
        }
    }
    
    public void AtacarWithHechizo(InterfacePersonaje personaje, Hechizos hechiz)
    {
        //Se verifica que el mago este vivo
        if (this.Vivo)
        {
                    //Recorremos la lista de hechizos en el libro
                    foreach (var h in (this.Libro.SetHechizos))
                    {
                        //Verifica si el nombre del hechizo es el mismo del libro
                        if (hechiz.NombreHechizo == ((Hechizos)h).NombreHechizo)
                        {
                            //Se calcula el daño total del mago(daño del mago + daño del hechizo)
                            int dañoTotal = ((Hechizos)h).DañoHechizo + this.Dmg;
                            //El objetivo recibe el daño
                            personaje.RestarVida(dañoTotal);
                            //Salimos del metodo
                            return;
                        }
                    }
            //Si no se encuentra el hechizo, no puede atacar
            Console.WriteLine("El hechizo no está en el grimorio.");
        }
        else
        {
            //Si el mago esta muerto, no puede atacar
            Console.WriteLine("El mago está muerto y no puede atacar.");
        }
    }
    
    //Metodo para poder curarze
    public void Heal()
    {
        if (this.Vivo == true){
            //Se aumenta la vida
            this.Hp += 25;
            //Se implementa el no poder aumentar la vida al llegar a 100 puntos
            if (this.Hp > 100)
            {
                this.Hp = 100;
            }
        }
        else
        {
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }    
    }
    //Metodo para reducir la vida en funcion del daño recibido
    public void RestarVida(int Daño)
    {   
        //Solo recibira daño si mago esta vivo
        if (this.Vivo == true)
        {   
            //Se reduce la vida en base al daño recibido
            this.Hp -= Daño;
            //Si la vida del mago llega a 0 o menos, este muere
            if (this.Hp <= 0)
            {
                this.Vivo = false;
            }
            else
            {
                Console.WriteLine("Estas Muerto.");
            }
        }
    }

    public void AddItem(Item nombre)
    {
        if (this.Vivo == true)
        {
            if(this.Item.Count < 2){
                this.Item.Add(nombre);
                this.Dmg += nombre.ValorAtaque;
                this.Hp += nombre.ValorDefensa;
            }
        }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }
    }

    public void DeleteItem(Item nombre)
    {
        if (this.Vivo == true){
            
            if (this.Item.Contains(nombre))
            {
                this.Item.Remove(nombre);
                this.Dmg -= nombre.ValorAtaque;
                this.Hp -= nombre.ValorDefensa;
            }
            else
            { 
                Console.WriteLine("No puedes eliminar un item que no existe");
            }
        }
        else
        {
            Console.WriteLine("Estas Muerto.");

        }
    }
}