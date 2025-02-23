namespace Ex29
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labMes = new System.Windows.Forms.Label();
            this.labNumInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDigite
            // 
            this.labDigite.AutoSize = true;
            this.labDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDigite.ForeColor = System.Drawing.Color.White;
            this.labDigite.Location = new System.Drawing.Point(300, 55);
            this.labDigite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDigite.Name = "labDigite";
            this.labDigite.Size = new System.Drawing.Size(471, 39);
            this.labDigite.TabIndex = 0;
            this.labDigite.Text = "Digite um número de 1 a 12:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcular.Location = new System.Drawing.Point(308, 310);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 62);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNum
            // 
            this.txbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNum.Location = new System.Drawing.Point(453, 148);
            this.txbNum.Margin = new System.Windows.Forms.Padding(4);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(177, 98);
            this.txbNum.TabIndex = 2;
            this.txbNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpar.Location = new System.Drawing.Point(624, 310);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 62);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labMes
            // 
            this.labMes.AutoSize = true;
            this.labMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMes.ForeColor = System.Drawing.Color.White;
            this.labMes.Location = new System.Drawing.Point(300, 444);
            this.labMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMes.Name = "labMes";
            this.labMes.Size = new System.Drawing.Size(459, 39);
            this.labMes.TabIndex = 4;
            this.labMes.Text = "Mês Correspondente: Julho";
            this.labMes.Visible = false;
            // 
            // labNumInv
            // 
            this.labNumInv.AutoSize = true;
            this.labNumInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumInv.ForeColor = System.Drawing.Color.White;
            this.labNumInv.Location = new System.Drawing.Point(640, 229);
            this.labNumInv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNumInv.Name = "labNumInv";
            this.labNumInv.Size = new System.Drawing.Size(179, 29);
            this.labNumInv.TabIndex = 5;
            this.labNumInv.Text = "Valor Inválido.";
            this.labNumInv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labNumInv);
            this.Controls.Add(this.labMes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labDigite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Exercício 29";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDigite;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label labMes;
        private System.Windows.Forms.Label labNumInv;
    }
}

