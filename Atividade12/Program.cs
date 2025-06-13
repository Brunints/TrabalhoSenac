int salarioinicial = 0, salariofinal, salariocomaumento, aumento, porcentagem = 15, imposto = 8, valordoImposto;

Console.WriteLine("Digite o salario:");
salarioinicial = Convert.ToInt32(Console.ReadLine());

aumento = (salarioinicial * porcentagem) / 100;
salariocomaumento = salarioinicial + aumento;
valordoImposto = (salariocomaumento * imposto) / 100;
salariofinal = salariocomaumento - valordoImposto;

Console.WriteLine("O salario final foi de " + salariofinal);
Console.WriteLine("O salario inicial foi de " + salarioinicial);
Console.WriteLine("O salario com aumento foi de " + salariocomaumento);