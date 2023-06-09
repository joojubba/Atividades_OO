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
    public partial class Form3 : Form
    {
        Produto p = new Produto();
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            p.NomeProduto = textBoxNomeProduto.Text;
            p.Preco = decimal.Parse(textBoxPrecoProduto.Text);
            p.IdFornecedor = int.Parse(textBoxIdProduto.Text);
            if (decimal.TryParse(textBoxPrecoProduto.Text, out decimal preco))
            {
                p.Preco = preco;
            }
            else
            {
                MessageBox.Show("O valor do preço está em um formato incorreto.");
            }
            if (p.gravar())
            {
                MessageBox.Show("Produto Cadastrado!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void buttonExcluirProduto_Click(object sender, EventArgs e)
        {
            p.IdProduto = int.Parse(textBoxIdProduto.Text);

            if (p.excluir())
            {
                MessageBox.Show("Produto excluído!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }

        private void buttonConsultarProduto_Click(object sender, EventArgs e)
        {

            p = p.consulta(int.Parse(textBoxIdProduto.Text));
            // textBoxProduto.Text = p.NomeProduto;
            string txt = p.NomeProduto + " - " + p.Preco.ToString("C");
            textBoxProduto.Text = txt;

        }

        private void buttonForm4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
