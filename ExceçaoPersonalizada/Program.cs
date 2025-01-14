﻿//aula 175

using ExceçaoPersonalizada;

Console.WriteLine("Exceções personalizadas\n");

Conta conta1 = new Conta(100, "Maria", 100m);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo: R$ {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo: R$ {conta1.Saldo}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}


Console.ReadKey();

public class Conta
{
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: R$ {valor}");
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        Console.WriteLine($"Sacou: R$ {valor}");

        if (Saldo < valor)
            throw new SaldoInsuficienteException(valor, Saldo);

        Saldo -= valor;
        return Saldo;
    }
    public override string ToString()
    {
        return $"Tirular: {Titular} - Conta: {Numero} - R$ Saldo= R$ {Saldo}";
    }
}
