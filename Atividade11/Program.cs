int totalDias, anos, meses, dias;

Console.Write("Digite a quantidade de dias: ");
totalDias = Convert.ToInt32(Console.ReadLine());

anos = totalDias / 360;
totalDias = totalDias % 360;

meses = totalDias / 30;
dias = totalDias % 30;

Console.WriteLine("Anos: " + anos);
Console.WriteLine("Meses: " + meses);
Console.WriteLine("Dias: " + dias);