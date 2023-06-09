using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Persistencia
    {
        static string arquivo = "cadastro.txt";
        public static void lerArquivo(List<Cadastro> lista)
        {
            StreamReader leitor = new StreamReader(arquivo);
            String linha;
            String[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");

                lista.Add(new Cadastro(vetorDados[0], vetorDados[1]));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
        public static void gravarArquivo(List<Cadastro> lista)
        {
            StreamWriter escritor = new StreamWriter(arquivo, true);
            foreach (var item in lista)
            {
                escritor.WriteLine($"{item.Usuario};{item.Senha}");
            }
            escritor.Close();
        }
    }
}
