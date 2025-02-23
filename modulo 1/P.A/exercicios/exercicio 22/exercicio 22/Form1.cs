namespace exercicio_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbquant.Text = "";
            txbpreco.Text = "";
            lbresult.Text = "";

        }

        private void txbquant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
           double quantidade;
            double preco, resultado;
            quantidade = Convert.ToDouble (txbquant.Text);
            preco = float.Parse(txbpreco.Text);
            resultado = quantidade * preco;
            lbresult.Text = $"{Math.Round(resultado, 2)}";
            lbresult.Visible = true;

        }

        private void txbpreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
