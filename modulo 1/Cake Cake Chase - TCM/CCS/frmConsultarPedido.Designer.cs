namespace test
{
    partial class frmConsultarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Cream Cake", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.lblConsultar.Location = new System.Drawing.Point(267, 43);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(442, 80);
            this.lblConsultar.TabIndex = 29;
            this.lblConsultar.Text = "Consultar Pedidos";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::test.Properties.Resources.n;
            this.pbLogo.Location = new System.Drawing.Point(114, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(129, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 30;
            this.pbLogo.TabStop = false;
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.AllowUserToResizeColumns = false;
            this.dgPedidos.AllowUserToResizeRows = false;
            this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Accidental Presidency", 18.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Accidental Presidency", 18.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPedidos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgPedidos.EnableHeadersVisualStyles = false;
            this.dgPedidos.GridColor = System.Drawing.Color.White;
            this.dgPedidos.Location = new System.Drawing.Point(81, 242);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.RowHeadersVisible = false;
            this.dgPedidos.RowHeadersWidth = 60;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Accidental Presidency", 18.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.dgPedidos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgPedidos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.dgPedidos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.dgPedidos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.dgPedidos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.dgPedidos.RowTemplate.Height = 32;
            this.dgPedidos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedidos.Size = new System.Drawing.Size(643, 229);
            this.dgPedidos.TabIndex = 31;
            this.dgPedidos.SelectionChanged += new System.EventHandler(this.dgClientes_SelectionChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Accidental Presidency", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "",
            "Cliente",
            "Data"});
            this.cbFiltro.Location = new System.Drawing.Point(81, 175);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(189, 33);
            this.cbFiltro.TabIndex = 32;
            this.cbFiltro.TextChanged += new System.EventHandler(this.cbFiltro_TextChanged);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Enabled = false;
            this.txbFiltro.Font = new System.Drawing.Font("Accidental Presidency", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Location = new System.Drawing.Point(310, 175);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(261, 32);
            this.txbFiltro.TabIndex = 33;
            this.txbFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFiltro_KeyDown);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrar.Font = new System.Drawing.Font("Accidental Presidency", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnFiltrar.Location = new System.Drawing.Point(604, 174);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 33);
            this.btnFiltrar.TabIndex = 34;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnApagar.Enabled = false;
            this.btnApagar.Font = new System.Drawing.Font("Accidental Presidency", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnApagar.Location = new System.Drawing.Point(81, 504);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(136, 33);
            this.btnApagar.TabIndex = 35;
            this.btnApagar.Text = "Apagar Pedido";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Font = new System.Drawing.Font("Accidental Presidency", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.btnMostrar.Location = new System.Drawing.Point(588, 504);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 33);
            this.btnMostrar.TabIndex = 36;
            this.btnMostrar.Text = "Mostrar Detalhes";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmConsultarPedido
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(191)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 608);
            this.Name = "frmConsultarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedido";
            this.Load += new System.EventHandler(this.frmConsultarCliente_Load);
            this.Shown += new System.EventHandler(this.frmConsultarCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnMostrar;
    }
}