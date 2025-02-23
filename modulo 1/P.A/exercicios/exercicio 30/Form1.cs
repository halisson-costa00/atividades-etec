using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex30
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
            txbIdade.Text = string.Empty;
            labCategoria.Visible = false;
            labNumInv.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            labNumInv.Visible = false;

            if (StringNumerica(txbIdade.Text, "int", false))
            {
                int idade = Convert.ToInt32(txbIdade.Text);
                if (idade < 5 || idade > 25)
                    labNumInv.Visible = true;
                else 
                {
                    if (idade >= 5 && idade <= 10)
                        labCategoria.Text = "Categoria: Infantil";
                    else
                    {
                        if (idade <= 15)
                            labCategoria.Text = "Categoria: Juvenil";
                        else
                        {
                            if (idade <= 20)
                                labCategoria.Text = "Categoria: Júnior";
                            else
                                labCategoria.Text = "Categoria: Profissional";
                        }
                    }
                    labCategoria.Visible = true;
                }
            }
            else
                labNumInv.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
