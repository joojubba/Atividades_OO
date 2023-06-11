namespace MiniERP_ADONET
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLancarNota = new Button();
            buttonCancelarNota = new Button();
            buttonConsultarNota = new Button();
            labelDNotaCliente = new Label();
            textBoxIDNotaCliente = new TextBox();
            labelIDNota = new Label();
            textBoxIDNota = new TextBox();
            labelNotaQtd = new Label();
            textBoxNotaQtd = new TextBox();
            dataGridViewNota = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).BeginInit();
            SuspendLayout();
            // 
            // buttonLancarNota
            // 
            buttonLancarNota.Location = new Point(22, 325);
            buttonLancarNota.Name = "buttonLancarNota";
            buttonLancarNota.Size = new Size(75, 23);
            buttonLancarNota.TabIndex = 6;
            buttonLancarNota.Text = "Lançar";
            buttonLancarNota.UseVisualStyleBackColor = true;
            buttonLancarNota.Click += buttonLancarNota_Click;
            // 
            // buttonCancelarNota
            // 
            buttonCancelarNota.Location = new Point(122, 325);
            buttonCancelarNota.Name = "buttonCancelarNota";
            buttonCancelarNota.Size = new Size(75, 23);
            buttonCancelarNota.TabIndex = 7;
            buttonCancelarNota.Text = "Cancelar";
            buttonCancelarNota.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarNota
            // 
            buttonConsultarNota.Location = new Point(222, 325);
            buttonConsultarNota.Name = "buttonConsultarNota";
            buttonConsultarNota.Size = new Size(75, 23);
            buttonConsultarNota.TabIndex = 8;
            buttonConsultarNota.Text = "Consultar";
            buttonConsultarNota.UseVisualStyleBackColor = true;
            buttonConsultarNota.Click += buttonConsultarNota_Click;
            // 
            // labelDNotaCliente
            // 
            labelDNotaCliente.AutoSize = true;
            labelDNotaCliente.Location = new Point(45, 97);
            labelDNotaCliente.Name = "labelDNotaCliente";
            labelDNotaCliente.Size = new Size(58, 15);
            labelDNotaCliente.TabIndex = 9;
            labelDNotaCliente.Text = "ID Cliente";
            // 
            // textBoxIDNotaCliente
            // 
            textBoxIDNotaCliente.Location = new Point(122, 97);
            textBoxIDNotaCliente.Name = "textBoxIDNotaCliente";
            textBoxIDNotaCliente.Size = new Size(100, 23);
            textBoxIDNotaCliente.TabIndex = 10;
            // 
            // labelIDNota
            // 
            labelIDNota.AutoSize = true;
            labelIDNota.Location = new Point(45, 139);
            labelIDNota.Name = "labelIDNota";
            labelIDNota.Size = new Size(64, 15);
            labelIDNota.TabIndex = 15;
            labelIDNota.Text = "ID Produto";
            // 
            // textBoxIDNota
            // 
            textBoxIDNota.Location = new Point(122, 136);
            textBoxIDNota.Name = "textBoxIDNota";
            textBoxIDNota.Size = new Size(100, 23);
            textBoxIDNota.TabIndex = 16;
            // 
            // labelNotaQtd
            // 
            labelNotaQtd.AutoSize = true;
            labelNotaQtd.Location = new Point(45, 176);
            labelNotaQtd.Name = "labelNotaQtd";
            labelNotaQtd.Size = new Size(72, 15);
            labelNotaQtd.TabIndex = 17;
            labelNotaQtd.Text = "Quantidade ";
            // 
            // textBoxNotaQtd
            // 
            textBoxNotaQtd.Location = new Point(123, 176);
            textBoxNotaQtd.Name = "textBoxNotaQtd";
            textBoxNotaQtd.Size = new Size(100, 23);
            textBoxNotaQtd.TabIndex = 18;
            // 
            // dataGridViewNota
            // 
            dataGridViewNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNota.Location = new Point(303, 49);
            dataGridViewNota.Name = "dataGridViewNota";
            dataGridViewNota.RowTemplate.Height = 25;
            dataGridViewNota.Size = new Size(438, 150);
            dataGridViewNota.TabIndex = 19;
            dataGridViewNota.CellContentClick += dataGridViewNota_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewNota);
            Controls.Add(textBoxNotaQtd);
            Controls.Add(labelNotaQtd);
            Controls.Add(textBoxIDNota);
            Controls.Add(labelIDNota);
            Controls.Add(textBoxIDNotaCliente);
            Controls.Add(labelDNotaCliente);
            Controls.Add(buttonConsultarNota);
            Controls.Add(buttonCancelarNota);
            Controls.Add(buttonLancarNota);
            Name = "Form4";
            Text = "Lançamento de Notas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLancarNota;
        private Button buttonCancelarNota;
        private Button buttonConsultarNota;
        private Label labelDNotaCliente;
        private TextBox textBoxIDNotaCliente;
        private Label labelIDNota;
        private TextBox textBoxIDNota;
        private Label labelNotaQtd;
        private TextBox textBoxNotaQtd;
        private DataGridView dataGridViewNota;
    }
}