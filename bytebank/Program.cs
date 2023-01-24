using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contadoandre = new ContaCorrente();
//contadoandre.titular = "André silva";
//contadoandre.numero_agencia = 15;
//contadoandre.conta = "1010-X";
//contadoandre.saldo = 100;

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//Console.ReadKey();
//*/

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine($"Saldo do André = {contaDoAndre.saldo}");
//Console.WriteLine($"Saldo da Maria = {contaDaMaria.saldo}");

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine($"Saldo do André = {contaDoAndre.saldo}");
//Console.WriteLine($"Saldo da Maria = {contaDaMaria.saldo}");

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine($"Titular da conta: {contaDoPedro.titular}");
//Console.WriteLine($"Número da conta: {contaDoPedro.conta}");
//Console.WriteLine($"Agência: {contaDoPedro.numero_agencia}");
//Console.WriteLine($"Saldo R$ {contaDoPedro.saldo}");

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
////conta.saldo = 100;

//Console.WriteLine($"Nome do titular da conta: {conta.titular.nome}");
//Console.WriteLine($"CPF do titular da conta: {conta.titular.cpf}");
//Console.WriteLine($"Profissão do titular da conta: {conta.titular.profissao}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//conta3.Numero_agencia = 5;
//Console.WriteLine(conta3.Numero_agencia);

//ContaCorrente conta4 = new ContaCorrente(18, "ABC");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta7 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);