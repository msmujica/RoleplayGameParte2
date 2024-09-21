using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Enano))]
public class EnanoTests
{
    // Prueba la correcta inicialización de las propiedades del enano.
    [TestMethod]
    public void TestInicializacionEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Verifica que el nombre sea correcto
        Assert.AreEqual("Thorin", enano.Name);
        // Verifica que el género sea correcto
        Assert.AreEqual("Masculino", enano.Genero);
        // Verifica que la edad sea correcta
        Assert.AreEqual(195, enano.Edad);
        // Verifica que el HP inicial sea el valor por defecto
        Assert.AreEqual(100, enano.Hp);
        // Verifica que el daño inicial sea el valor por defecto
        Assert.AreEqual(50, enano.Dmg);
        // Verifica que el enano esté vivo al ser creado
        Assert.IsTrue(enano.EstoyVivo);
    }

    // Prueba los valores de ataque y defensa del enano.
    [TestMethod]
    public void TestAtaqueYDefensaEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Verifica el valor de ataque
        Assert.AreEqual(50, enano.ValorAtaque());
        // Verifica el valor de defensa o armadura
        Assert.AreEqual(100, enano.ValorArmor());
    }

    // Prueba la funcionalidad de restar vida al enano.
    [TestMethod]
    public void TestRestarVidaEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Resta 30 puntos de vida
        enano.RestarVida(30);
        // Verifica que la vida restante sea la correcta
        Assert.AreEqual(70, enano.Hp);
        // Verifica que el enano siga vivo
        Assert.IsTrue(enano.EstoyVivo);
    }

    // Prueba que el enano muera correctamente cuando se le reduce la vida por debajo de 0.
    [TestMethod]
    public void TestMuerteEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Resta 150 puntos de vida, matando al enano
        enano.RestarVida(150);
        // Verifica que el enano esté muerto
        Assert.IsFalse(enano.EstoyVivo);
    }

    // Prueba que el enano no pueda atacar a un mago si está muerto.
    [TestMethod]
    public void TestAtacarMagoSinVidaEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        Libros a = new Libros("Mi gran grimorio");
        Mago mago = new Mago("Gandalf", "Masculino", 100, a);
        // Mata al enano
        enano.RestarVida(150);
        // Intenta atacar al mago
        enano.AtacarMago(mago);
        // Verifica que el mago no reciba daño porque el enano está muerto
        Assert.AreEqual(100, mago.Hp);
    }

    // Prueba que el enano pueda atacar a un elfo y reducir su HP correctamente.
    [TestMethod]
    public void TestAtacarElfoEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        Elfo elfo = new Elfo("Legolas", "Masculino", 100);
        // El enano ataca al elfo
        enano.AtacarElfo(elfo);
        // Verifica que el elfo pierda 50 puntos de vida
        Assert.AreEqual(50, elfo.Hp);
    }

    // Prueba la funcionalidad de curar al enano cuando está vivo.
    [TestMethod]
    public void TestCurarEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Resta algo de vida al enano
        enano.RestarVida(20); // HP actual = 80
        // Cura al enano
        enano.Heal();
        // Verifica que el HP se haya incrementado, pero no más allá del máximo de 100
        Assert.AreEqual(100, enano.Hp);
    }

    // Prueba que un enano muerto no pueda ser curado.
    [TestMethod]
    public void TestNoCuraEnanoMuerto()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // Mata al enano
        enano.RestarVida(150);
        // Intenta curar al enano
        enano.Heal();
        // Verifica que el HP no cambie porque está muerto
        Assert.AreEqual(-50, enano.Hp);
    }

    // Prueba la funcionalidad de agregar y eliminar ítems del inventario del enano.
    [TestMethod]
    public void TestAgregarYEliminarItem()
    {
        Enano ENano = new Enano("Fujin", "Masculino", 195);
        Item espada = new Item("Espada", 10, 5);
        // Agrega un ítem al enano
        ENano.AddItem(espada);
        // Verifica que el daño se haya incrementado por el ítem
        Assert.AreEqual(60, ENano.Dmg);
        // Verifica que el HP se haya incrementado por el ítem
        Assert.AreEqual(105, ENano.Hp);

        // Elimina el ítem del enano
        ENano.DeleteItem(espada);
        // Verifica que el ítem haya sido eliminado
        Assert.IsFalse(ENano.Item.Contains(espada));
        // Verifica que el daño vuelva a su valor original
        Assert.AreEqual(50, ENano.Dmg);
        // Verifica que el HP vuelva a su valor original
        Assert.AreEqual(100, ENano.Hp);
    }
}
