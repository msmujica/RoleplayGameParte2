using System.Collections;


namespace Ucu.Poo.Roleplay;


public class Mago
{
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

        this.Item.Add(grimorio);
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
    //Metodo para atacar al Enano, con hechizos
    public void AtacarEnano(Enano personaje, Hechizos hechiz)
    {
        //Se verifica que el mago este vivo
        if (this.Vivo)
        {
            //Recoremos los objetos del inventario del mago
            foreach (var grimorio in this.Item)
            {
                //Se verifica si el objeto es de tipo "Libros"
                if (grimorio is Libros libros)
                {
                    //Recorremos la lista de hechizos en el libro
                    foreach (var h in libros.SetHechizos)
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
    //Metodo para atacar al Elfo, con hechizos
    public void AtacarElfo(Elfo personaje, Hechizos hechiz)
   {
       //Se verifica que el mago este vivo
       if (this.Vivo)
       {
           //Recoremos los objetos del inventario del mago
           foreach (var grimorio in this.Item)
           {
               //Se verifica si el objeto es de tipo "Libros"
               if (grimorio is Libros libros)
               {
                   //Recorremos la lista de hechizos en el libro
                   foreach (var h in libros.SetHechizos)
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

    public void Additem(Item nombre)
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