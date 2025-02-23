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
            // Declara uma vari�vel 'resultado' do tipo long (para suportar valores grandes) e inicializa com 1
            long resultado = 1;

            // Verifica se a caixa de texto est� vazia ou se o valor inserido � maior que 25
            if (string.IsNullOrEmpty(txb1.Text) || int.Parse(txb1.Text) > 25)
            {
                // Se o campo estiver vazio ou o n�mero for maior que 25, exibe uma mensagem de erro
                lbresult.Text = "Digite um n�mero entre 1 a 25!";
            }
            // Verifica se o n�mero inserido � menor que 0 (n�o � poss�vel calcular o fatorial de n�meros negativos)
            else if (int.Parse(txb1.Text) < 0)
            {
                // Exibe uma mensagem de erro se o n�mero for negativo
                lbresult.Text = "O fatorial n�o � definido para n�meros negativos!!!";
            }
            else
            {
                // Inicia o c�lculo do fatorial. O loop come�a em 2 e vai at� o valor inserido.
                for (int contagem = 2; contagem <= int.Parse(txb1.Text); contagem++)
                {
                    // Multiplica o valor atual de 'resultado' pela vari�vel de controle 'contagem'
                    resultado *= contagem;
                }

                // Converte o resultado para string e exibe o valor calculado no r�tulo lbresult
                lbresult.Text = resultado.ToString();
            }
        }

    }
}
