using System.Diagnostics.Eventing.Reader;

namespace exercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            lbn2.Text = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txb1.Text);
            {
                if (numero == 0)
                {
                  
                    lbn2.Text = ("O Número Digitado é zero!!!");
                }
                if (numero >0) 
                {
                    lbn2.Text = ("O Número é Positivo");

                }
                    if (numero <0) 
                    lbn2.Text = ("O Número é Negativo");
                }
            }
        }
    }

                

       

