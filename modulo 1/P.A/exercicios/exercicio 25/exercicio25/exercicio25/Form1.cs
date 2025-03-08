namespace exercicio25
{
    public partial class Form1 : Form
    {
        // Construtor do Formulário, responsável por inicializar os componentes
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário (botões, caixas de texto, rótulos, etc.)
        }

        // Evento que é chamado quando o label1 é clicado (não está sendo utilizado no código atual)
        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento não faz nada neste momento. Ele pode ser usado para ações específicas quando o usuário clica no label1.
        }

        // Evento que é chamado quando o botão "Limpar" (btnlimp) é clicado
        private void btnlimp_Click(object sender, EventArgs e)
        {
            // Limpa a caixa de texto (txb1) e o rótulo (lbn2) que exibe o resultado
            txb1.Text = ""; // Limpa a caixa de texto
            lbn2.Text = ""; // Limpa o rótulo de resultado
        }

        // Evento que é chamado quando o botão "Calcular" (btncalc) é clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declaração de variável para armazenar o número inserido
            int numero;

            // Converte o valor inserido na caixa de texto (txb1) para um número inteiro
            numero = Convert.ToInt32(txb1.Text);

            // Verifica o valor do número e exibe o resultado no rótulo (lbn2)
            if (numero == 0)  // Verifica se o número é zero
            {
                lbn2.Text = ("O Número Digitado é zero!!!");
            }
            else if (numero > 0)  // Verifica se o número é positivo
            {
                lbn2.Text = ("O Número é Positivo");
            }
            else  // Se o número for negativo
            {
                lbn2.Text = ("O Número é Negativo");
            }
        }
    }
}
