int valorproduto, valordesconto, valorfinal;

Console.WriteLine("Digite o valor do produto");
valorproduto = Convert.ToInt32(Console.ReadLine());

valordesconto = valorproduto * 10 / 100;
valorfinal = valorproduto - valordesconto;

Console.WriteLine("O valor do produto foi " + valorfinal);