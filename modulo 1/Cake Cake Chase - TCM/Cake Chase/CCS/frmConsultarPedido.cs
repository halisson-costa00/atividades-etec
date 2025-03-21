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

namespace test
{
    public partial class frmConsultarPedido : Form
    {
        public frmConsultarPedido()
        {
            InitializeComponent();
        }
        bool abaCliente = false;
        string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\pedidos");

        public string Cliente
        {
            get { return txbFiltro.Text; }
            set
            {
                if (value != "")
                {
                    cbFiltro.Text = "Cliente";
                    txbFiltro.Text = value;

                    try
                    {
                        criaDataTable(dgPedidos, caminho);
                        DataTable dtpedidos = ((DataTable)dgPedidos.DataSource);

                        string coluna = cbFiltro.Text;
                        string criterio = txbFiltro.Text;

                        DataRow[] linhasfiltradas = dtpedidos.Select($"[{coluna}] like '%{criterio}%'");
                        if (linhasfiltradas.Length > 0)
                        {
                            DataTable ndt = linhasfiltradas.CopyToDataTable();
                            dgPedidos.DataSource = ndt;
                            dgPedidos.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum pedido encontrado.", "Não encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbFiltro.Focus();
                            dgPedidos.ClearSelection();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nenhum pedido encontrado.", "Não encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbFiltro.Focus();
                        dgPedidos.ClearSelection();
                    }
                }
                else
                    criaDataTable(dgPedidos, caminho);
            }
        }

        private void criaDataTable(DataGridView dataGridView, string caminho)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Data");
            dt.Columns.Add("Valor Total");

            DirectoryInfo d = new DirectoryInfo(caminho);
            FileInfo[] arquivos = d.GetFiles("*.csv");

            foreach (FileInfo f in arquivos)
            {
                DataRow dr = dt.NewRow();
                string nomearquivo = f.Name.Replace(".csv", "");
                string[] dados = nomearquivo.Split(';');

                for (int i = 0; i < dados.Length - 1; i++)
                {
                    dr[i] = dados[i].ToString();
                }
                dt.Rows.Add(dr);
            }

            foreach (DataRow dr in dt.Rows)
            {
                string valormasc = dr[2].ToString().Insert(0,"R$");
                dr[2] = valormasc;
            }

            dataGridView.DataSource = dt;
        }
        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            cbFiltro.Text = "Cliente";
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count > 0)
                btnApagar.Enabled = true;
            else
                btnApagar.Enabled = false;

            if (dgPedidos.SelectedRows.Count == 1)
                btnMostrar.Enabled = true;
            else
                btnMostrar.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                criaDataTable(dgPedidos, caminho);
                DataTable dtpedidos = ((DataTable)dgPedidos.DataSource);

                string coluna = cbFiltro.Text;
                string criterio = txbFiltro.Text;

                DataRow[] linhasfiltradas = dtpedidos.Select($"[{coluna}] like '%{criterio}%'");
                if (linhasfiltradas.Length > 0)
                {
                    DataTable ndt = linhasfiltradas.CopyToDataTable();
                    dgPedidos.DataSource = ndt;
                    dgPedidos.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Nenhum pedido encontrado.", "Não encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFiltro.Focus();
                    dgPedidos.ClearSelection();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum pedido encontrado.", "Não encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFiltro.Focus();
                dgPedidos.ClearSelection();
            }
        }

        private void frmConsultarCliente_Shown(object sender, EventArgs e)
        {
            dgPedidos.ClearSelection();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que quer apagar esse(s) {dgPedidos.SelectedRows.Count} pedido(s)?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                List<string[]> linhas = new List<string[]>();
                foreach (DataGridViewRow row in dgPedidos.SelectedRows)
                {
                    string[] linha = {"","",""};
                    for (int i = 0; i < row.Cells.Count; i++) 
                    {
                        string dado = row.Cells[i].Value.ToString();
                        linha[i] = dado;
                    }
                    linhas.Add(linha);
                }

                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\txt files\pedidos");
                DirectoryInfo d = new DirectoryInfo(caminho);
                FileInfo[] arquivos = d.GetFiles("*.csv");

                foreach (string[] linha in linhas)
                {
                    foreach (FileInfo arquivo in arquivos)
                    {
                        if (arquivo.Name.Contains(linha[0]) 
                            && arquivo.Name.Contains(linha[1]) 
                            && arquivo.Name.Contains(linha[2]))
                            File.Delete(arquivo.FullName);
                    }
                }            

                MessageBox.Show("Cliente(s) apagado(s) com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.None);


                criaDataTable(dgPedidos, caminho);
                dgPedidos.ClearSelection();

                txbFiltro.Text = string.Empty;
                cbFiltro.Text = string.Empty;
            }
        }

        private void txbFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltrar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void cbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text != string.Empty)
                txbFiltro.Enabled = true;
            else
            {
                txbFiltro.Text = "";
                txbFiltro.Enabled = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] pedido = { "", "", "", "" };
            for (int i = 0; i < pedido.Length - 1; i++)
            {
                string str = dgPedidos.SelectedRows[0].Cells[i].Value.ToString();
                if (str.Contains("R$"))
                {
                    str = str.Replace("R$", "");
                    pedido[i] = str;
                }
                else
                    pedido[i] = str;
            }
            
            frmDetalhesPedido frm = new frmDetalhesPedido();
            frm.Pedido = pedido;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}