decimal totalConta;
decimal parteCarlos, parteAndre;
int parteFelipe;

Console.Write("Digite o valor total da conta R$ : ");
totalConta = Convert.ToDecimal(Console.ReadLine());

parteFelipe = (int)Math.Ceiling(totalConta / 3);
decimal restante = totalConta - parteFelipe;
parteCarlos = restante / 2;
parteAndre = parteCarlos;

Console.WriteLine($"\nCarlos deve pagar: R$ {parteCarlos:F2}");
Console.WriteLine($"André deve pagar:  R$ {parteAndre:F2}");
Console.WriteLine($"Felipe deve pagar: R$ {parteFelipe},00");
