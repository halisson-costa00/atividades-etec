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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        string Caminho = @"F:\1A-MODULAR\HALISSON2\P.A\WindowsFormsApp1\bloco de notas.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter Sw = new System.IO.StreamWriter(Caminho, true);
            Sw.WriteLine(txb1);
            Sw.WriteLine(txb2);
            Sw.WriteLine(txb3);
            Sw.WriteLine("-----------------------------------");
            Sw.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
        }
    }
}
