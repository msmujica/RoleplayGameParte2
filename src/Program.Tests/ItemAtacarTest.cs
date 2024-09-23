using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

namespace Program.Tests;

[TestClass]
[TestSubject(typeof(ItemAtacar))]
public class ItemAtacarTest
{

    [TestMethod]
    public void createItem()
    {
        //Se define el nombre del Item
        string nombre = "El poder";
        //Se define el valor de ataque del Item
        int valorataque = 90;
        //Se define el valor de magico
        bool magico = false;
        
        //Se crea una nueva instancia
        ItemAtacar Elpoder = new ItemAtacar(nombre, valorataque, magico);
        
        Assert.AreEqual(nombre, Elpoder.Nombre);//Se corrobora que el nombre del objeto sea el correcto("El poder")
        Assert.AreEqual(valorataque, Elpoder.ValorAtaque);//Se corrobora que el valor de ataque del objeto sea el correcto(90)
        Assert.AreEqual(magico, Elpoder.EsMagico);//Se corrobora que el valor es magico
    }
}