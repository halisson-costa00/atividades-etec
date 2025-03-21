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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\funcionarios.csv");

        public void atualizaTabela(string caminhoCSV, DataGridView datagridview)
        {
            string[] linhas = File.ReadAllLines(caminhoCSV);
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
            dt.Columns.Remove("senha");
            datagridview.DataSource = dt;
            datagridview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridview.ClearSelection();
        }

        public DataTable retornaTabela(string caminhoCSV)
        {
            string[] linhas = File.ReadAllLines(caminhoCSV);
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
            dt.Columns.Remove("senha");
            return dt;
        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            atualizaTabela(caminho, dgFuncionarios);
            cbFiltro.Text = "Login";
        }

        private void dgFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFuncionarios.SelectedRows.Count > 0)
                btnApagar.Enabled = true;
            else
                btnApagar.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "" && txbFiltro.Text == "")
                atualizaTabela(caminho, dgFuncionarios);
            else
            {
                try
                {
                    atualizaTabela(caminho, dgFuncionarios);

                    string coluna = cbFiltro.Text;
                    string criterio = txbFiltro.Text;

                    DataTable dt = retornaTabela(caminho);
                    DataRow[] linhasfiltradas = dt.Select($"[{coluna}] like '%{criterio}%'");
                    if (linhasfiltradas.Length > 0)
                    {
                        DataTable ndt = linhasfiltradas.CopyToDataTable();
                        dgFuncionarios.DataSource = ndt;
                        dgFuncionarios.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum funcionário encontrado.", "Não encontrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbFiltro.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Nenhum funcionário encontrado.", "Não encontrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFiltro.Focus();
                }
            }
        }

        private void frmConsultarFuncionario_Shown(object sender, EventArgs e)
        {
            dgFuncionarios.ClearSelection();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que quer apagar esse(s) {dgFuncionarios.SelectedRows.Count} funcionário(s)?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                var matriculas = new List<string>();
                foreach (DataGridViewRow row in dgFuncionarios.SelectedRows)
                {
                    matriculas.Add(row.Cells[0].Value.ToString());
                }

                foreach (string matricula in matriculas) 
                { 
                    var todaslinhas = new List<string>(File.ReadAllLines(caminho));

                    foreach (string line in todaslinhas)
                    {
                        if (line.Split(',')[0] == matricula)
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
                MessageBox.Show("Funcionário(s) apagado(s) com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.None);


                atualizaTabela(caminho, dgFuncionarios);
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
    }
}