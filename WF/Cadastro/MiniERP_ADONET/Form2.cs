using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP_ADONET
{
    public partial class Form2 : Form
    {
        Fornecedor f = new Fornecedor();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            f.NomeFornecedor = textBoxNomeFornecedor.Text;

            if (f.gravar())
            {
                MessageBox.Show("Fornecedor Cadastrado!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void buttonExcluirFornecedor_Click(object sender, EventArgs e)
        {

            f.IdFornecedor = int.Parse(textBoxIdFornecedor.Text);

            if (f.excluir())
            {
                MessageBox.Show("Fornecedor excluído!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }

        private void buttonConsultarFornecedor_Click(object sender, EventArgs e)
        {

            f = f.consulta(int.Parse(textBoxIdFornecedor.Text));
            textBoxFornecedor.Text = f.NomeFornecedor;
        }

        private void buttonForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
