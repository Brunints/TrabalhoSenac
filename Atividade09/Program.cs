int TamanhoG = 15, TamanhoP = 10, TamanhoM = 12, valorfinal, qtdP = 0, qtdM = 0, qtdG = 0;


Console.WriteLine("Quantas blusas tamanho pequeno foi vendido");
qtdP = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantas blusas tamanho médio foi vendido");
qtdM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantas blusas tamanho grande foi vendido");
qtdG = Convert.ToInt32(Console.ReadLine());

valorfinal = (qtdP * TamanhoP) + (qtdM * TamanhoM) + (qtdG * TamanhoG);


Console.WriteLine("O valor arrecado foi de " + valorfinal);