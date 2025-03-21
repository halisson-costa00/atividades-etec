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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void MostrarFormMdi<T>() where T : Form
        {
            var k = MdiChildren.Where(c => c.GetType() == typeof(T)).FirstOrDefault();
            if (k == null)
            {

                k = (Form)Activator.CreateInstance(typeof(T));
                k.MdiParent = this;
                k.Show();
            }
            else
            {
                k.Activate();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormMdi<frmCliente>();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormMdi<frmFuncionario>();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = SystemColors.ControlLight;
            msiUsuário.Text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\usuario.txt"));

            MostrarFormMdi<frmBemVindo>();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormMdi<frmConsultarCliente>();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormMdi<frmConsultarFuncionario>();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormMdi<frmBemVindo>();
        }

        private void fazerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido frm = new frmPedido();
            frm.Cliente = "";
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmTrocar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarPedido frm = new frmConsultarPedido();
            frm.Cliente = "";
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

