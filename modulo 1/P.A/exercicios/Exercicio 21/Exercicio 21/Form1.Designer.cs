namespace Exercicio_21
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.lbn1 = new System.Windows.Forms.Label();
            this.lbn2 = new System.Windows.Forms.Label();
            this.lbn3 = new System.Windows.Forms.Label();
            this.lbmedia = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbn1
            // 
            this.lbn1.AutoSize = true;
            this.lbn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn1.Location = new System.Drawing.Point(12, 94);
            this.lbn1.Name = "lbn1";
            this.lbn1.Size = new System.Drawing.Size(157, 31);
            this.lbn1.TabIndex = 0;
            this.lbn1.Text = "NÚMERO1";
            // 
            // lbn2
            // 
            this.lbn2.AutoSize = true;
            this.lbn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn2.Location = new System.Drawing.Point(12, 138);
            this.lbn2.Name = "lbn2";
            this.lbn2.Size = new System.Drawing.Size(157, 31);
            this.lbn2.TabIndex = 1;
            this.lbn2.Text = "NÚMERO2";
            // 
            // lbn3
            // 
            this.lbn3.AutoSize = true;
            this.lbn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn3.Location = new System.Drawing.Point(15, 184);
            this.lbn3.Name = "lbn3";
            this.lbn3.Size = new System.Drawing.Size(157, 31);
            this.lbn3.TabIndex = 2;
            this.lbn3.Text = "NÚMERO3";
            // 
            // lbmedia
            // 
            this.lbmedia.AutoSize = true;
            this.lbmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmedia.Location = new System.Drawing.Point(33, 271);
            this.lbmedia.Name = "lbmedia";
            this.lbmedia.Size = new System.Drawing.Size(105, 31);
            this.lbmedia.TabIndex = 3;
            this.lbmedia.Text = "MÉDIA";
            this.lbmedia.Visible = false;
            this.lbmedia.Click += new System.EventHandler(this.label4_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(611, 402);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "CALCULAR";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(713, 402);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 5;
            this.btnlimp.Text = "LIMPAR";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(210, 94);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(227, 29);
            this.txb1.TabIndex = 1;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // txb2
            // 
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(210, 142);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(227, 29);
            this.txb2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "DIGITE OS NÚMEROS ";
            // 
            // txb3
            // 
            this.txb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb3.Location = new System.Drawing.Point(210, 184);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(227, 29);
            this.txb3.TabIndex = 3;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lbmedia);
            this.Controls.Add(this.lbn3);
            this.Controls.Add(this.lbn2);
            this.Controls.Add(this.lbn1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "ARITMÉTICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbn1;
        private System.Windows.Forms.Label lbn2;
        private System.Windows.Forms.Label lbn3;
        private System.Windows.Forms.Label lbmedia;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label label5;
    }
}

