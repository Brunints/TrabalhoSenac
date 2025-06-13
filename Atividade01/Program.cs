int largura = 0, comprimento = 0, area = 0;


Console.WriteLine("Digite a largura do terreno");
largura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comprimento largura");
comprimento = Convert.ToInt32(Console.ReadLine());

area = comprimento * largura;

Console.WriteLine("A área do terreno é: " + area + " metros quadrados.");
Console.WriteLine("Dimensões do terreno: " + largura + "m x " + comprimento + "m");