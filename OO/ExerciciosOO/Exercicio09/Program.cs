/*Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um 
valor e verifica se o saldo é suficiente para a operação.
 * */


using Exercicio09;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o Numero da Conta:");
        uint numeroConta = uint.Parse(Console.ReadLine());
        Console.WriteLine("Informe o Titular:");
        string titular = Console.ReadLine();
        Console.WriteLine("Informe o limite:");
        double limite = double.Parse(Console.ReadLine());
      
        ContaBancaria conta = new ContaBancaria();
        conta.NumeroConta = numeroConta;
        conta.Titular = titular;
        conta.Limite = limite;
        
        Console.WriteLine($"O Numero da Conta: {conta.NumeroConta}, o Titular:{conta.Titular}" +
            $", o saldo: {conta.Saldo} e o limite {conta.Limite}" );

        Console.WriteLine("Informe o valor para depositar:");
        double depositar = double.Parse(Console.ReadLine());
        conta.Depositar(depositar);
        Console.WriteLine($"O saldo atual: {conta.Saldo}");


        Console.WriteLine("Informe o valor para sacar:");
        double sacar = double.Parse(Console.ReadLine());
        bool saque = conta.Sacar(sacar);

        if(saque)
        {
            Console.WriteLine("Saldo é suficiente para a operação");
        }
        else
        {
            Console.WriteLine("Saldo não é suficiente para a operação");
        }

        Console.WriteLine($"O Numero da Conta: {conta.NumeroConta}, o Titular:{conta.Titular}" +
            $", o limite {conta.Limite} e o saldo final: {conta.Saldo}");
    }
}
