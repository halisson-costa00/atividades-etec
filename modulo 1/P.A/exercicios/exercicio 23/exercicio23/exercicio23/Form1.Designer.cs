namespace exercicio23
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
            btncalc1 = new Button();
            btnlimp2 = new Button();
            txb1 = new TextBox();
            txb2 = new TextBox();
            txb3 = new TextBox();
            lbn4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbn1
            // 
            lbn1.AutoSize = true;
            lbn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn1.Location = new Point(32, 76);
            lbn1.Name = "lbn1";
            lbn1.Size = new Size(60, 15);
            lbn1.TabIndex = 0;
            lbn1.Text = "Número1";
            lbn1.Click += label1_Click;
            // 
            // lbn2
            // 
            lbn2.AutoSize = true;
            lbn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn2.Location = new Point(32, 127);
            lbn2.Name = "lbn2";
            lbn2.Size = new Size(58, 15);
            lbn2.TabIndex = 1;
            lbn2.Text = "número2";
            // 
            // lbn3
            // 
            lbn3.AutoSize = true;
            lbn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn3.Location = new Point(32, 168);
            lbn3.Name = "lbn3";
            lbn3.Size = new Size(58, 15);
            lbn3.TabIndex = 2;
            lbn3.Text = "número3";
            // 
            // btncalc1
            // 
            btncalc1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalc1.Location = new Point(497, 247);
            btncalc1.Margin = new Padding(3, 2, 3, 2);
            btncalc1.Name = "btncalc1";
            btncalc1.Size = new Size(82, 22);
            btncalc1.TabIndex = 3;
            btncalc1.Text = "calcular";
            btncalc1.UseVisualStyleBackColor = true;
            btncalc1.Click += btncalc1_Click;
            // 
            // btnlimp2
            // 
            btnlimp2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimp2.Location = new Point(611, 247);
            btnlimp2.Margin = new Padding(3, 2, 3, 2);
            btnlimp2.Name = "btnlimp2";
            btnlimp2.Size = new Size(82, 22);
            btnlimp2.TabIndex = 4;
            btnlimp2.Text = "limpar";
            btnlimp2.UseVisualStyleBackColor = true;
            btnlimp2.Click += btnlimp2_Click;
            // 
            // txb1
            // 
            txb1.Location = new Point(138, 76);
            txb1.Margin = new Padding(3, 2, 3, 2);
            txb1.Name = "txb1";
            txb1.Size = new Size(110, 23);
            txb1.TabIndex = 5;
            txb1.TextChanged += textBox1_TextChanged;
            // 
            // txb2
            // 
            txb2.Location = new Point(138, 127);
            txb2.Margin = new Padding(3, 2, 3, 2);
            txb2.Name = "txb2";
            txb2.Size = new Size(110, 23);
            txb2.TabIndex = 6;
            // 
            // txb3
            // 
            txb3.Location = new Point(138, 168);
            txb3.Margin = new Padding(3, 2, 3, 2);
            txb3.Name = "txb3";
            txb3.Size = new Size(110, 23);
            txb3.TabIndex = 7;
            // 
            // lbn4
            // 
            lbn4.AutoSize = true;
            lbn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbn4.Location = new Point(32, 223);
            lbn4.Name = "lbn4";
            lbn4.Size = new Size(62, 15);
            lbn4.TabIndex = 8;
            lbn4.Text = "Resultado";
            lbn4.Visible = false;
            lbn4.Click += lbn4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 25);
            label1.TabIndex = 9;
            label1.Text = "Digite os Números para saber o menor < entre eles !";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(lbn4);
            Controls.Add(txb3);
            Controls.Add(txb2);
            Controls.Add(txb1);
            Controls.Add(btnlimp2);
            Controls.Add(btncalc1);
            Controls.Add(lbn3);
            Controls.Add(lbn2);
            Controls.Add(lbn1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "MATEMATICA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbn1;
        private Label lbn2;
        private Label lbn3;
        private Button btncalc1;
        private Button btnlimp2;
        private TextBox txb1;
        private TextBox txb2;
        private TextBox txb3;
        private Label lbn4;
        private Label label1;
    }
}
