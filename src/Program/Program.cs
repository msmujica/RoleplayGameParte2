using Ucu.Poo.Roleplay;

Elfo elfo = new Elfo("Thorin", "Masculino", 195);
Enano enano = new Enano("Thorin", "Masculino", 195);


Hechizos FireBall = new Hechizos("FireBall", 20);   // Crea hechizo con nombre y daño
Libros grimorio = new Libros("5 trvols");   //Se crea un libro de hechizos 
grimorio.AddHechizo(FireBall);  //Se agrega el hechizo al libro
Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);    
mago.AtacarWithHechizo(enano, FireBall);
Console.WriteLine(enano.Hp);