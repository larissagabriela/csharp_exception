using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;
using System;
using System.Numerics;


LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Fechar();
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Fechar();
}

// Código comentado omitido

/*
using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X")
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}
*/


