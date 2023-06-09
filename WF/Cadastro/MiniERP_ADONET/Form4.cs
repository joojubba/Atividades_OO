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
            // Criar uma nova nota
            n.IdCliente = int.Parse(textBoxIDNotaCliente.Text);
            n.NotaItens = new List<NotaItem>();

            // Adicionar os itens da nota
            foreach (DataGridViewRow row in dataGridViewNota.Rows)
            {
                if (!row.IsNewRow)
                {
                    NotaItem ni = new NotaItem();
                    ni.IdProduto = Convert.ToInt32(row.Cells["IdProduto"].Value);
                    ni.QtdNotaItem = Convert.ToInt32(row.Cells["QtdNotaItem"].Value);
                    n.NotaItens.Add(ni);
                }
            }
            if (n.gravar())
            {
                MessageBox.Show("Nota lançada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao lançar a nota.");
            }
        }

        private void buttonConsultarNota_Click(object sender, EventArgs e)
        {



            // Obter o ID da nota digitado pelo usuário
            int idNota = Convert.ToInt32(textBoxIDNota.Text);

            // Consultar a nota pelo ID
            Nota n = new Nota().consulta(idNota);

            if (n != null)
            {
                // Exibir os detalhes da nota
                textBoxIDNotaCliente.Text = n.IdCliente.ToString();

                // Exibir os itens da nota
                dataGridViewNota.Rows.Clear();
                foreach (var notaItem in n.NotaItens)
                {
                    int rowIndex = dataGridViewNota.Rows.Add();
                    dataGridViewNota.Rows[rowIndex].Cells["IdProduto"].Value = notaItem.IdProduto;
                    dataGridViewNota.Rows[rowIndex].Cells["QtdNotaItem"].Value = notaItem.QtdNotaItem;
                }
            }
            else
            {
                MessageBox.Show("Nota não encontrada.");
            }
        }
    }
}
