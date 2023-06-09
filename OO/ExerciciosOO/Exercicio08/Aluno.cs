using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Aluno
    {
        string nome;
        uint matricula;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Erro: nome não preenchido");
                }
                else
                {
                    nome = value;
                }               
              
            }
        }
        public uint Matricula
        {
            get { return matricula; }   
            set { matricula = value; }
        }
    }
}
