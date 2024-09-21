using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Elfo))]
public class ElfoTests
{
    // Prueba la correcta inicialización de las propiedades del elfo.
    [TestMethod]
    public void TestInicializacionElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Verifica que el nombre sea correcto
        Assert.AreEqual("Thorin", elfo.Name);
        // Verifica que el género sea correcto
        Assert.AreEqual("Masculino", elfo.Genero);
        // Verifica que la edad sea correcta
        Assert.AreEqual(195, elfo.Edad);
        // Verifica que el HP inicial sea el valor por defecto
        Assert.AreEqual(100, elfo.Hp);
        // Verifica que el daño inicial sea el valor por defecto
        Assert.AreEqual(50, elfo.Dmg);
        // Verifica que el elfo esté vivo al ser creado
        Assert.IsTrue(elfo.EstoyVivo);
    }

    // Prueba los valores de ataque y defensa del elfo.
    [TestMethod]
    public void TestAtaqueYDefensaElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Verifica el valor de ataque
        Assert.AreEqual(50, elfo.ValorAtaque());
        // Verifica el valor de defensa o armadura
        Assert.AreEqual(100, elfo.ValorArmor());
    }

    // Prueba la funcionalidad de restar vida al elfo.
    [TestMethod]
    public void TestRestarVidaElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Resta 30 puntos de vida
        Assert.AreEqual(100, elfo.Hp); // Valor por defecto
        Assert.AreEqual(50, elfo.Dmg); // Valor por defecto
        Assert.IsTrue(elfo.EstoyVivo); // El personaje debe estar vivo al inicio
        Assert.AreEqual(50, elfo.ValorAtaque());
        Assert.AreEqual(100, elfo.ValorArmor());
        elfo.RestarVida(30);
        // Verifica que la vida restante sea la correcta
        Assert.AreEqual(70, elfo.Hp);
        // Verifica que el elfo siga vivo
        Assert.IsTrue(elfo.EstoyVivo);
    }

    // Prueba que el elfo muera correctamente cuando se le reduce la vida por debajo de 0.
    [TestMethod]
    public void TestMuerteElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Resta 150 puntos de vida, matando al elfo
        elfo.RestarVida(150);
        // Verifica que el elfo esté muerto
        Assert.IsFalse(elfo.EstoyVivo);
    }

    // Prueba que el elfo no pueda atacar a un mago si está muerto.
    [TestMethod]
    public void TestAtacarMagoSinVidaElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        Libros a = new Libros("Mi gran grimorio");
        Mago mago = new Mago("Gandalf", "Masculino", 100, a);
        // Mata al elfo
        elfo.RestarVida(150);
        // Intenta atacar al mago
        elfo.AtacarMago(mago);
        // Verifica que el mago no reciba daño porque el elfo está muerto
        Assert.AreEqual(100, mago.Hp);
    }

    // Prueba que el elfo pueda atacar a un enano y reducir su HP correctamente.
    [TestMethod]
    public void TestAtacarEnanoElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        Enano enano = new Enano("Thorin", "Masculino", 195);
        // El elfo ataca al enano
        elfo.AtacarEnano(enano);
        // Verifica que el enano pierda 50 puntos de vida
        Assert.AreEqual(50, enano.Hp);
    }

    // Prueba la funcionalidad de curar al elfo cuando está vivo.
    [TestMethod]
    public void TestCurarElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Resta algo de vida al elfo
        elfo.RestarVida(20); // HP actual = 80
        // Cura al elfo
        elfo.Heal();
        // Verifica que el HP se haya incrementado
        Assert.AreEqual(100, elfo.Hp); // Cura 25, pero no supera el máximo
    }

    // Prueba que un elfo muerto no pueda ser curado.
    [TestMethod]
    public void TestNoCuraElfoMuerto()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        // Mata al elfo
        elfo.RestarVida(150);
        // Intenta curar al elfo
        elfo.Heal();
        // Verifica que el HP no cambie porque está muerto
        Assert.AreEqual(-50, elfo.Hp);
    }

    // Prueba la funcionalidad de agregar y eliminar ítems del inventario del elfo.
    [TestMethod]
    public void TestAgregarYEliminarItemElfo()
    {
        Elfo elfo2 = new Elfo("Fujin", "Masculino", 195);
        Item espada = new Item("Espada", 10, 5);
        // Agrega un ítem al elfo
        elfo2.Additem(espada);
        // Verifica que el daño se haya incrementado por el ítem
        Assert.AreEqual(60, elfo2.Dmg);
        // Verifica que el HP se haya incrementado por el ítem
        Assert.AreEqual(105, elfo2.Hp);

        // Elimina el ítem del elfo
        elfo2.DeleteItem(espada);
        // Verifica que el ítem haya sido eliminado
        Assert.IsFalse(elfo2.Item.Contains(espada));
        // Verifica que el daño vuelva a su valor original
        Assert.AreEqual(50, elfo2.Dmg);
        // Verifica que el HP vuelva a su valor original
        Assert.AreEqual(100, elfo2.Hp);
    }
}
