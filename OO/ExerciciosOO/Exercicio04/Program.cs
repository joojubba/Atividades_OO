/*Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
que o nome não seja vazio e que a idade seja maior que zero.
 * */

using Exercicio04;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe a idade");
        int idade = int.Parse(Console.ReadLine());

        Pessoa p = new Pessoa();
        p.Nome = nome;
        p.Idade = idade;
        Console.WriteLine($"Nome: {p.Nome} e Idade: {p.Idade}");
    }
}
