int qtd1, qtd5, qtd10, qtd25, qtd50, qtd100, totalCentavos, reais, centavos;

Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
qtd1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 5 centavos:");
qtd5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 10 centavos:");
qtd10 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 25 centavos:");
qtd25 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 50 centavos:");
qtd50 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 1 real:");
qtd100 = Convert.ToInt32(Console.ReadLine());

totalCentavos = (qtd1 * 1) + (qtd5 * 5) + (qtd10 * 10) + (qtd25 * 25) + (qtd50 * 50) + (qtd100 * 100);
reais = totalCentavos / 100;
centavos = totalCentavos % 100;

Console.WriteLine("Pedrinho economizou R$ " + reais + "," + centavos.ToString("D2"));
