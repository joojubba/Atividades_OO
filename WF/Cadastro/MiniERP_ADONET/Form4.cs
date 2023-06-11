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
    public partial class Form4 : Form
    {
        Nota n = new Nota();
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonLancarNota_Click(object sender, EventArgs e)
        {
            n.IdCliente = Convert.ToInt32(textBoxIDNotaCliente.Text);


            NotaItem notaItem = new NotaItem();

            notaItem.IdProduto = Convert.ToInt32(textBoxIDNota.Text);
            notaItem.QtdNotaItem = Convert.ToInt32(textBoxNotaQtd.Text);


            n.NotaItens.Add(notaItem);

            if (n.gravar())
            {
                MessageBox.Show("Nota lançada!");
            }
            else
            {
                MessageBox.Show("Erro ao lançar nota!");
            }
        }

        private void buttonConsultarNota_Click(object sender, EventArgs e)
        {

            Nota n = new Nota();

            n = n.consulta(Convert.ToInt32(textBoxIDNota.Text));
            if (n != null)
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("IdNotaItem");
                dt.Columns.Add("IdProduto");
                dt.Columns.Add("QtdNotaItem");

                foreach (var item in n.NotaItens)
                {
                    dt.Rows.Add(item.IdNotaItem, item.IdProduto, item.QtdNotaItem);
                }
                dataGridViewNota.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nota não encontrada!");
            }
        }

        private void dataGridViewNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
