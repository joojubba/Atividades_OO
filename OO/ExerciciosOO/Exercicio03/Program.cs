﻿/* Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
quando não for possível
 * */


using Exercicio03;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor de saldo inicial:");
        double saldoInicial = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor para depositar:");
        double depositar = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor para sacar:");
        double sacar = double.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente();
        conta.DefinirSaldoInicial(saldoInicial);
        conta.Depositar(depositar);
        bool saque = conta.Sacar(sacar);
        Console.WriteLine($"Foi possível realizar o saque? {saque}");
    }
}