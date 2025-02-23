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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbTelefone.Text = "";
            txbNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
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

            if (txbNome.Text == "" ||
                txbEmail.Text == "" ||
                txbTelefone.Text == "")
                MessageBox.Show("Preencha todos os campos!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bool emailValido = false;
                foreach (char c in txbEmail.Text)
                {
                    if (c.Equals('@'))
                        emailValido = true;
                }

                if (!emailValido)
                {
                    MessageBox.Show("Email inválido!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbEmail.Focus();
                }
                else
                {
                    if (txbTelefone.Text.Length < 10 || txbTelefone.Text.Contains(" "))
                    {
                        MessageBox.Show("Telefone inválido!", "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbTelefone.Focus();
                    }
                    else
                    {
                        DataRow[] cliente = dt.Select($"[Email] = '{txbEmail.Text}'");
                        if (cliente.Length > 0)
                        {
                            MessageBox.Show("Já existe um cliente cadastrado com esse email.", "Duplicata",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbEmail.Focus();
                        }
                        else
                        {
                            System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true);
                            sw.Write($"\n{txbNome.Text},{txbEmail.Text},{txbTelefone.Text}");
                            sw.Close();
                            txbNome.Text = "";
                            txbEmail.Text = "";
                            txbTelefone.Text = "";
                            MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                            txbNome.Focus();
                        }
                    }
                }
            }
        }

        private void txbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
