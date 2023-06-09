using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_02
{
    internal class Animal
    {
        private string nome;
        private string tipo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
