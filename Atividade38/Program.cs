int anoatual, anonascimento, idadeanos, idademeses, idadedias, idadesemanas;

Console.WriteLine("Digite o ano que você nasceu: ");
anonascimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano atual: ");
anoatual = Convert.ToInt32(Console.ReadLine());

idadeanos = anoatual - anonascimento;

idademeses = idadeanos * 12;

idadedias = idadeanos * 365;

idadesemanas = idadedias / 7;



Console.WriteLine("A idade em anos é: " + idadeanos);

Console.WriteLine("A idade em meses é: " + idademeses);

Console.WriteLine("A idade em semanas é : " + idadesemanas);

Console.WriteLine("A idade em dias é: " + idadedias);
