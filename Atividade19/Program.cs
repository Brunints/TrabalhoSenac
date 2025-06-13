decimal anel = 3.50M, chip = 4M, valortotal;
int frangos;

Console.WriteLine("Quantos frangos há na granja?");
frangos = Convert.ToInt32(Console.ReadLine());

valortotal = frangos * ((anel * 2) + chip);

Console.WriteLine("O gasto da granja é: R$" + valortotal);