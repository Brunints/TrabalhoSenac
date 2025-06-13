int salariominimo, salariofuncionario, quantidadesalario;

Console.WriteLine("Digite o valor do salario minimo: ");
salariominimo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o salario do funcionario: ");
salariofuncionario = Convert.ToInt32(Console.ReadLine());

quantidadesalario = salariofuncionario / salariominimo;

Console.WriteLine("Você ganha " + quantidadesalario + " salario minimo");