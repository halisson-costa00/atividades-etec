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
using static System.Windows.Forms.LinkLabel;

namespace test
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSenha.Text = string.Empty;
            txbUsuario.Text = string.Empty;
            txbUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\funcionarios.csv");
            string caminhousuario = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\usuario.txt");

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

            try 
            {
                if (txbUsuario.Text == "admin" && txbSenha.Text == "loopstack")
                {
                    System.IO.StreamWriter sw = new StreamWriter(caminhousuario, false);
                    sw.Write(txbUsuario.Text);
                    sw.Close();

                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.Show();
                }
                else 
                {
                    DataRow[] func = dt.Select($"[login] = '{txbUsuario.Text}'");
                    if (func[0][4].ToString() == txbSenha.Text)
                    {
                        System.IO.StreamWriter sw = new StreamWriter(caminhousuario, false);
                        sw.Write(txbUsuario.Text);
                        sw.Close();
                        
                        this.Hide();
                        frmMenu frm = new frmMenu();
                        frm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbUsuario.Focus();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
