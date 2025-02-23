namespace test
{
    partial class frmCliente
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
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Cream Cake", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblCadastrar.Location = new System.Drawing.Point(275, 43);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(427, 80);
            this.lblCadastrar.TabIndex = 27;
            this.lblCadastrar.Text = "Cadastrar Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Font = new System.Drawing.Font("Accidental Presidency", 24.75F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnLimpar.Location = new System.Drawing.Point(161, 393);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(155, 53);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrar.Font = new System.Drawing.Font("Accidental Presidency", 24.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnCadastrar.Location = new System.Drawing.Point(505, 393);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 53);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblEmail.Location = new System.Drawing.Point(141, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 41);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblSenha.Location = new System.Drawing.Point(182, 296);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(117, 41);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Telefone:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbNome.Location = new System.Drawing.Point(271, 167);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(379, 48);
            this.txbNome.TabIndex = 1;
            this.txbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTelefone_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblNome.Location = new System.Drawing.Point(139, 170);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 41);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbEmail.Location = new System.Drawing.Point(271, 230);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(379, 48);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTelefone_KeyDown);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Accidental Presidency", 26.25F);
            this.txbTelefone.Location = new System.Drawing.Point(321, 293);
            this.txbTelefone.Mask = "(00) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(287, 48);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txbTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTelefone_KeyDown);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::test.Properties.Resources.n;
            this.pbLogo.Location = new System.Drawing.Point(122, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(129, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 28;
            this.pbLogo.TabStop = false;
            // 
            // frmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 517);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
    }
}