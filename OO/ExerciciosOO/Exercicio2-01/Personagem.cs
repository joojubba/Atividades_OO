using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_01
{
    internal class Personagem
    {
        public string Nome;
        public int Poder;
        public Personagem()
        {

        }
        public Personagem(string nome, int poder)
        {
            Nome = nome;
           
            if(poder >= 0 && poder <= 10)
            {
                Poder = poder;
            }
            else
            {
                throw new ArgumentException("Erro: valor de poder inválido");
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} e Poder: {Poder}");
        }
    }
}
