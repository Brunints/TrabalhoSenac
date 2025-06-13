int areaLosango, diagonalmenor, diagonalmaior;

Console.WriteLine("Digite diagonal menor");
diagonalmenor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite diagonal maior");
diagonalmaior = Convert.ToInt32(Console.ReadLine());

areaLosango = (diagonalmenor * diagonalmaior) / 2;

Console.WriteLine("A area do losango é " + areaLosango);
