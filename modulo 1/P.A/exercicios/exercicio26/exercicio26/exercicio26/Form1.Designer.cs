namespace exercicio26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbn1 = new Label();
            btncalc = new Button();
            txb1 = new TextBox();
            btnlimp = new Button();
            lbresult = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbn1
            // 
            lbn1.AutoSize = true;
            lbn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn1.Location = new Point(24, 80);
            lbn1.Name = "lbn1";
            lbn1.Size = new Size(77, 21);
            lbn1.TabIndex = 0;
            lbn1.Text = "Número ";
            // 
            // btncalc
            // 
            btncalc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalc.Location = new Point(488, 286);
            btncalc.Margin = new Padding(3, 2, 3, 2);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(100, 30);
            btncalc.TabIndex = 2;
            btncalc.Text = "Calcular";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // txb1
            // 
            txb1.Location = new Point(157, 80);
            txb1.Margin = new Padding(3, 2, 3, 2);
            txb1.Name = "txb1";
            txb1.Size = new Size(110, 23);
            txb1.TabIndex = 1;
            // 
            // btnlimp
            // 
            btnlimp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimp.Location = new Point(607, 286);
            btnlimp.Margin = new Padding(3, 2, 3, 2);
            btnlimp.Name = "btnlimp";
            btnlimp.Size = new Size(82, 30);
            btnlimp.TabIndex = 3;
            btnlimp.Text = "Limpar";
            btnlimp.UseVisualStyleBackColor = true;
            btnlimp.Click += bnlimp_Click;
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbresult.Location = new Point(24, 127);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(86, 21);
            lbresult.TabIndex = 6;
            lbresult.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(668, 30);
            label3.TabIndex = 7;
            label3.Text = "Digite um Número inteiro Para calcular  o Fatorial Entre  (1-25):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(lbresult);
            Controls.Add(btnlimp);
            Controls.Add(txb1);
            Controls.Add(btncalc);
            Controls.Add(lbn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "FATORIAL ATÉ O (25)!!!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbn1;
        private Button btncalc;
        private TextBox txb1;
        private Button btnlimp;
        private Label lbresult;
        private Label label3;
        private Label lbn3;
    }
}
