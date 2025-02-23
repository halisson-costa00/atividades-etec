namespace exercicio_22
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
            labquant = new Label();
            lbpreco = new Label();
            lbresult = new Label();
            txbquant = new TextBox();
            txbpreco = new TextBox();
            btnlimpar = new Button();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // labquant
            // 
            labquant.AutoSize = true;
            labquant.BackColor = SystemColors.ControlLightLight;
            labquant.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labquant.Location = new Point(12, 37);
            labquant.Name = "labquant";
            labquant.Size = new Size(167, 37);
            labquant.TabIndex = 0;
            labquant.Text = "Quantidade";
            // 
            // lbpreco
            // 
            lbpreco.AutoSize = true;
            lbpreco.BackColor = SystemColors.Window;
            lbpreco.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpreco.Location = new Point(12, 107);
            lbpreco.Name = "lbpreco";
            lbpreco.Size = new Size(90, 37);
            lbpreco.TabIndex = 1;
            lbpreco.Text = "Preço";
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.BackColor = SystemColors.ControlLightLight;
            lbresult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbresult.Location = new Point(12, 172);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(145, 37);
            lbresult.TabIndex = 2;
            lbresult.Text = "Resultado";
            lbresult.Visible = false;
            // 
            // txbquant
            // 
            txbquant.Location = new Point(230, 52);
            txbquant.Margin = new Padding(3, 2, 3, 2);
            txbquant.Name = "txbquant";
            txbquant.Size = new Size(257, 23);
            txbquant.TabIndex = 1;
            txbquant.TextChanged += txbquant_TextChanged;
            // 
            // txbpreco
            // 
            txbpreco.Location = new Point(230, 107);
            txbpreco.Margin = new Padding(3, 2, 3, 2);
            txbpreco.Name = "txbpreco";
            txbpreco.Size = new Size(257, 23);
            txbpreco.TabIndex = 2;
            txbpreco.TextChanged += txbpreco_TextChanged;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = SystemColors.ControlLightLight;
            btnlimpar.Location = new Point(575, 263);
            btnlimpar.Margin = new Padding(3, 2, 3, 2);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(82, 22);
            btnlimpar.TabIndex = 4;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += button1_Click;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.ControlLightLight;
            btncalcular.Location = new Point(473, 263);
            btncalcular.Margin = new Padding(3, 2, 3, 2);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(82, 22);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btncalcular);
            Controls.Add(btnlimpar);
            Controls.Add(txbpreco);
            Controls.Add(txbquant);
            Controls.Add(lbresult);
            Controls.Add(lbpreco);
            Controls.Add(labquant);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "VALORES A SEREM SOMADOS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labquant;
        private Label lbpreco;
        private Label lbresult;
        private TextBox txbquant;
        private TextBox txbpreco;
        private Button btnlimpar;
        private Button btncalcular;
    }
}
