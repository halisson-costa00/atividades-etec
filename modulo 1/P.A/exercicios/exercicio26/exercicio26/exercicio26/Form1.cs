namespace exercicio26
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

        private void bnlimp_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            lbresult.Text = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declara uma variável 'resultado' do tipo long (para suportar valores grandes) e inicializa com 1
            long resultado = 1;

            // Verifica se a caixa de texto está vazia ou se o valor inserido é maior que 25
            if (string.IsNullOrEmpty(txb1.Text) || int.Parse(txb1.Text) > 25)
            {
                // Se o campo estiver vazio ou o número for maior que 25, exibe uma mensagem de erro
                lbresult.Text = "Digite um número entre 1 a 25!";
            }
            // Verifica se o número inserido é menor que 0 (não é possível calcular o fatorial de números negativos)
            else if (int.Parse(txb1.Text) < 0)
            {
                // Exibe uma mensagem de erro se o número for negativo
                lbresult.Text = "O fatorial não é definido para números negativos!!!";
            }
            else
            {
                // Inicia o cálculo do fatorial. O loop começa em 2 e vai até o valor inserido.
                for (int contagem = 2; contagem <= int.Parse(txb1.Text); contagem++)
                {
                    // Multiplica o valor atual de 'resultado' pela variável de controle 'contagem'
                    resultado *= contagem;
                }

                // Converte o resultado para string e exibe o valor calculado no rótulo lbresult
                lbresult.Text = resultado.ToString();
            }
        }

    }
}
