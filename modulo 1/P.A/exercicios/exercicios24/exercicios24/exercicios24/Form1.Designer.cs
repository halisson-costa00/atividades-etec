namespace exercicios24
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
            lbn2 = new Label();
            lbn3 = new Label();
            txb1 = new TextBox();
            txb2 = new TextBox();
            btncalc = new Button();
            btnlimp = new Button();
            SuspendLayout();
            // 
            // lbn1
            // 
            lbn1.AutoSize = true;
            lbn1.BackColor = SystemColors.Info;
            lbn1.Location = new Point(8, 55);
            lbn1.Name = "lbn1";
            lbn1.Size = new Size(110, 15);
            lbn1.TabIndex = 0;
            lbn1.Text = "Ano de nascimento";
            lbn1.Click += lbn1_Click;
            // 
            // lbn2
            // 
            lbn2.AutoSize = true;
            lbn2.BackColor = SystemColors.Info;
            lbn2.Location = new Point(8, 121);
            lbn2.Name = "lbn2";
            lbn2.Size = new Size(58, 15);
            lbn2.TabIndex = 1;
            lbn2.Text = "Ano atual";
            // 
            // lbn3
            // 
            lbn3.AutoSize = true;
            lbn3.BackColor = SystemColors.Info;
            lbn3.Location = new Point(10, 210);
            lbn3.Name = "lbn3";
            lbn3.Size = new Size(56, 15);
            lbn3.TabIndex = 2;
            lbn3.Text = "resultado";
            lbn3.Visible = false;
            // 
            // txb1
            // 
            txb1.BackColor = SystemColors.Info;
            txb1.Location = new Point(124, 52);
            txb1.Margin = new Padding(3, 2, 3, 2);
            txb1.Multiline = true;
            txb1.Name = "txb1";
            txb1.Size = new Size(54, 26);
            txb1.TabIndex = 1;
            txb1.TextChanged += textBox1_TextChanged;
            // 
            // txb2
            // 
            txb2.BackColor = SystemColors.Info;
            txb2.Location = new Point(111, 110);
            txb2.Margin = new Padding(3, 2, 3, 2);
            txb2.Multiline = true;
            txb2.Name = "txb2";
            txb2.Size = new Size(67, 26);
            txb2.TabIndex = 2;
            // 
            // btncalc
            // 
            btncalc.BackColor = SystemColors.Info;
            btncalc.Location = new Point(533, 301);
            btncalc.Margin = new Padding(3, 2, 3, 2);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(65, 36);
            btncalc.TabIndex = 3;
            btncalc.Text = "calcular";
            btncalc.UseVisualStyleBackColor = false;
            btncalc.Click += btncalc_Click;
            // 
            // btnlimp
            // 
            btnlimp.BackColor = SystemColors.Info;
            btnlimp.Location = new Point(615, 301);
            btnlimp.Margin = new Padding(3, 2, 3, 2);
            btnlimp.Name = "btnlimp";
            btnlimp.Size = new Size(73, 36);
            btnlimp.TabIndex = 4;
            btnlimp.Text = "limpar";
            btnlimp.UseVisualStyleBackColor = false;
            btnlimp.Click += btnlimp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 338);
            Controls.Add(btnlimp);
            Controls.Add(btncalc);
            Controls.Add(txb2);
            Controls.Add(txb1);
            Controls.Add(lbn3);
            Controls.Add(lbn2);
            Controls.Add(lbn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "DESCOBRINDO A IDADE :";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbn1;
        private Label lbn2;
        private Label lbn3;
        private TextBox txb1;
        private TextBox txb2;
        private Button btncalc;
        private Button btnlimp;
    }
}
