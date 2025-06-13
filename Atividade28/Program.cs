int nota1, nota2, media;

Console.WriteLine("Qual é a primeira nota?:");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual é a segunda nota");
nota2 = Convert.ToInt32(Console.ReadLine());

media = (nota1 * 2 + nota2 * 3) / 5;

Console.WriteLine("A nota foi " + media);