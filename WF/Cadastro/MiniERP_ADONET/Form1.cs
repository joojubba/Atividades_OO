using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniERP_ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = textBoxNomeCliente.Text;


            if (c.gravar())
            {
                MessageBox.Show("Cliente Cadastrado!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c = c.consulta(int.Parse(textBoxIdCliente.Text));
            textBoxCliente.Text = c.NomeCliente;

        }

        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdCliente = int.Parse(textBoxIdCliente.Text);


            if (c.excluir())
            {
                MessageBox.Show("Cliente excluído!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}