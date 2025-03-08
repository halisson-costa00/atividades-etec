namespace exercicio25
{
    public partial class Form1 : Form
    {
        // Construtor do Formul�rio, respons�vel por inicializar os componentes
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formul�rio (bot�es, caixas de texto, r�tulos, etc.)
        }

        // Evento que � chamado quando o label1 � clicado (n�o est� sendo utilizado no c�digo atual)
        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento n�o faz nada neste momento. Ele pode ser usado para a��es espec�ficas quando o usu�rio clica no label1.
        }

        // Evento que � chamado quando o bot�o "Limpar" (btnlimp) � clicado
        private void btnlimp_Click(object sender, EventArgs e)
        {
            // Limpa a caixa de texto (txb1) e o r�tulo (lbn2) que exibe o resultado
            txb1.Text = ""; // Limpa a caixa de texto
            lbn2.Text = ""; // Limpa o r�tulo de resultado
        }

        // Evento que � chamado quando o bot�o "Calcular" (btncalc) � clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declara��o de vari�vel para armazenar o n�mero inserido
            int numero;

            // Converte o valor inserido na caixa de texto (txb1) para um n�mero inteiro
            numero = Convert.ToInt32(txb1.Text);

            // Verifica o valor do n�mero e exibe o resultado no r�tulo (lbn2)
            if (numero == 0)  // Verifica se o n�mero � zero
            {
                lbn2.Text = ("O N�mero Digitado � zero!!!");
            }
            else if (numero > 0)  // Verifica se o n�mero � positivo
            {
                lbn2.Text = ("O N�mero � Positivo");
            }
            else  // Se o n�mero for negativo
            {
                lbn2.Text = ("O N�mero � Negativo");
            }
        }
    }
}
