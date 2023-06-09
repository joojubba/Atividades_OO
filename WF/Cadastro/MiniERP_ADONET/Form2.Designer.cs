namespace MiniERP_ADONET
{
    partial class Form2
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
            labelIdFornecedor = new Label();
            textBoxIdFornecedor = new TextBox();
            labelNomeFornecedor = new Label();
            textBoxNomeFornecedor = new TextBox();
            buttonCadastrarFornecedor = new Button();
            buttonConsultarFornecedor = new Button();
            buttonExcluirFornecedor = new Button();
            textBoxFornecedor = new TextBox();
            buttonForm3 = new Button();
            SuspendLayout();
            // 
            // labelIdFornecedor
            // 
            labelIdFornecedor.AutoSize = true;
            labelIdFornecedor.Location = new Point(53, 198);
            labelIdFornecedor.Name = "labelIdFornecedor";
            labelIdFornecedor.Size = new Size(21, 15);
            labelIdFornecedor.TabIndex = 0;
            labelIdFornecedor.Text = "ID ";
            // 
            // textBoxIdFornecedor
            // 
            textBoxIdFornecedor.Location = new Point(22, 216);
            textBoxIdFornecedor.Name = "textBoxIdFornecedor";
            textBoxIdFornecedor.Size = new Size(100, 23);
            textBoxIdFornecedor.TabIndex = 1;
            // 
            // labelNomeFornecedor
            // 
            labelNomeFornecedor.AutoSize = true;
            labelNomeFornecedor.Location = new Point(34, 84);
            labelNomeFornecedor.Name = "labelNomeFornecedor";
            labelNomeFornecedor.Size = new Size(40, 15);
            labelNomeFornecedor.TabIndex = 2;
            labelNomeFornecedor.Text = "Nome";
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(90, 84);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(100, 23);
            textBoxNomeFornecedor.TabIndex = 3;
            // 
            // buttonCadastrarFornecedor
            // 
            buttonCadastrarFornecedor.Location = new Point(90, 123);
            buttonCadastrarFornecedor.Name = "buttonCadastrarFornecedor";
            buttonCadastrarFornecedor.Size = new Size(75, 23);
            buttonCadastrarFornecedor.TabIndex = 7;
            buttonCadastrarFornecedor.Text = "Cadastrar";
            buttonCadastrarFornecedor.UseVisualStyleBackColor = true;
            buttonCadastrarFornecedor.Click += buttonCadastrarFornecedor_Click;
            // 
            // buttonConsultarFornecedor
            // 
            buttonConsultarFornecedor.Location = new Point(22, 255);
            buttonConsultarFornecedor.Name = "buttonConsultarFornecedor";
            buttonConsultarFornecedor.Size = new Size(75, 23);
            buttonConsultarFornecedor.TabIndex = 8;
            buttonConsultarFornecedor.Text = "Consultar";
            buttonConsultarFornecedor.UseVisualStyleBackColor = true;
            buttonConsultarFornecedor.Click += buttonConsultarFornecedor_Click;
            // 
            // buttonExcluirFornecedor
            // 
            buttonExcluirFornecedor.Location = new Point(22, 295);
            buttonExcluirFornecedor.Name = "buttonExcluirFornecedor";
            buttonExcluirFornecedor.Size = new Size(75, 23);
            buttonExcluirFornecedor.TabIndex = 9;
            buttonExcluirFornecedor.Text = "Excluir";
            buttonExcluirFornecedor.UseVisualStyleBackColor = true;
            buttonExcluirFornecedor.Click += buttonExcluirFornecedor_Click;
            // 
            // textBoxFornecedor
            // 
            textBoxFornecedor.Location = new Point(373, 62);
            textBoxFornecedor.Multiline = true;
            textBoxFornecedor.Name = "textBoxFornecedor";
            textBoxFornecedor.Size = new Size(290, 125);
            textBoxFornecedor.TabIndex = 13;
            // 
            // buttonForm3
            // 
            buttonForm3.Location = new Point(303, 378);
            buttonForm3.Name = "buttonForm3";
            buttonForm3.Size = new Size(196, 23);
            buttonForm3.TabIndex = 14;
            buttonForm3.Text = "Abrir Produtos";
            buttonForm3.UseVisualStyleBackColor = true;
            buttonForm3.Click += buttonForm3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonForm3);
            Controls.Add(textBoxFornecedor);
            Controls.Add(buttonExcluirFornecedor);
            Controls.Add(buttonConsultarFornecedor);
            Controls.Add(buttonCadastrarFornecedor);
            Controls.Add(textBoxNomeFornecedor);
            Controls.Add(labelNomeFornecedor);
            Controls.Add(textBoxIdFornecedor);
            Controls.Add(labelIdFornecedor);
            Name = "Form2";
            Text = "Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdFornecedor;
        private TextBox textBoxIdFornecedor;
        private Label labelNomeFornecedor;
        private TextBox textBoxNomeFornecedor;
        private Button buttonCadastrarFornecedor;
        private Button buttonConsultarFornecedor;
        private Button buttonExcluirFornecedor;
        private TextBox textBoxFornecedor;
        private Button buttonForm3;
    }
}