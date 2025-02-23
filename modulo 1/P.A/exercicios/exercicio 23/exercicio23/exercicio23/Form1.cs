namespace exercicio23
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimp2_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
            lbn4.Text = "";
        }

        private void btncalc1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, menor;
            n1 = float.Parse(txb1.Text);
            n2 = float.Parse(txb2.Text);
            n3 = float.Parse(txb3.Text);
            menor = n1;
            if (n2 <= menor)
            {
                menor = n2;

            }
            if (n3 <= menor)
            {
                menor = n3;
            }
            lbn4.Text=menor.ToString(); 
            lbn4.Visible=true; 
        }

        private void lbn4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
