/* Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
que o nome não seja vazio (utilize função nativa) e que a matrícula seja positiva.
 * */


using Exercicio08;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do aluno:");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe a matrícula do aluno:");
        uint matricula = uint.Parse(Console.ReadLine());

        Aluno a = new Aluno();
        a.Nome = nome;
        a.Matricula = matricula;

        Console.WriteLine($"O nome do aluno: {a.Nome} e a matrícula do aluno:" +
            $" {a.Matricula} ");
    }
}
