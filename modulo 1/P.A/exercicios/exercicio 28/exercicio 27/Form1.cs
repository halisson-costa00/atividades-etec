using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_27
{
    public partial class FIBONACCI : Form
    {
        int i = 1;
        double numero = 0;
        double Ma, Me;
        public FIBONACCI()
        {
            InitializeComponent();
        }

        private void btnLIMP_Click(object sender, EventArgs e)
        {
            txb1.Text = " ";
            lblMa.Text = " ";
            lblMe.Text = " ";
            lblErro.Text = " ";
            lblI.Text = " ";
            i = 1;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnADC_Click_1(object sender, EventArgs e)
        {

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnADC_Click(object sender, EventArgs e)
        {
            try
            {
                
                numero = Convert.ToDouble(txb1.Text);
                if (i == 1)
                {
                    Ma = numero;
                    Me = numero;
                    if (numero > Ma)
                    {
                        Ma = numero;
                    }
                    if (numero < Me)
                    {
                        Me = numero;
                    }
                    i++;
                    lblI.Text = Convert.ToString(i);
                }
                if (i <= 20)
                {
                    if (numero > Ma)
                    {
                        Ma = numero;
                    }
                    if (numero < Me)
                    {
                        Me = numero;
                    }
                    i++;
                    lblI.Text = Convert.ToString(i);
                }
                else if (i == 21)
                {
                    lblMa.Text = Convert.ToString(Ma);
                    lblMe.Text = Convert.ToString(Me);
                    i++;
                }
                else
                {
                    lblErro.Text = "Limpe primeiro";
                }
            }
            catch 
            {
                lblErro.Text = "Valor inválido";
            }
            
        }
    }
}
