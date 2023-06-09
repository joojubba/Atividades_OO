using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != "" )
                {

                    nome = value; 
                   
                }
                else
                {
                    throw new ArgumentException("Erro: nome não preenchido");

                }
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("Erro: idade igual ou menor que 0 ");
                }
            }
        }
    }
}
