using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
Smartphone celular = new Iphone("982261851", "iPhone 14", "bla1bla2bla3", 256);
Console.WriteLine("Testando iPhone");
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativoPelaLojaDeApps();
celular.ListarAplicativos();
celular.DesinstalarAplicativo();

Smartphone celular2 = new Iphone("984064074", "Nokia C3", "bla1bla2bla4", 32);
Console.WriteLine("\n\n\nTestando Nokia");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativoPelaLojaDeApps();
celular2.ListarAplicativos();
celular2.DesinstalarAplicativo();