namespace exercicio25
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
            btnlimp = new Button();
            label1 = new Label();
            txb1 = new TextBox();
            lbn2 = new Label();
            SuspendLayout();
            // 
            // lbn1
            // 
            lbn1.AutoSize = true;
            lbn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn1.Location = new Point(18, 70);
            lbn1.Name = "lbn1";
            lbn1.Size = new Size(73, 21);
            lbn1.TabIndex = 0;
            lbn1.Text = "Número";
            lbn1.Click += label1_Click;
            // 
            // btncalc
            // 
            btncalc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalc.Location = new Point(468, 276);
            btncalc.Margin = new Padding(3, 2, 3, 2);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(82, 38);
            btncalc.TabIndex = 2;
            btncalc.Text = "calcular";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // btnlimp
            // 
            btnlimp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimp.Location = new Point(584, 276);
            btnlimp.Margin = new Padding(3, 2, 3, 2);
            btnlimp.Name = "btnlimp";
            btnlimp.Size = new Size(82, 38);
            btnlimp.TabIndex = 3;
            btnlimp.Text = "limpar";
            btnlimp.UseVisualStyleBackColor = true;
            btnlimp.Click += btnlimp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 7);
            label1.Name = "label1";
            label1.Size = new Size(328, 21);
            label1.TabIndex = 7;
            label1.Text = "DIGITE UM NÚMERO DIFERENTE DE ZERO.";
            // 
            // txb1
            // 
            txb1.Location = new Point(127, 71);
            txb1.Margin = new Padding(3, 2, 3, 2);
            txb1.Name = "txb1";
            txb1.Size = new Size(110, 23);
            txb1.TabIndex = 1;
            // 
            // lbn2
            // 
            lbn2.AutoSize = true;
            lbn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn2.Location = new Point(18, 134);
            lbn2.Name = "lbn2";
            lbn2.Size = new Size(86, 21);
            lbn2.TabIndex = 0;
            lbn2.Text = "Resultado";
            lbn2.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(txb1);
            Controls.Add(btnlimp);
            Controls.Add(btncalc);
            Controls.Add(lbn2);
            Controls.Add(lbn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "POSITIVO OU NEGATIVO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbn1;
        private Button btncalc;
        private Button btnlimp;
        private Label label1;
        private TextBox txb1;
        private Label lbn2;
    }
}
