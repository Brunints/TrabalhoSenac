decimal salario, vendas, comissao, salariofinal;

Console.WriteLine("Digite seu salario: ");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite suas vendas: ");
vendas = Convert.ToDecimal(Console.ReadLine());

comissao = vendas * 0.04m;

salariofinal = salario + comissao;

Console.WriteLine($"O seu salario final foi de: R${salariofinal} junto com uma comissão de {comissao}");