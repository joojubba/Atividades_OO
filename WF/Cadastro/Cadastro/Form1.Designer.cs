namespace Cadastro
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
            labelUsuario = new Label();
            labelSenha = new Label();
            textBoxUser = new TextBox();
            textBoxSenha = new TextBox();
            buttonCadastrar = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxLoginS = new TextBox();
            textBoxLoginU = new TextBox();
            buttonLogin = new Button();
            labelLoginS = new Label();
            labelLoginU = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Gray;
            labelUsuario.Location = new Point(200, 288);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(78, 18);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.ForeColor = Color.Gray;
            labelSenha.Location = new Point(200, 386);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(58, 18);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(48, 318);
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(412, 31);
            textBoxUser.TabIndex = 2;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(48, 419);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(412, 31);
            textBoxSenha.TabIndex = 3;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = Color.FromArgb(64, 64, 64);
            buttonCadastrar.Location = new Point(48, 529);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(412, 31);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(25, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 634);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(508, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 634);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBoxLoginS);
            panel4.Controls.Add(textBoxLoginU);
            panel4.Controls.Add(buttonLogin);
            panel4.Controls.Add(labelLoginS);
            panel4.Controls.Add(labelLoginU);
            panel4.Location = new Point(35, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(551, 498);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.password;
            pictureBox1.Location = new Point(205, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBoxLoginS
            // 
            textBoxLoginS.Location = new Point(60, 277);
            textBoxLoginS.Multiline = true;
            textBoxLoginS.Name = "textBoxLoginS";
            textBoxLoginS.Size = new Size(412, 31);
            textBoxLoginS.TabIndex = 7;
            textBoxLoginS.TextChanged += textBoxLoginS_TextChanged;
            // 
            // textBoxLoginU
            // 
            textBoxLoginU.Location = new Point(60, 192);
            textBoxLoginU.Multiline = true;
            textBoxLoginU.Name = "textBoxLoginU";
            textBoxLoginU.Size = new Size(412, 31);
            textBoxLoginU.TabIndex = 6;
            textBoxLoginU.TextChanged += textBoxLoginU_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(255, 128, 0);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(64, 64, 64);
            buttonLogin.Location = new Point(60, 383);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(412, 31);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelLoginS
            // 
            labelLoginS.AutoSize = true;
            labelLoginS.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoginS.ForeColor = Color.Gray;
            labelLoginS.Location = new Point(60, 256);
            labelLoginS.Name = "labelLoginS";
            labelLoginS.Size = new Size(58, 18);
            labelLoginS.TabIndex = 2;
            labelLoginS.Text = "Senha";
            // 
            // labelLoginU
            // 
            labelLoginU.AutoSize = true;
            labelLoginU.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoginU.ForeColor = Color.Gray;
            labelLoginU.Location = new Point(60, 171);
            labelLoginU.Name = "labelLoginU";
            labelLoginU.Size = new Size(78, 18);
            labelLoginU.TabIndex = 1;
            labelLoginU.Text = "Usuário";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(labelUsuario);
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(textBoxUser);
            panel2.Controls.Add(textBoxSenha);
            panel2.Controls.Add(labelSenha);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 634);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(160, 219);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 6;
            label1.Text = "Cadastramento";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password__4_;
            pictureBox2.Location = new Point(179, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1184, 688);
            Controls.Add(panel1);
            MaximumSize = new Size(1200, 727);
            MinimumSize = new Size(1200, 727);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelUsuario;
        private Label labelSenha;
        private TextBox textBoxUser;
        private TextBox textBoxSenha;
        private Button buttonCadastrar;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBoxLoginS;
        private TextBox textBoxLoginU;
        private Button buttonLogin;
        private Label labelLoginS;
        private Label labelLoginU;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}