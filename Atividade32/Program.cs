int peso, quilos, gramas, pesoQuilos;

Console.WriteLine("Digite o peso :");
pesoQuilos = Convert.ToInt32(Console.ReadLine());

gramas = pesoQuilos * 1000;

Console.WriteLine("O peso em gramas é " + gramas);
