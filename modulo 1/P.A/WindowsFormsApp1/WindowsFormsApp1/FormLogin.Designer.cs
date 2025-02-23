namespace WindowsFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txb1 = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txbimg = new System.Windows.Forms.PictureBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.lbsenha = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(362, 147);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(230, 34);
            this.txb1.TabIndex = 1;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEntrar.Location = new System.Drawing.Point(434, 375);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 47);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txbimg
            // 
            this.txbimg.Image = ((System.Drawing.Image)(resources.GetObject("txbimg.Image")));
            this.txbimg.Location = new System.Drawing.Point(12, 12);
            this.txbimg.Name = "txbimg";
            this.txbimg.Size = new System.Drawing.Size(143, 114);
            this.txbimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txbimg.TabIndex = 2;
            this.txbimg.TabStop = false;
            this.txbimg.Click += new System.EventHandler(this.txbimg_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(168, 157);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(81, 24);
            this.lbusuario.TabIndex = 3;
            this.lbusuario.Text = "Usúario";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(362, 202);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.PasswordChar = '*';
            this.txb2.Size = new System.Drawing.Size(230, 34);
            this.txb2.TabIndex = 2;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(328, 49);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(62, 24);
            this.lblogin.TabIndex = 5;
            this.lblogin.Text = "Login";
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.Location = new System.Drawing.Point(179, 212);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(70, 24);
            this.lbsenha.TabIndex = 6;
            this.lbsenha.Text = "Senha";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlimpar.Location = new System.Drawing.Point(630, 375);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(158, 47);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.txbimg);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.txbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox txbimg;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.Button btnlimpar;
    }
}