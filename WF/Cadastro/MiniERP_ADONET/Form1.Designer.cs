namespace MiniERP_ADONET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelIdCliente = new Label();
            labelNomeCliente = new Label();
            textBoxIdCliente = new TextBox();
            textBoxNomeCliente = new TextBox();
            buttonCadastrarCliente = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            textBoxCliente = new TextBox();
            buttonForm2 = new Button();
            SuspendLayout();
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Location = new Point(28, 65);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(18, 15);
            labelIdCliente.TabIndex = 0;
            labelIdCliente.Text = "ID";
            labelIdCliente.Click += labelIdCliente_Click;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Location = new Point(28, 110);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(40, 15);
            labelNomeCliente.TabIndex = 1;
            labelNomeCliente.Text = "Nome";
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Location = new Point(92, 65);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.Size = new Size(100, 23);
            textBoxIdCliente.TabIndex = 2;
            textBoxIdCliente.TextChanged += textBoxIdCliente_TextChanged;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(92, 110);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(100, 23);
            textBoxNomeCliente.TabIndex = 3;
            textBoxNomeCliente.TextChanged += textBoxNomeCliente_TextChanged;
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.Location = new Point(103, 190);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(75, 23);
            buttonCadastrarCliente.TabIndex = 8;
            buttonCadastrarCliente.Text = "Cadastrar";
            buttonCadastrarCliente.UseVisualStyleBackColor = true;
            buttonCadastrarCliente.Click += buttonCadastrarCliente_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(204, 190);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 9;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(11, 190);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(75, 23);
            buttonConsultar.TabIndex = 11;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(447, 40);
            textBoxCliente.Multiline = true;
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(290, 125);
            textBoxCliente.TabIndex = 12;
            // 
            // buttonForm2
            // 
            buttonForm2.Location = new Point(332, 345);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(196, 23);
            buttonForm2.TabIndex = 13;
            buttonForm2.Text = "Abrir Forncedor";
            buttonForm2.UseVisualStyleBackColor = true;
            buttonForm2.Click += buttonForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonForm2);
            Controls.Add(textBoxCliente);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonCadastrarCliente);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(textBoxIdCliente);
            Controls.Add(labelNomeCliente);
            Controls.Add(labelIdCliente);
            Name = "Form1";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCliente;
        private Label labelNomeCliente;
        private TextBox textBoxIdCliente;
        private TextBox textBoxNomeCliente;
        private Button buttonCadastrarCliente;
        private Button buttonExcluir;
        private Button buttonConsultar;
        private TextBox textBoxCliente;
        private Button buttonForm2;
    }
}