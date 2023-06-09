using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Livro
    {
        string titulo;
        public Autor autor;
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                if (value != "")
                {

                    titulo = value;

                }
                else
                {
                    throw new ArgumentException("Erro: titulo não preenchido");

                }
            }

        }
        public Autor Nome
        {
            get { return autor; }
            set { autor = value; }
        }

        public class Autor
        {
            string nome;
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
                        throw new ArgumentException("Erro: nome do autor não preenchido");

                    }
                }
            }

        }

        
    }
}
