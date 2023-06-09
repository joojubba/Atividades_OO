using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public DateTime nascimento;
        public int anoIngresso;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            Console.WriteLine("Instância 1:");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Matrícula : " + this.matricula);

        }

        public Aluno(DateTime nascimento)
        {
            this.nascimento = nascimento;
            Console.WriteLine("Instância 2:");
            Console.WriteLine("Data de nascimento: " + this.nascimento.ToShortDateString());
        }
        public Aluno(string nome, DateTime nascimento, int anoIngresso)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.anoIngresso = anoIngresso;
            Console.WriteLine("Instância 3:");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Data de nascimento:  " + this.nascimento.ToShortDateString());
            Console.WriteLine("Ano em que ingressou na faculdade : " + this.anoIngresso);
        }
    }
}
