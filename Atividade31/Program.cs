int peso, engordar, emagrecer;

Console.WriteLine("Digite o peso atual: ");
peso = Convert.ToInt32(Console.ReadLine());

engordar = peso + (peso * 15 / 100);
emagrecer = peso - (peso * 20 / 100);

Console.WriteLine("Peso se engordar 15%: " + engordar);
Console.WriteLine("Peso se emagrecer 20%: " + emagrecer);