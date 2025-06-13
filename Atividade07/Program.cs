int mes, dia, dias;

Console.WriteLine("Digite o dia dessa data:");
dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o mês:");
mes = Convert.ToInt32(Console.ReadLine());

dias = (mes - 1) * 30 + dia;

Console.WriteLine("Já se passaram " + dias + " dias desde o começo do ano");