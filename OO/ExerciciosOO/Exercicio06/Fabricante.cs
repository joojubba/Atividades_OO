using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Fabricante
    {
        string nome;
        string endereco;
        string cidade;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != "")
                {

                    nome = value;

                }
                else
                {
                    throw new ArgumentException("Erro: nome não preenchido");

                }
            }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
