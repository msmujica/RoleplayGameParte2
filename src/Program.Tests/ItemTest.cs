using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

//Definimos una clase Test para "Item"
[TestClass]
[TestSubject(typeof(Item))]
public class ItemTest
{ 
    [TestMethod]
    //Se testea la creacion del Item
    public void createItem()
    {
        //Se define el nombre del Item
        string nombre = "El poder";
        //Se define el valor de ataque del Item
        int valorataque = 90;
        //Se define el valor de ataque del Item
        int valordefensa = 10;
        
        //Se crea una nueva instancia
        Item Elpoder = new Item(nombre, valorataque, valordefensa);
        
        Assert.AreEqual(nombre, Elpoder.Nombre);//Se corrobora que el nombre del objeto sea el correcto("El poder")
        Assert.AreEqual(valorataque, Elpoder.ValorAtaque);//Se corrobora que el valor de ataque del objeto sea el correcto(90)
        Assert.AreEqual(valordefensa, Elpoder.ValorDefensa);//Se corrobora que el valor de defensa del objeto sea el correcto(10)

    }
}