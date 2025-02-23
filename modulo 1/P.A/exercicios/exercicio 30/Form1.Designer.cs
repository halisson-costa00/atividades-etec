namespace Ex30
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labDigite = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labCategoria = new System.Windows.Forms.Label();
            this.labNumInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDigite
            // 
            this.labDigite.AutoSize = true;
            this.labDigite.BackColor = System.Drawing.Color.Black;
            this.labDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDigite.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labDigite.Location = new System.Drawing.Point(293, 57);
            this.labDigite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDigite.Name = "labDigite";
            this.labDigite.Size = new System.Drawing.Size(478, 52);
            this.labDigite.TabIndex = 0;
            this.labDigite.Text = "Digite a idade do atleta:";
            // 
            // txbIdade
            // 
            this.txbIdade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbIdade.Location = new System.Drawing.Point(481, 167);
            this.txbIdade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(132, 98);
            this.txbIdade.TabIndex = 1;
            this.txbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(303, 335);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(179, 62);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(603, 335);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 62);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labCategoria
            // 
            this.labCategoria.AutoSize = true;
            this.labCategoria.BackColor = System.Drawing.Color.Black;
            this.labCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCategoria.Location = new System.Drawing.Point(353, 452);
            this.labCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCategoria.Name = "labCategoria";
            this.labCategoria.Size = new System.Drawing.Size(371, 52);
            this.labCategoria.TabIndex = 4;
            this.labCategoria.Text = "Categoria: Juvenil";
            this.labCategoria.Visible = false;
            // 
            // labNumInv
            // 
            this.labNumInv.AutoSize = true;
            this.labNumInv.BackColor = System.Drawing.Color.Black;
            this.labNumInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumInv.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labNumInv.Location = new System.Drawing.Point(637, 235);
            this.labNumInv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNumInv.Name = "labNumInv";
            this.labNumInv.Size = new System.Drawing.Size(206, 36);
            this.labNumInv.TabIndex = 5;
            this.labNumInv.Text = "Valor Inválido.";
            this.labNumInv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labNumInv);
            this.Controls.Add(this.labCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.labDigite);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exercício 30";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDigite;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.Label labNumInv;
    }
}

