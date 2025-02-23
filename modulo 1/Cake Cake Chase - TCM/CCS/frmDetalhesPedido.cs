using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class frmDetalhesPedido : Form
    {
        public frmDetalhesPedido()
        {
            InitializeComponent();
        }

        string[] colunas = { "Produto", "Preço Unitário", "Qtd.", "Preço Total" };
        string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\txt files\pedidos");

        public string[] Pedido
        {
            get { return Pedido; }
            set
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\txt files\pedidos");
                DirectoryInfo d = new DirectoryInfo(caminho);
                FileInfo[] arquivos = d.GetFiles("*.csv");

                foreach (FileInfo arquivo in arquivos)
                {
                    if (arquivo.Name.Contains(value[0])
                        && arquivo.Name.Contains(value[1])
                        && arquivo.Name.Contains(value[2]))
                    {
                        string[] linhas = File.ReadAllLines(arquivo.FullName);
                        string[] campos;
                        campos = linhas[0].Split(new char[] { ';' });
                        int Cols = campos.GetLength(0);
                        DataTable dt = new DataTable();
                        for (int i = 0; i < Cols; i++)
                            dt.Columns.Add(campos[i], typeof(string));
                        DataRow Row;
                        for (int i = 1; i < linhas.GetLength(0); i++)
                        {
                            campos = linhas[i].Split(new char[] { ';' });
                            Row = dt.NewRow();
                            for (int f = 0; f < Cols; f++)
                                Row[f] = campos[f];
                            dt.Rows.Add(Row);
                        }
                        dgDetalhes.DataSource = dt;
                        dgDetalhes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        int qtdtotal = 0;
                        foreach (DataRow dr in dt.Rows)
                            qtdtotal += Convert.ToInt32(dr.Field<string>("Qtd."));
                        lblQtdTotal.Text = $"Qtd. Total: {qtdtotal.ToString()}";

                        float precototalpedido = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            string pt = dr.Field<string>("Preço Total").Replace("R$", "");
                            pt = pt.Replace(",", ".");
                            precototalpedido += float.Parse(pt);
                        }
                        string ptstring = precototalpedido.ToString();
                        ptstring = ptstring.Insert(0, "R$");
                        ptstring = ptstring.Insert(ptstring.Length - 2, ",");

                        if (dt.Rows.Count > 0)
                            lblPrecoTotal.Text = $"Preço Total: {ptstring}";
                        else
                            lblPrecoTotal.Text = "Preço Total: R$ 0,00";
                    }
                }
            }
        }

        private void frmDetalhesPedido_Shown(object sender, EventArgs e)
        {
            dgDetalhes.ClearSelection();
        }
    }
}
