int qtdLata, qtdGarrafa600, qtdGarrafa2L, totalMl, totalLitros;


Console.WriteLine("Digite quantas latas foram vendidas:");
qtdLata = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantas garrafas de 1litro foram vendidas:");
qtdGarrafa600 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantas garrafas de 2litros foram vendidas:");
qtdGarrafa2L = Convert.ToInt32(Console.ReadLine());

totalMl = (qtdLata * 350) + (qtdGarrafa600 * 600) + (qtdGarrafa2L * 2000);
totalLitros = totalMl / 1000;


Console.WriteLine("Foram comprados " + totalLitros + " de coca cola: ");