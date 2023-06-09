using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Animal
    {
        public string nome;
        public string especie;
        public int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public void EmitirSom()
        {
            if(especie == "gato")
            {
                Console.WriteLine($"{Especie} chamacom o nome de {Nome} de {Idade} anos faz Miau");
            }
            else if (especie == "cachorro")
            {
                Console.WriteLine($" {Especie} com o nome de {Nome} de {Idade} anos faz Au");
            }
            else if (especie == "vaca")
            {
                Console.WriteLine($" {Especie} com o nome de {Nome} de {Idade} anos faz Moo");
            }
            else if (especie == "sapo")
            {
                Console.WriteLine($"{Especie} com o nome de {Nome} de {Idade} anos faz Uebeti");
            }
            else
            {
                Console.WriteLine("Desculpa, som do animal ainda" +
                    " não cadastrado!");
            }
        }
    }
}
