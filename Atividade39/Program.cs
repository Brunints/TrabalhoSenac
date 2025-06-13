int salario = 1200, conta1 = 200, conta2 = 120, multa1, multa2, totalConta1, totalConta2, totalPago, restante;

multa1 = (conta1 * 2) / 100;
multa2 = (conta2 * 2) / 100;

totalConta1 = conta1 + multa1;
totalConta2 = conta2 + multa2;

totalPago = totalConta1 + totalConta2;
restante = salario - totalPago;

Console.WriteLine("Após pagar as contas, restará: R$ " + restante);
