int areaTrapezio, basemaior, basemenor, altura;

Console.WriteLine("Digite a base maior do trapezio");
basemaior = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a base menor do trapezio");
basemenor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura do trapezio");
altura = Convert.ToInt32(Console.ReadLine());

areaTrapezio = (basemaior + basemenor) * altura / 2;

Console.WriteLine("A area do trapezio é " + areaTrapezio);