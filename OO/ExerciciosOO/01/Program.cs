/*Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar 
na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo 
dos parâmetros recebidos.
 * */

using _01;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual dos construtores gostaria de utilizar " +
            "na instanciação da classe ? 1 - Nome e Idade, " + "2  - Idade:  ");
        string nome;
        int idade;

        int escolha = int.Parse(Console.ReadLine());
        if (escolha == 1)
        {
            Console.WriteLine("Informe o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a idade");
            idade = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(nome, idade);


        }
        else if (escolha == 2)
        {
            Console.WriteLine("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(idade);
        }

    }

}