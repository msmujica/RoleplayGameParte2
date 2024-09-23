using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

namespace Program.Tests;

[TestClass]
[TestSubject(typeof(ItemAtacarDefensa))]
public class ItemAtacarDefensaTest
{

    [TestMethod]
    public void createItem()
    {
        //Se define el nombre del Item
        string nombre = "El poder";
        //Se define el valor de ataque del Item
        int valorAtaque = 90;
        //Se define el valor de defensa del Item
        int valorDefensa = 10;
        //Se define el valor de magico
        bool magico = false;
        
        //Se crea una nueva instancia
        ItemAtacarDefensa Elpoder = new ItemAtacarDefensa(nombre, valorAtaque, valorDefensa, magico);
        
        Assert.AreEqual(nombre, Elpoder.Nombre);//Se corrobora que el nombre del objeto sea el correcto("El poder")
        Assert.AreEqual(valorAtaque, Elpoder.ValorAtaque);//Se corrobora que el valor de ataque del objeto sea el correcto(90)
        Assert.AreEqual(valorDefensa, Elpoder.ValorDefensa);//Se corrobora que el valor de defensa del objeto sea el correcto(10)
        Assert.AreEqual(magico, Elpoder.EsMagico);//Se corrobora que el valor es magico
    }
}