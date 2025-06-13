int litrosRefresco, litrosAgua, litrosSuco;

Console.WriteLine("Digite quantos litros de refresco deseja fazer:");
litrosRefresco = Convert.ToInt32(Console.ReadLine());

litrosAgua = (litrosRefresco * 8) / 10;
litrosSuco = litrosRefresco - litrosAgua;

Console.WriteLine("Para fazer " + litrosRefresco + " litros de refresco:");
Console.WriteLine("Você vai precisar de " + litrosAgua + " litros de água mineral.");
Console.WriteLine("E " + litrosSuco + " litros de suco de maracujá.");
