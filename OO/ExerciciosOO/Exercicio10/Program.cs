/* Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
EmitirSom, que imprime na tela o som do animal.
 * */

using Exercicio10;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do animal:");
        string nome = Console.ReadLine();   
        Console.WriteLine("Informe se o animal é (Cachorro) - " +
            "(Gato) - (Vaca) ou (Sapo):");
        string especie = Console.ReadLine().ToLower();
        Console.WriteLine("Informe a idade do animal:");
        int idade = int.Parse(Console.ReadLine());

        Animal animal = new Animal();
        animal.Nome = nome;
        animal.Especie = especie;
        animal.Idade = idade;


        animal.EmitirSom();
    }
}

