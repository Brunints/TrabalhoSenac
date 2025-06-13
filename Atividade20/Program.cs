int blusas, novelos;
decimal resultado;
Console.WriteLine("Digite a quantidade de blusas produzidas:");
blusas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de novelos usados:");
novelos = Convert.ToInt32(Console.ReadLine());

resultado = novelos / blusas;

Console.WriteLine("Cada blusa consome em média " + resultado + " novelos de lã.");