using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Mago))]
public class MagoTest
{
    [TestMethod]
    //Se testea la instancia para atacar al Enano
    public void testAtacarEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195); //Crea un enano con nombre, genero, y HP
        Hechizos FireBall = new Hechizos("FireBall", 20);   // Crea hechizo con nombre y daño
        Libros grimorio = new Libros("5 trvols");   //Se crea un libro de hechizos 
        grimorio.AddHechizo(FireBall);  //Se agrega el hechizo al libro
        
        
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea una instancia de mago con sus respectivos datos
        
        mago.Atacar(enano);  //El mago ataca al enano

        Assert.AreEqual(90, enano.Hp);  //Verifica que el HP del Enano se haya reducido 90 despues del ataque 
    }
    
    [TestMethod]
    //Se testea el ataque hacia el Elfo
    public void testAtacarElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);   //Crea una instancia de elfo 

        Hechizos FireBall = new Hechizos("FireBall", 20);   //Crea un hechizo con nombre y potencia
        Libros grimorio = new Libros("5 trvols");   //Crea un libro de hechizos 
        grimorio.AddHechizo(FireBall);  //Agrega el hechizo al libro
        
        
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio); //Crea intancia mago con sus caracteristicas
        
        mago.Atacar(elfo);    //El mago ataca al Elfo 

        Assert.AreEqual(90, elfo.Hp);   //Verifica que el HP del Elfo se haya reducido 90 luego del ataque
    }
    
    [TestMethod]
    //Se testea el ataque hacia el Elfo
    public void testAtacarConHechizoElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);   //Crea una instancia de elfo 

        Hechizos FireBall = new Hechizos("FireBall", 20);   //Crea un hechizo con nombre y potencia
        Libros grimorio = new Libros("5 trvols");   //Crea un libro de hechizos 
        grimorio.AddHechizo(FireBall);  //Agrega el hechizo al libro
        
        
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio); //Crea intancia mago con sus caracteristicas
        
        mago.AtacarWithHechizo(elfo, FireBall);    //El mago ataca al Elfo 

        Assert.AreEqual(70, elfo.Hp);   //Verifica que el HP del Elfo se haya reducido 70 luego del ataque
    }

    [TestMethod]
    public void testValorAtaque()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas

        int valorEsperado = 10; //Define el valor esperado para el ataque
        
        Assert.AreEqual(valorEsperado, mago.ValorAtaque()); //Verifica que el valor de ataque del mago es 10
    }

    [TestMethod]
    public void testValorAramadura()
    {
        Libros grimorio = new Libros("5 trvols"); //Crea libro de hechizos 
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas

        int valorEsperado = 100; //Define el valor esperado para la armadura
        
        Assert.AreEqual(valorEsperado, mago.ValorArmor());  //Verifica que el valor de la armadura es 100
    }

    [TestMethod]
    public void testHeal()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas

        int valorEsperado = 100; //Define el valor esperado para la cura
        mago.Heal();
        
        Assert.AreEqual(valorEsperado, mago.Hp); //Verifica que el HP del mago aumentó luego de ser sanado
    }

    [TestMethod]
    public void testRestarVida()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas

        int valorEsperado = 80;     //Define el valor esperado para la resta de vida
        mago.RestarVida(20);    //El mago pierde 20 puntos de vida
        
        Assert.AreEqual(valorEsperado, mago.Hp);    //Verifica que la vida del mago fue reducida
    }

    [TestMethod]
    public void testAddItemAtaque()
    {
        Libros grimorio = new Libros("5 trvols"); //Crea libro de hechizos 
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemAtacar espada = new ItemAtacar("Espada", 10,  true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        Assert.AreEqual(100, mago.Hp);  //Verifica que el Hp del mago aumenta
        Assert.AreEqual(20, mago.Dmg);  //Verifica que el daño del mago aumenta
    }
    
    [TestMethod]
    public void testAddItemDefensa()
    {
        Libros grimorio = new Libros("5 trvols"); //Crea libro de hechizos 
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemDefensa espada = new ItemDefensa("Espada", 10,  true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        Assert.AreEqual(110, mago.Hp);  //Verifica que el Hp del mago aumenta
        Assert.AreEqual(10, mago.Dmg);  //Verifica que el daño del mago aumenta
    }
    
    [TestMethod]
    public void testAddItemAtaqueDefensa()
    {
        Libros grimorio = new Libros("5 trvols"); //Crea libro de hechizos 
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemAtacarDefensa espada = new ItemAtacarDefensa("Espada", 10, 10, true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        Assert.AreEqual(110, mago.Hp);  //Verifica que el Hp del mago aumenta
        Assert.AreEqual(20, mago.Dmg);  //Verifica que el daño del mago aumenta
    }

    [TestMethod]
    public void testDeleteItemAtacar()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemAtacar espada = new ItemAtacar("Espada", 10, true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        mago.DeleteItem(espada);    //Elimina el item al mago
        Assert.AreEqual(100, mago.Hp); // Verifica que el HP del mago vuelve a 100 después de eliminar la espada
        Assert.AreEqual(10, mago.Dmg);  // Verifica que el daño del mago vuelve a 10 después de eliminar la espada
    }
    
    [TestMethod]
    public void testDeleteItemDefensa()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemDefensa espada = new ItemDefensa("Espada", 10, true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        mago.DeleteItem(espada);    //Elimina el item al mago
        Assert.AreEqual(100, mago.Hp); // Verifica que el HP del mago vuelve a 100 después de eliminar la espada
        Assert.AreEqual(10, mago.Dmg);  // Verifica que el daño del mago vuelve a 10 después de eliminar la espada
    }
    
    [TestMethod]
    public void testDeleteItemAtacarDefensa()
    {
        Libros grimorio = new Libros("5 trvols");   //Crea libro de hechizos
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    //Crea intancia mago con sus caracteristicas
        ItemAtacarDefensa espada = new ItemAtacarDefensa("Espada", 10,10, true);    //Crea un item con daño y defensa
        
        mago.AddItem(espada);   //Agrega item al mago
        mago.DeleteItem(espada);    //Elimina el item al mago
        Assert.AreEqual(100, mago.Hp); // Verifica que el HP del mago vuelve a 100 después de eliminar la espada
        Assert.AreEqual(10, mago.Dmg);  // Verifica que el daño del mago vuelve a 10 después de eliminar la espada
    }
}