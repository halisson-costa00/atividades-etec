namespace exercicio_22
{
    // Defini��o da classe Form1, que herda de Form (a classe base de formul�rios no Windows Forms)
    public partial class Form1 : Form
    {
        // Construtor do Formul�rio, respons�vel por inicializar os componentes
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formul�rio (bot�es, caixas de texto, r�tulos, etc.)
        }

        // Evento que � chamado quando o formul�rio � carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento n�o faz nada neste momento. Ele pode ser usado para inicializar o formul�rio ou carregar dados.
        }

        // Evento que � chamado quando o bot�o "Limpar" (button1) � clicado
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada (quantidade, pre�o) e o r�tulo de resultado
            txbquant.Text = ""; // Limpa a caixa de texto para a quantidade
            txbpreco.Text = "";  // Limpa a caixa de texto para o pre�o
            lbresult.Text = "";  // Limpa o r�tulo que exibe o resultado
        }

        // Evento que � chamado sempre que o texto na caixa de texto 'txbquant' � alterado
        private void txbquant_TextChanged(object sender, EventArgs e)
        {
            // Este evento n�o faz nada neste momento. Ele pode ser usado para a��es din�micas enquanto o usu�rio digita, como valida��o de dados.
        }

        // Evento que � chamado quando o bot�o "Calcular" (btncalcular) � clicado
        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Declara��o de vari�veis
            double quantidade;    // Vari�vel para armazenar a quantidade
            double preco, resultado;  // Vari�veis para armazenar o pre�o e o resultado final do c�lculo

            // Converte os valores inseridos nas caixas de texto para o tipo de dado adequado
            quantidade = Convert.ToDouble(txbquant.Text); // Converte a quantidade inserida para double
            preco = float.Parse(txbpreco.Text);           // Converte o pre�o inserido para float

            // Realiza o c�lculo (quantidade * pre�o)
            resultado = quantidade * preco;

            // Exibe o resultado no r�tulo, arredondando para 2 casas decimais
            lbresult.Text = $"{Math.Round(resultado, 2)}";

            // Torna o r�tulo de resultado vis�vel
            lbresult.Visible = true;
        }

        // Evento que � chamado sempre que o texto da caixa de texto 'txbpreco' � alterado
        private void txbpreco_TextChanged(object sender, EventArgs e)
        {
            // Este evento n�o faz nada neste momento. Ele pode ser utilizado para valida��es enquanto o usu�rio digita o pre�o.
        }
    }
}
