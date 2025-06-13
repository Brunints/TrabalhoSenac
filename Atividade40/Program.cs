double cateto1, cateto2, hipotenusa;

Console.WriteLine("Digite o valor do cateto1: ");
cateto1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do cateto2: ");
cateto2 = Convert.ToInt32(Console.ReadLine());

hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));

Console.WriteLine("O valor da hipotenusa é " + hipotenusa);