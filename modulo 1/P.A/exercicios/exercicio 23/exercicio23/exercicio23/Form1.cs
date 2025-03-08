namespace exercicio_22
{
    // Definição da classe Form1, que herda de Form (a classe base de formulários no Windows Forms)
    public partial class Form1 : Form
    {
        // Construtor do Formulário, responsável por inicializar os componentes
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário (botões, caixas de texto, rótulos, etc.)
        }

        // Evento que é chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento não faz nada neste momento. Ele pode ser usado para inicializar o formulário ou carregar dados.
        }

        // Evento que é chamado quando o botão "Limpar" (button1) é clicado
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada (quantidade, preço) e o rótulo de resultado
            txbquant.Text = ""; // Limpa a caixa de texto para a quantidade
            txbpreco.Text = "";  // Limpa a caixa de texto para o preço
            lbresult.Text = "";  // Limpa o rótulo que exibe o resultado
        }

        // Evento que é chamado sempre que o texto na caixa de texto 'txbquant' é alterado
        private void txbquant_TextChanged(object sender, EventArgs e)
        {
            // Este evento não faz nada neste momento. Ele pode ser usado para ações dinâmicas enquanto o usuário digita, como validação de dados.
        }

        // Evento que é chamado quando o botão "Calcular" (btncalcular) é clicado
        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Declaração de variáveis
            double quantidade;    // Variável para armazenar a quantidade
            double preco, resultado;  // Variáveis para armazenar o preço e o resultado final do cálculo

            // Converte os valores inseridos nas caixas de texto para o tipo de dado adequado
            quantidade = Convert.ToDouble(txbquant.Text); // Converte a quantidade inserida para double
            preco = float.Parse(txbpreco.Text);           // Converte o preço inserido para float

            // Realiza o cálculo (quantidade * preço)
            resultado = quantidade * preco;

            // Exibe o resultado no rótulo, arredondando para 2 casas decimais
            lbresult.Text = $"{Math.Round(resultado, 2)}";

            // Torna o rótulo de resultado visível
            lbresult.Visible = true;
        }

        // Evento que é chamado sempre que o texto da caixa de texto 'txbpreco' é alterado
        private void txbpreco_TextChanged(object sender, EventArgs e)
        {
            // Este evento não faz nada neste momento. Ele pode ser utilizado para validações enquanto o usuário digita o preço.
        }
    }
}
