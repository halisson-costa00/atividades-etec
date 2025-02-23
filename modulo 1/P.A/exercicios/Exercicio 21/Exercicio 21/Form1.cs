using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_21
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
            lbmedia.Text = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            float n1,n2,n3,media;
            n1 = float.Parse(txb1.Text);
            n2 = float.Parse(txb2.Text);    
            n3 = float.Parse(txb3.Text);
            media= (n1 + n2 + n3) / 3;
            lbmedia.Text = $"media={Math.Round(media,2)}";
            lbmedia.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
