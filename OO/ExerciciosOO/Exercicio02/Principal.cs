using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Principal
    {
        static void Main()
        {
            Aluno aluno1 = new Aluno("Joanna", 25369);

            Aluno aluno2 = new Aluno(new DateTime(1996, 07, 13));

            Aluno aluno3 = new Aluno("Xena", new DateTime(2020, 07, 23), 2023);
        }
    }
}
