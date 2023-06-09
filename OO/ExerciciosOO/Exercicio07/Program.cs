/*Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
para garantir que o título e o autor não sejam vazios.
 */

using Exercicio07;
using static Exercicio07.Livro;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do título do livro");
        string titulo = Console.ReadLine();
        Console.WriteLine("Informe o nome do autor do livro");
        string nome = Console.ReadLine();

        Autor a = new Autor();
        a.Nome = nome;

        Livro l = new Livro();
        l.Titulo = titulo;
        l.Nome = a;
       

       
        Console.WriteLine($"O título do livro: {l.Titulo}, e o nome do autor do livro:" +
            $" {l.Nome.Nome} ");
    }
}

