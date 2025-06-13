int raio;
decimal area, pi = 3.14M;

Console.WriteLine("Digite o raio da pizza:");
raio = Convert.ToInt32(Console.ReadLine());

area = pi * raio * raio;

Console.WriteLine("A área da pizza é: " + area);
