int valorConta, parteCarlos, parteAndre, parteFelipe, reais, centavos;

Console.WriteLine("Digite o valor da conta em reais");
valorConta = Convert.ToInt32(Console.ReadLine());

parteCarlos = (valorConta / 100) / 3 * 100;
parteAndre = parteCarlos;
parteFelipe = valorConta - parteCarlos - parteAndre;

reais = parteCarlos / 100;
centavos = parteCarlos % 100;
Console.Write("Carlos deve pagar: R$" + reais + ",");
if (centavos < 10)
    Console.WriteLine("0" + centavos);
else
    Console.WriteLine(centavos);

reais = parteAndre / 100;
centavos = parteAndre % 100;
Console.Write("André deve pagar: R$" + reais + ",");
if (centavos < 10)
    Console.WriteLine("0" + centavos);
else
    Console.WriteLine(centavos);

reais = parteFelipe / 100;
centavos = parteFelipe % 100;
Console.Write("Felipe deve pagar: R$" + reais + ",");
if (centavos < 10)
    Console.WriteLine("0" + centavos);
else
    Console.WriteLine(centavos);