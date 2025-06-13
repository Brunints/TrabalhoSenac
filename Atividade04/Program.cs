string nome;
int idade, diasdevida;

Console.WriteLine("Digite o seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade");
idade = Convert.ToInt32(Console.ReadLine());

diasdevida = idade * 365;

Console.WriteLine(nome + " você ja viveu " + diasdevida + " dias ");