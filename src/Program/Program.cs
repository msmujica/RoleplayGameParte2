using Ucu.Poo.Roleplay;

Elfo elfo2 = new Elfo("Fujin", "Masculino", 195);
ItemAtacar espada = new ItemAtacar("Espada", 5, false);
// Agrega un ítem al elfo
elfo2.AddItem(espada);
Console.WriteLine(elfo2.Dmg);
elfo2.DeleteItem(espada);
