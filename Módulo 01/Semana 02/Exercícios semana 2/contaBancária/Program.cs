using contaBancária.contaBancaria;

contaBancaria conta = new contaBancaria();

conta.numeroConta = 5248;
conta.agencia = 1234;
conta.Titular = "Rogerio Mattos";

Console.WriteLine($"O número da conta é: {conta.numeroConta} O numero da agência é: {conta.agencia} O nome do Titular é: {conta.Titular}");

