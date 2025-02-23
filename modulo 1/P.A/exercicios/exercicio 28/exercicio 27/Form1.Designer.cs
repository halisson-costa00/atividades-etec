namespace exercicio_27
{
    partial class FIBONACCI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIBONACCI));
            this.btnCALC = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.btnLIMP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCALC
            // 
            this.btnCALC.Location = new System.Drawing.Point(540, 389);
            this.btnCALC.Name = "btnCALC";
            this.btnCALC.Size = new System.Drawing.Size(91, 36);
            this.btnCALC.TabIndex = 2;
            this.btnCALC.Text = "CALCULAR";
            this.btnCALC.UseVisualStyleBackColor = true;
            this.btnCALC.Click += new System.EventHandler(this.btnADC_Click);
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(209, 106);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(333, 32);
            this.txb1.TabIndex = 1;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // btnLIMP
            // 
            this.btnLIMP.Location = new System.Drawing.Point(678, 389);
            this.btnLIMP.Name = "btnLIMP";
            this.btnLIMP.Size = new System.Drawing.Size(91, 36);
            this.btnLIMP.TabIndex = 4;
            this.btnLIMP.Text = "LIMPAR";
            this.btnLIMP.UseVisualStyleBackColor = true;
            this.btnLIMP.Click += new System.EventHandler(this.btnLIMP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maior número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menor número";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(284, 162);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(0, 13);
            this.lblMa.TabIndex = 8;
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Location = new System.Drawing.Point(287, 188);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(0, 13);
            this.lblMe.TabIndex = 9;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(287, 210);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(258, 74);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 13);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Número:";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(327, 74);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(13, 13);
            this.lblI.TabIndex = 12;
            this.lblI.Text = "1";
            // 
            // FIBONACCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLIMP);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.btnCALC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FIBONACCI";
            this.Text = "FIBONACCI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCALC;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button btnLIMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblI;
    }
}

