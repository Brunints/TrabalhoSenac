int nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota do aluno");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
nota3 = Convert.ToInt32(Console.ReadLine());

media = (nota1 * 1 + nota2 * 2 + nota3 * 3) / 6;

Console.WriteLine("A média ponderada é: " + media);