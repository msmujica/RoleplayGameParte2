using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;
//Definimos una clase de Test para "Libros"
[TestClass]
[TestSubject(typeof(Libros))]
public class LibroTest
{

    [TestMethod]
    // Testea la creacion del libro
    public void createLibro()
    {
        //Definimos el nombre del libro
        string nombre = "Grimorio de 5 Trevols";
        //Se crea nueva instancia 
        Libros book = new Libros(nombre);
        //Verificamos que el nombre del libro coincida con el nombre esperado
        Assert.AreEqual(nombre, book.NombreLibro);
    }

    [TestMethod]
    //Se testea la creacion de los hechizos 
    public void agregarHechizoTest()
    {   
        //Se define el nombre del libro
        string nombre = "Grimorio de 5 Trevols";
        //Creamos instancia de creacion de un nuevo
        Libros book = new Libros(nombre);
        //Creamos un hechizo
        Hechizos hechizos = new Hechizos("FireBall", 10);
        //Agregamos el hechizo al libro
        string resultado = book.AddHechizo(hechizos);
        //Verificamos que el hechizo agregado sea el predefinido
        Assert.AreEqual("FireBall", resultado);
    }

    [TestMethod]
    //Se testea la eliminacion de hechizos en los grimorios
    public void DeleteHechizoTest()
    {
        //Se define nuevamente el nombre del libro
        string nombre = "Grimorio de 5 Trevols";
        //Nueva instancia de "Libro"
        Libros book = new Libros(nombre);
        //Se crea un nuevo hechizo
        Hechizos hechizos = new Hechizos("FireBall", 10);
        //Se elimina el hechizo
        string resutlado = book.DeleteHechizos(hechizos);
        // Se verifica que la eliminacion del hechizo haya sido exitosa
        Assert.AreEqual("Eliminado", resutlado);
    }
    
    [TestMethod]
    //Se testea la visualizacion de los hechizos en el libro
    public void MisHechizoTest()
    {
        //Se define nombre del libro
        string nombre = "Grimorio de 5 Trevols";
        //Se crea nuevo libro
        Libros book = new Libros(nombre);
        //Obtenemos la lista de hechizos del libro y se verifica que coinciden con los esperados 
        Assert.AreEqual("Los hechizos que tienes son ", book.MisHechizos());
    }
}