int cavalos = 0, ferraduras;

Console.WriteLine("Quantos cavalos possui no haras");
cavalos = Convert.ToInt32(Console.ReadLine());

ferraduras = cavalos * 4;

Console.WriteLine("Para equipar todos os cavalos do haras com ferraduras será necessário de " + ferraduras);