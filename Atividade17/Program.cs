int graus, celsius, Fahrenheit = 0;

Console.WriteLine("Digite quantos graus em celsius ");
celsius = Convert.ToInt32(Console.ReadLine());

Fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("A temperatura convertida pra Fahrenheit é " + Fahrenheit);