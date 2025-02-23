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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\clientes.csv");
        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines(caminho);
            string[] campos;
            campos = linhas[0].Split(new char[] { ',' });
            int Cols = campos.GetLength(0);
            DataTable dt = new DataTable();
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(campos[i], typeof(string));
            DataRow Row;
            for (int i = 1; i < linhas.GetLength(0); i++)
            {
                campos = linhas[i].Split(new char[] { ',' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = campos[f];
                dt.Rows.Add(Row);
            }

            foreach (DataRow dr in dt.Rows)
            {
                string telmasc = dr[2].ToString();
                telmasc = telmasc.Insert(telmasc.Length - 4, "-");
                telmasc = telmasc.Insert(2, ")");
                telmasc = telmasc.Insert(0, "(");
                dr[2] = telmasc;
            }

            dgClientes.DataSource = dt;
            cbFiltro.Text = "Nome";
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
                btnApagar.Enabled = true;
            else
                btnApagar.Enabled = false;

            if (dgClientes.SelectedRows.Count == 1)
            {
                btnPedido.Enabled = true;
                btnHistorico.Enabled = true;
            }
            else
            {
                btnPedido.Enabled = false;
                btnHistorico.Enabled = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                string[] campos;
                campos = linhas[0].Split(new char[] { ',' });
                int Cols = campos.GetLength(0);
                DataTable dt = new DataTable();
                for (int i = 0; i < Cols; i++)
                    dt.Columns.Add(campos[i], typeof(string));
                DataRow Row;
                for (int i = 1; i < linhas.GetLength(0); i++)
                {
                    campos = linhas[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = campos[f];
                    dt.Rows.Add(Row);
                }
                dgClientes.DataSource = dt;

                string coluna = cbFiltro.Text;
                string criterio = txbFiltro.Text;

                DataRow[] linhasfiltradas = dt.Select($"[{coluna}] like '%{criterio}%'");
                if (linhasfiltradas.Length > 0)
                {
                    DataTable ndt = linhasfiltradas.CopyToDataTable();
                    foreach (DataRow dr in ndt.Rows)
                    {
                        string telmasc = dr[2].ToString();
                        telmasc = telmasc.Insert(telmasc.Length - 4, "-");
                        telmasc = telmasc.Insert(2, ")");
                        telmasc = telmasc.Insert(0, "(");
                        dr[2] = telmasc;
                    }
                    dgClientes.DataSource = ndt;
                    dgClientes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado.", "Não encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFiltro.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cliente encontrado.", "Não encontrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFiltro.Focus();
            }
        }

        private void frmConsultarCliente_Shown(object sender, EventArgs e)
        {
            dgClientes.ClearSelection();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que quer apagar esse(s) {dgClientes.SelectedRows.Count} cliente(s)?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                var emails = new List<string>();
                foreach (DataGridViewRow row in dgClientes.SelectedRows)
                {
                    emails.Add(row.Cells[1].Value.ToString());
                }

                foreach (string email in emails) 
                { 
                    var todaslinhas = new List<string>(File.ReadAllLines(caminho));

                    foreach (string line in todaslinhas)
                    {
                        if (line.Contains(email))
                        {
                            todaslinhas.Remove(line);
                            break;
                        }
                    }

                    var linhasatualizadas = new List<string>(todaslinhas);
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, false);
                    foreach (string line in linhasatualizadas)
                    {
                        if (linhasatualizadas.IndexOf(line) == 0)
                            sw.Write(line);
                        else
                            sw.Write($"\n{line}");
                    }
                    sw.Close();
                }
                MessageBox.Show("Cliente(s) apagado(s) com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.None);

                
                string[] linhas = File.ReadAllLines(caminho);
                string[] campos;
                campos = linhas[0].Split(new char[] { ',' });
                int Cols = campos.GetLength(0);
                DataTable dt = new DataTable();
                for (int i = 0; i < Cols; i++)
                    dt.Columns.Add(campos[i], typeof(string));
                DataRow Row;
                for (int i = 1; i < linhas.GetLength(0); i++)
                {
                    campos = linhas[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = campos[f];
                    dt.Rows.Add(Row);
                }

                foreach (DataRow dr in dt.Rows)
                {
                    string telmasc = dr[2].ToString();
                    telmasc = telmasc.Insert(telmasc.Length - 4, "-");
                    telmasc = telmasc.Insert(2, ")");
                    telmasc = telmasc.Insert(0, "(");
                    dr[2] = telmasc;
                }

                dgClientes.DataSource = dt;
                dgClientes.ClearSelection();

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

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmPedido frm = new frmPedido();
            frm.Cliente = dgClientes.SelectedRows[0].Cells[0].Value.ToString();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmConsultarPedido frm = new frmConsultarPedido();
            frm.Cliente = dgClientes.SelectedRows[0].Cells[0].Value.ToString();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}