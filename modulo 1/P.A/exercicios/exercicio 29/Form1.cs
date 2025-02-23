using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool StringNumerica(string str, string tipoDeDado, bool assinado)
        {
            if (str == "" || str == "," || str == "-")
                return false;

            if (!assinado)
            {
                if (str[0] == '-')
                    return false;
            }

            if (tipoDeDado == "decimal")
            {
                int virgulas = 0;
                int i = 0;
                foreach (char c in str)
                {
                    if (c.Equals(',') || (c.Equals('-') && i == 0))
                    {
                        if (c.Equals(','))
                        {
                            virgulas++;
                            if (virgulas > 1)
                                return false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(c) == false)
                            return false;
                    }
                    i++;
                }
                return true;
            }

            if (tipoDeDado == "int")
            {
                int i = 0;
                foreach (char c in str)
                {
                    if (!(c.Equals('-') && i == 0))
                    {
                        if (char.IsDigit(c) == false)
                            return false;
                    }
                    i++;
                }
                return true;
            }
            return false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNum.Text = "";
            labMes.Visible = false;
            labNumInv.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            labNumInv.Visible = false;

            if(!StringNumerica(txbNum.Text, "decimal", false))
                labNumInv.Visible = true;
            else
            {
                int num = Convert.ToInt32(txbNum.Text);
                if(num <= 0 || num > 12)
                {
                    labNumInv.Visible = true;
                }
                else
                {
                    string mes;
                    mes = num == 1 ? "Janeiro" :
                    num == 2 ? "Fevereiro" :
                    num == 3 ? "Março" :
                    num == 4 ? "Abril" :
                    num == 5 ? "Maio" :
                    num == 6 ? "Junho" :
                    num == 7 ? "Julho" :
                    num == 8 ? "Agosto" :
                    num == 9 ? "Setembro" :
                    num == 10 ? "Outubro" :
                    num == 11 ? "Novembro" : "Dezembro";

                    labMes.Text = $"Mês correspondente = {mes}";
                    labMes.Visible = true;
                }
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
