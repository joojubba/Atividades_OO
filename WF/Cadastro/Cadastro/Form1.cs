using CriptografiaSimetricaAndAssimetrica;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cadastro
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUser.Text;
            string senha = textBoxSenha.Text;

            Simetrica s = new Simetrica();
            string senhaCripto = s.EncryptData(senha, "cadastro");

            List<Cadastro> lista = new List<Cadastro>();
            lista.Add(new Cadastro(usuario, senhaCripto));
            Persistencia.gravarArquivo(lista);


            MessageBox.Show("Cadastro efetuado!", "Alerta");
            textBoxUser.Text = "";
            textBoxSenha.Text = "";
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';
        }

        private void textBoxLoginU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginS_TextChanged(object sender, EventArgs e)
        {
            textBoxLoginS.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxLoginU.Text;
            string senha = textBoxLoginS.Text;

            List<Cadastro> lista = new List<Cadastro>();
            Persistencia.lerArquivo(lista);

            Simetrica s = new Simetrica();
            bool verificaCadastro = false;

            foreach (var cadastro in lista)
            {
                if (cadastro.Usuario == usuario && s.DecryptData(cadastro.Senha, "cadastro") == senha)
                {
                    verificaCadastro = true;
                    break;
                }
            }

            if (verificaCadastro)
            {

                MessageBox.Show("Login efetuado!", "Alerta");
            }
            else
            {
                MessageBox.Show("Erro: Usuário ou senha não correspondem", "Alerta");
            }
            textBoxLoginU.Text = "";
            textBoxLoginS.Text = "";
        }
    }
}