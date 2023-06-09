/*Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
seja vazio e que o preço seja positivo. 
 * */


using Exercicio06;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do Fabricante");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe o endereço do Fabricante");
        string endereco = Console.ReadLine();
        Console.WriteLine("Informe a cidade do Fabricante");
        string cidade = Console.ReadLine();

        Console.WriteLine("Informe o nome do Produto");
        string nomeP = Console.ReadLine();
        Console.WriteLine("Informe o preço do Produto");
        double preco = double.Parse(Console.ReadLine());

        Fabricante f = new Fabricante();
        f.Nome = nome;
        f.Endereco = endereco;
        f.Cidade = cidade;
        Console.WriteLine($"Nome: {f.Nome}, o endereço: {f.Endereco} " +
            $" e a cidade: {f.Cidade}");

        

       
        

        Produto p = new Produto();
        p.Nome = nomeP;
        p.Fabricante = f;
        p.Preco = preco;
        Console.WriteLine($"Nome: {p.Nome}, o fabricante: {p.Fabricante.Nome} " +
            $" e o preço: {p.Preco}");
    }
}
