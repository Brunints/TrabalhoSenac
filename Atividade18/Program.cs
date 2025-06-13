int horasNormais, horasExtras, salarioBruto, salarioLiquido;

Console.WriteLine("Digite quantas horas normais ele trabalhou:");
horasNormais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantas horas extra ele trabalhou:");
horasExtras = Convert.ToInt32(Console.ReadLine());

salarioBruto = (horasNormais * 10) + (horasExtras * 15);
salarioLiquido = salarioBruto - (salarioBruto * 10 / 100);

Console.WriteLine("Salário bruto: R$" + salarioBruto);
Console.WriteLine("Salário líquido: R$" + salarioLiquido);