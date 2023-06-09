/*Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
 * */




using Exercicio2_02;

public class Program
{
    static void Main(string[] args)
    {
      
        List<Animal> animal = new List<Animal>();

        for(int i = 0; i < 5; i++)
        {
            Animal a = new Animal();
            Console.WriteLine("Informe o nome do animal:");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipos do animal: (Cachorro) - " +
                "(Gato) - (Peixe)");
            a.Tipo = Console.ReadLine().ToLower();

            while (a.Tipo != "cachorro" && a.Tipo != "gato" && a.Tipo != "peixe")
            {
                Console.WriteLine("Erro: animal não cadastrado! Digite um tipo válido");
                a.Tipo = Console.ReadLine();
            }

            animal.Add(a);

        }

        int cachorro = 0;
        int gato = 0;
        int peixe = 0;

        foreach (Animal a in animal)
        {
            Console.WriteLine($"{a.Tipo} com o nome de {a.Nome} ");
            if (a.Tipo == "cachorro")
                cachorro++;
            else if (a.Tipo == "gato")
                gato++;
            else if (a.Tipo == "peixe")
                peixe++;
        }

        Console.WriteLine($"Contagem: Cachorro = {cachorro}, Gato = {gato} e Peixe = {peixe}");
    }
}
