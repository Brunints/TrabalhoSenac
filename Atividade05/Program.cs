int precoLitro = 0, valorPago = 0, litros = 0, total = 0;

Console.WriteLine("Digite o preço do litro da gasolina:");
precoLitro = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor que deseja colocar:");
valorPago = Convert.ToInt32(Console.ReadLine());

while (total + precoLitro <= valorPago)
{
    total += precoLitro;
    litros++;
}

Console.WriteLine("Você colocou " + litros + " litros de gasolina no tanque do seu carro.");