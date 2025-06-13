int queijo, sanduiches, presunto, hamburguer;
Console.WriteLine("Digite a quantidade de sanduíches:");
sanduiches = Convert.ToInt32(Console.ReadLine());

queijo = sanduiches * 2 * 50;
presunto = sanduiches * 50;
hamburguer = sanduiches * 100;

Console.WriteLine("É necessário de " + (queijo / 1000) + "," + (queijo % 1000) + " kg de queijo.");
Console.WriteLine("É necessário de " + (presunto / 1000) + "," + (presunto % 1000) + " kg de presunto.");
Console.WriteLine("É necessário de " + (hamburguer / 1000) + "," + (hamburguer % 1000) + " kg de hambúrguer.");