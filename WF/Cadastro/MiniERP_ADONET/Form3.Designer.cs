namespace MiniERP_ADONET
{
    partial class Form3
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
            labelNomeProduto = new Label();
            labelIdProduto = new Label();
            textBoxProduto = new TextBox();
            buttonCadastrarProduto = new Button();
            textBoxNomeProduto = new TextBox();
            textBoxIdProduto = new TextBox();
            buttonConsultarProduto = new Button();
            buttonExcluirProduto = new Button();
            buttonForm4 = new Button();
            labelPreco = new Label();
            textBoxPrecoProduto = new TextBox();
            SuspendLayout();
            // 
            // labelNomeProduto
            // 
            labelNomeProduto.AutoSize = true;
            labelNomeProduto.Location = new Point(67, 115);
            labelNomeProduto.Name = "labelNomeProduto";
            labelNomeProduto.Size = new Size(40, 15);
            labelNomeProduto.TabIndex = 3;
            labelNomeProduto.Text = "Nome";
            // 
            // labelIdProduto
            // 
            labelIdProduto.AutoSize = true;
            labelIdProduto.Location = new Point(67, 220);
            labelIdProduto.Name = "labelIdProduto";
            labelIdProduto.Size = new Size(21, 15);
            labelIdProduto.TabIndex = 4;
            labelIdProduto.Text = "ID ";
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(465, 59);
            textBoxProduto.Multiline = true;
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(290, 125);
            textBoxProduto.TabIndex = 14;
            // 
            // buttonCadastrarProduto
            // 
            buttonCadastrarProduto.Location = new Point(265, 130);
            buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            buttonCadastrarProduto.Size = new Size(75, 23);
            buttonCadastrarProduto.TabIndex = 15;
            buttonCadastrarProduto.Text = "Cadastrar";
            buttonCadastrarProduto.UseVisualStyleBackColor = true;
            buttonCadastrarProduto.Click += buttonCadastrarProduto_Click;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(133, 107);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(100, 23);
            textBoxNomeProduto.TabIndex = 16;
            // 
            // textBoxIdProduto
            // 
            textBoxIdProduto.Location = new Point(31, 249);
            textBoxIdProduto.Name = "textBoxIdProduto";
            textBoxIdProduto.Size = new Size(100, 23);
            textBoxIdProduto.TabIndex = 17;
            // 
            // buttonConsultarProduto
            // 
            buttonConsultarProduto.Location = new Point(31, 297);
            buttonConsultarProduto.Name = "buttonConsultarProduto";
            buttonConsultarProduto.Size = new Size(75, 23);
            buttonConsultarProduto.TabIndex = 18;
            buttonConsultarProduto.Text = "Consultar";
            buttonConsultarProduto.UseVisualStyleBackColor = true;
            buttonConsultarProduto.Click += buttonConsultarProduto_Click;
            // 
            // buttonExcluirProduto
            // 
            buttonExcluirProduto.Location = new Point(31, 340);
            buttonExcluirProduto.Name = "buttonExcluirProduto";
            buttonExcluirProduto.Size = new Size(75, 23);
            buttonExcluirProduto.TabIndex = 19;
            buttonExcluirProduto.Text = "Excluir";
            buttonExcluirProduto.UseVisualStyleBackColor = true;
            buttonExcluirProduto.Click += buttonExcluirProduto_Click;
            // 
            // buttonForm4
            // 
            buttonForm4.Location = new Point(429, 340);
            buttonForm4.Name = "buttonForm4";
            buttonForm4.Size = new Size(196, 23);
            buttonForm4.TabIndex = 20;
            buttonForm4.Text = "Abrir Notas";
            buttonForm4.UseVisualStyleBackColor = true;
            buttonForm4.Click += buttonForm4_Click;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(67, 151);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(37, 15);
            labelPreco.TabIndex = 21;
            labelPreco.Text = "Preço";
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Location = new Point(133, 148);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(100, 23);
            textBoxPrecoProduto.TabIndex = 22;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPrecoProduto);
            Controls.Add(labelPreco);
            Controls.Add(buttonForm4);
            Controls.Add(buttonExcluirProduto);
            Controls.Add(buttonConsultarProduto);
            Controls.Add(textBoxIdProduto);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(buttonCadastrarProduto);
            Controls.Add(textBoxProduto);
            Controls.Add(labelIdProduto);
            Controls.Add(labelNomeProduto);
            Name = "Form3";
            Text = "Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeProduto;
        private Label labelIdProduto;
        private TextBox textBoxProduto;
        private Button buttonCadastrarProduto;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxIdProduto;
        private Button buttonConsultarProduto;
        private Button buttonExcluirProduto;
        private Button buttonForm4;
        private Label labelPreco;
        private TextBox textBoxPrecoProduto;
    }
}