using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

namespace Program.Tests;

[TestClass]
[TestSubject(typeof(ItemDefensa))]
public class ItemDefensaTest
{

    [TestMethod]
    public void createItem()
    {
        //Se define el nombre del Item
        string nombre = "El poder";
        //Se define el valor de ataque del Item
        int valorDefensa = 10;
        //Se define el valor de magico
        bool magico = false;
        
        //Se crea una nueva instancia
        ItemDefensa Elpoder = new ItemDefensa(nombre, valorDefensa, magico);
        
        Assert.AreEqual(nombre, Elpoder.Nombre);//Se corrobora que el nombre del objeto sea el correcto("El poder")
        Assert.AreEqual(valorDefensa, Elpoder.ValorDefensa);//Se corrobora que el valor de defensa del objeto sea el correcto(90)
        Assert.AreEqual(magico, Elpoder.EsMagico);//Se corrobora que el valor es magico
    }
}