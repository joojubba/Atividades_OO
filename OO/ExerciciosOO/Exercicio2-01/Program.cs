/* Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
O programa deverá informar o nome do personagem que possuir o maior poder.

Regras que deverão ser seguidas para a implementação do algoritmo:

É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
irá receber o nome e o poder de um personagem
 */


using Exercicio2_01;

public class Program
{
    static void Main(string[] args)
    {
        Personagem[] personagem = new Personagem[3];
        for (int i = 0; i < personagem.Length; i++)
        {
            Console.WriteLine("Informe o nome do personagem:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o poder (0 a 10): ");
            int poder = int.Parse(Console.ReadLine());

            personagem[i] = new Personagem(nome, poder);
        }
        Personagem pMaior = personagem[0];
        for (int i = 0; i < personagem.Length; i++)
        {
            if (personagem[i].Poder > pMaior.Poder)
            {
                pMaior = personagem[i];
            }
        }

        Console.WriteLine("Personagem com maior poder:");
        pMaior.ExibirDados();
    }
}


