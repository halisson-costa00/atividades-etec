using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txbimg_Click(object sender, EventArgs e)
        {

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            if (txb1.Text == "Halisson" && txb2.Text == "12345678910")
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Close();
            }
            else MessageBox.Show("Usúario ou senha incorreto! ", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txb1.Text = " ";
            txb2.Text = " ";
        }
    }
}
