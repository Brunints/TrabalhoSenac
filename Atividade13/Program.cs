int centena, dezena, unidade, numero;

Console.WriteLine("Digite um numero até 3 digitos:");
numero = Convert.ToInt32(Console.ReadLine());

centena = numero / 100;
dezena = (numero % 100) / 10;
unidade = numero % 10;

Console.WriteLine("CENTENA = " + centena);
Console.WriteLine("DEZENA = " + dezena);
Console.WriteLine("UNIDADE = " + unidade);
