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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\funcionarios.csv");

            if (txbNome.Text == "" ||
                txbEmail.Text == "" ||
                txbLogin.Text == "" ||
                txbSenha.Text == "")
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
                    if (txbLogin.Text.Length < 8)
                    {
                        MessageBox.Show("Seu login deve conter no mínimo 8 caracteres!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbLogin.Focus();
                    }
                    else
                    {
                        if (txbSenha.Text.Length < 8)
                        {
                            MessageBox.Show("Sua senha deve conter no mínimo 8 caracteres!", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbSenha.Focus();
                        }
                        else
                        {
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

                            DataRow[] funcionario = dt.Select($"[login] = '{txbLogin.Text}'");
                            if (funcionario.Length > 0)
                            {
                                MessageBox.Show("Já existe um funcionário cadastrado com esse login.", "Duplicata",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txbLogin.Focus();
                            }
                            else
                            {

                                System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true);
                                int matricula = Convert.ToInt32(dt.Compute("max([matricula])", string.Empty)) + 1;
                                sw.Write($"\n{matricula},{txbNome.Text},{txbEmail.Text},{txbLogin.Text},{txbSenha.Text}");
                                sw.Close();
                                txbNome.Text = "";
                                txbEmail.Text = "";
                                txbLogin.Text = "";
                                txbSenha.Text = "";
                                MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.None);
                                txbNome.Focus();
                            }
                        }
                    }
                }
            }
        }

        private void txbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void pbMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txbSenha.PasswordChar = '\0';
        }

        private void pbMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txbSenha.PasswordChar = '*';
        }

        private void pbMostrar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbMostrar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {

        }
    }
}
