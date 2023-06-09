using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Cadastro
    {
        private string usuario;
        private string senha;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }

        public Cadastro(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
