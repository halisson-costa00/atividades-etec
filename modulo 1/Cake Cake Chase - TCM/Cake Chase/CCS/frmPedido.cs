using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;

namespace test
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        public string Cliente
        {
            get { return cbCliente.Text; }
            set
            {
                DataTable dtvazio = new DataTable();
                dgItens.DataSource = dtvazio;

                string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\clientes.csv");
                string[] linhas = File.ReadAllLines(caminho);
                string[] campos;
                campos = linhas[0].Split(new char[] { ',' });
                int Cols = campos.GetLength(0);
                DataTable dt = new DataTable();
                for (int i = 0; i < Cols; i++)
                    dt.Columns.Add(campos[i].ToLower(), typeof(string));
                DataRow Row;
                for (int i = 1; i < linhas.GetLength(0); i++)
                {
                    campos = linhas[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = campos[f];
                    dt.Rows.Add(Row);
                }

                cbCliente.Items.Add("");
                foreach (DataRow dataRow in dt.Rows)
                {
                    string novoitem = dataRow.Field<string>(0);
                    bool jaexiste = false;
                    foreach (string item in cbCliente.Items)
                    {
                        if (item == novoitem) jaexiste = true;
                    }
                    if (!jaexiste)
                        cbCliente.Items.Add(novoitem);
                }
                cbCliente.Text = value;
                this.ActiveControl = null;
            }
        }

        string[] colunas = { "Produto", "Preço Unitário", "Qtd.", "Preço Total" };
        public static DataTable CriaDataTable(string[] colunas)
        {
            DataTable dt = new DataTable();
            foreach (var item in colunas)
            {
                dt.Columns.Add(item);
            }
            return dt;
        }

        public void atualizaTotais(DataTable dt)
        {
            int qtdtotal = 0;
            foreach (DataRow dr in dt.Rows)
                qtdtotal += Convert.ToInt32(dr.Field<string>("Qtd."));
            lblQtdTotal.Text = $"Qtd. Total: {qtdtotal.ToString()}";

            float precototalpedido = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string pt = dr.Field<string>("Preço Total").Replace("R$", "");
                pt = pt.Replace(",", ".");
                precototalpedido += float.Parse(pt);
            }
            string ptstring = precototalpedido.ToString();
            ptstring = ptstring.Insert(0, "R$");
            ptstring = ptstring.Insert(ptstring.Length - 2, ",");

            if (dt.Rows.Count > 0)
                lblPrecoTotal.Text = $"Preço Total: {ptstring}";
            else
                lblPrecoTotal.Text = "Preço Total: R$ 0,00";
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\cardapio.csv");
            string[] linhas = File.ReadAllLines(caminho);
            string[] campos;
            campos = linhas[0].Split(new char[] { ';' });
            int Cols = campos.GetLength(0);
            DataTable dt = new DataTable();
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(campos[i].ToLower(), typeof(string));
            DataRow Row;
            for (int i = 1; i < linhas.GetLength(0); i++)
            {
                campos = linhas[i].Split(new char[] { ';' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = campos[f];
                dt.Rows.Add(Row);
            }

            cbProduto.Items.Add("");
            foreach (DataRow dataRow in dt.Rows)
            {
                string novoitem = dataRow.Field<string>(0);
                bool jaexiste = false;
                foreach (string item in cbProduto.Items)
                {
                    if (item == novoitem) jaexiste = true;
                }
                if (!jaexiste)
                    cbProduto.Items.Add($"R${dataRow.Field<string>(1)} - {novoitem}");
            }

            dgItens.DataSource = CriaDataTable(colunas);
            dgItens.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgItens.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgItens.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            if (cbProduto.Text != "")
                cbQtd.Enabled = true;
            else
                cbQtd.Enabled = false;

            if (cbProduto.Text != "" && cbQtd.Text != "")
                btnAdicionar.Enabled = true;
            else
                btnAdicionar.Enabled = false;
        }

        private void cbQtd_TextChanged(object sender, EventArgs e)
        {
            if (cbProduto.Text != "" && cbQtd.Text != "")
                btnAdicionar.Enabled = true;
            else
                btnAdicionar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbCliente.Text = "";
            cbProduto.Text = "";
            cbQtd.Text = "";
            dgItens.DataSource = CriaDataTable(colunas);
            lblQtdTotal.Text = "Qtd. Total: 0";
            lblPrecoTotal.Text = "Preço Total: R$ 0,00";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DataTable dtpedido = ((DataTable)dgItens.DataSource);

            string nomeproduto = cbProduto.Text.Split('-')[1].Trim();
            bool jaadicionado = false;

            foreach (DataRow dr in dtpedido.Rows)
            {
                if (dr.Field<string>("Produto") == nomeproduto)
                    jaadicionado = true;
            }

            if (jaadicionado)
            {
                MessageBox.Show("Esse produto já está registrado neste pedido!", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (DataGridViewRow dr in dgItens.Rows)
                    if (dr.Cells[0].Value.ToString() == nomeproduto)
                        dr.Selected = true;
            }
            else
            {
                DataRow novoitem = dtpedido.NewRow();

                novoitem[0] = nomeproduto;

                string precounitario = cbProduto.Text.Split('-')[0].Trim();
                novoitem[1] = precounitario;

                novoitem[2] = cbQtd.Text;

                precounitario = precounitario.Replace("R$", "");
                precounitario = precounitario.Replace(",", ".");
                float precototal = float.Parse(precounitario) * Convert.ToInt32(cbQtd.Text);
                string precototalstring = precototal.ToString();
                precototalstring = precototalstring.Insert(0, "R$");
                precototalstring = precototalstring.Insert(precototalstring.Length - 2, ",");

                novoitem[3] = precototalstring;

                dtpedido.Rows.Add(novoitem);
                dgItens.DataSource = dtpedido;
                dgItens.ClearSelection();

                if (dtpedido.Rows.Count > 0 && cbCliente.Text != "")
                    btnRealizar.Enabled = true;
                else
                    btnRealizar.Enabled = false;

                atualizaTotais(dtpedido);
            }
        }

        private void cbCliente_TextChanged(object sender, EventArgs e)
        {
            DataTable dtpedido = ((DataTable)dgItens.DataSource);
            if (dtpedido.Rows.Count > 0 && cbCliente.Text != "")
                btnRealizar.Enabled = true;
            else
                btnRealizar.Enabled = false;
        }

        private void dgItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dgItens.SelectedRows.Count > 0)
                btnRemover.Enabled = true;
            else
                btnRemover.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DataTable dtpedido = ((DataTable)dgItens.DataSource);

            var nomes = new List<string>();
            foreach (DataGridViewRow row in dgItens.SelectedRows)
            {
                nomes.Add(row.Cells[0].Value.ToString());
            }

            foreach (string nome in nomes)
            {
                for (int i = dtpedido.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dtpedido.Rows[i];
                    if (dr["Produto"].ToString() == nome)
                        dr.Delete();
                }
                dtpedido.AcceptChanges();
            }

            dgItens.DataSource = dtpedido;
            dgItens.ClearSelection();

            atualizaTotais(dtpedido);

            if (dtpedido.Rows.Count > 0 && cbCliente.Text != "")
                btnRealizar.Enabled = true;
            else
                btnRealizar.Enabled = false;
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            DataTable dtpedido = ((DataTable)dgItens.DataSource);

            string precototal = lblPrecoTotal.Text.Replace("Preço Total: R$", "");
            string data = DateTime.UtcNow.Date.ToString("dd/MM/yyyy").Replace("/","-");
            string min = DateTime.UtcNow.ToString("mm");
            
            string nomearquivo = $"{cbCliente.Text};{data};{precototal};{min}";
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\txt files\pedidos\{nomearquivo}.csv");

            StreamWriter sw = new StreamWriter(caminho, false);
            foreach (DataGridViewColumn col in dgItens.Columns)
            {
                if (col.Index == 0)
                    sw.Write(col.Name);
                else
                    sw.Write($";{col.Name}");
            }

            foreach (DataGridViewRow row in dgItens.Rows) 
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == 0)
                        sw.Write($"\n{row.Cells[i].Value.ToString()}");
                    else
                        sw.Write($";{row.Cells[i].Value.ToString()}");
                }
            }
            sw.Close();

            MessageBox.Show("Pedido realizado com sucesso!", "Sucesso!",
                                MessageBoxButtons.OK, MessageBoxIcon.None);

            cbCliente.Text = "";
            cbProduto.Text = "";
            cbQtd.Text = "";
            dgItens.DataSource = CriaDataTable(colunas);
            lblQtdTotal.Text = "Qtd. Total: 0";
            lblPrecoTotal.Text = "Preço Total: R$ 0,00";
        }
    }
}
