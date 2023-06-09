using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Produto
    {
        string nome;
        public Fabricante fabricante;
        double preco;

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

        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    throw new ArgumentException("Erro: preço deve ser positivo");
                }
            }
        }
    }
}
