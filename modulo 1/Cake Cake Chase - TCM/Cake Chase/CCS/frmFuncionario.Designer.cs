namespace test
{
    partial class frmFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.ttEmail = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblSenha.Location = new System.Drawing.Point(150, 342);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(90, 41);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbEmail.Location = new System.Drawing.Point(289, 213);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(379, 48);
            this.txbEmail.TabIndex = 2;
            this.ttEmail.SetToolTip(this.txbEmail, "O email deve conter um @.");
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(157, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbNome.Location = new System.Drawing.Point(289, 150);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(379, 48);
            this.txbNome.TabIndex = 1;
            this.txbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(156, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome:";
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbLogin.Location = new System.Drawing.Point(289, 276);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(379, 48);
            this.txbLogin.TabIndex = 3;
            this.txbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNome_KeyDown);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblLogin.Location = new System.Drawing.Point(159, 279);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(81, 41);
            this.lblLogin.TabIndex = 22;
            this.lblLogin.Text = "Login:";
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbSenha.Location = new System.Drawing.Point(289, 339);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(379, 48);
            this.txbSenha.TabIndex = 4;
            this.txbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNome_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test.Properties.Resources.n;
            this.pictureBox1.Location = new System.Drawing.Point(81, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Cream Cake", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblCadastrar.Location = new System.Drawing.Point(243, 43);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(540, 80);
            this.lblCadastrar.TabIndex = 25;
            this.lblCadastrar.Text = "Cadastrar Funcionário";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Font = new System.Drawing.Font("Accidental Presidency", 24.75F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnLimpar.Location = new System.Drawing.Point(179, 439);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 53);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrar.Font = new System.Drawing.Font("Accidental Presidency", 24.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnCadastrar.Location = new System.Drawing.Point(523, 439);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 53);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.ttEmail.SetToolTip(this.btnCadastrar, "cads");
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrar.Image = global::test.Properties.Resources.icons8_eye_100;
            this.pbMostrar.Location = new System.Drawing.Point(674, 344);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(45, 39);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 27;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMostrar_MouseDown);
            this.pbMostrar.MouseLeave += new System.EventHandler(this.pbMostrar_MouseLeave);
            this.pbMostrar.MouseHover += new System.EventHandler(this.pbMostrar_MouseHover);
            this.pbMostrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMostrar_MouseUp);
            // 
            // frmFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(857, 545);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(873, 584);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.ToolTip ttEmail;
    }
}