using System;
using System.Windows.Forms;

namespace test
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        int buffer = 0;
        int pontos = 1;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (pontos == 3)
            {
                pontos = 1;
                lblPontos.Text = ".";
            }
            else
            {
                pontos++;
                lblPontos.Text += ".";
            }
            
            
            if (pgbSplash.Value < 100)
                pgbSplash.Value += 10;
            else
            {
                buffer++;
                if (buffer > 5)
                {
                    timerSplash.Enabled = false;
                    this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.Show();
                }
            }
        }
    }
}
