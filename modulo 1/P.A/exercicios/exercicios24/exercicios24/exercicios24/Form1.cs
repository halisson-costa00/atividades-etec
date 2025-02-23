namespace exercicios24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            lbn3.Text = "";

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int anodenascimento, anoatual, idade;
            anodenascimento = Convert.ToInt32(txb1.Text);
            anoatual = Convert.ToInt32(txb2.Text);
            idade = anoatual - anodenascimento;
            lbn3.Text = idade.ToString();
            lbn3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbn1_Click(object sender, EventArgs e)
        {

        }
    }
}
