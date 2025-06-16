decimal raio, altura, volumeCm3, volumeLitros;

Console.WriteLine("Digite o raio da base da caixa :");
raio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa :");
altura = Convert.ToInt32(Console.ReadLine());

volumeCm3 = (314 * raio * raio * altura) / 100;

volumeLitros = volumeCm3 / 1000;

Console.WriteLine("O volume da caixa d'água é aproximadamente " + volumeLitros + " litros.");
