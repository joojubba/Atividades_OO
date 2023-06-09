/*Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite. Utilize o encapsulamento para 
garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
ser alterado.
 * */

using Exercicio05;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o número:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o saldo:");
        double saldo = double.Parse(Console.ReadLine());
        Console.WriteLine("Informeo limite:");
        double limite = double.Parse(Console.ReadLine());


        Conta conta = new Conta(num);
        conta.Saldo = saldo;
        conta.Limite = limite;
        Console.WriteLine($"Número: {conta.Numero}, o saldo {conta.Saldo} e o limite: {conta.Limite}");
    }
}
