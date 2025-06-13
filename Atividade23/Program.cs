int alturaPessoa, sombraPessoa, sombraPredio, alturaPredio;

Console.WriteLine("Digite sua altura (em cm):");
alturaPessoa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comprimento da sua sombra (em cm):");
sombraPessoa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o comprimento da sombra do prédio (em cm):");
sombraPredio = Convert.ToInt32(Console.ReadLine());

alturaPredio = (alturaPessoa * sombraPredio) / sombraPessoa;

Console.WriteLine("A altura do prédio é aproximadamente " + alturaPredio + " cm.");
