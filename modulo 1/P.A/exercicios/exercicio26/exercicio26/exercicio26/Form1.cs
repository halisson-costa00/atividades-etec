namespace exercicio26
{
    public partial class Form1 : Form
    {
        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário, como botões e rótulos.
        }

        // Evento chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento está vazio, mas pode ser utilizado para inicializações adicionais quando o formulário for carregado.
        }

        // Evento chamado quando o botão "Limpar" (bnlimp) é clicado
        private void bnlimp_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo da caixa de texto (txb1) e o rótulo (lbresult)
            txb1.Text = ""; // Limpa a caixa de texto onde o número será inserido
            lbresult.Text = ""; // Limpa o rótulo onde o resultado ou mensagens de erro são exibidos
        }

        // Evento chamado quando o botão "Calcular" (btncalc) é clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declara uma variável 'resultado' do tipo long (para suportar números maiores) e inicializa com 1.
            long resultado = 1;

            // Verifica se a caixa de texto está vazia ou se o valor inserido é maior que 25
            if (string.IsNullOrEmpty(txb1.Text) || int.Parse(txb1.Text) > 25)
            {
                // Se o campo estiver vazio ou o número for maior que 25, exibe a mensagem de erro.
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
                // Se o número for válido, inicia o cálculo do fatorial. O loop começa em 2 e vai até o valor inserido.
                for (int contagem = 2; contagem <= int.Parse(txb1.Text); contagem++)
                {
                    // Multiplica o valor atual de 'resultado' pela variável de controle 'contagem'
                    resultado *= contagem;
                }

                // Converte o resultado para string e exibe o valor calculado no rótulo lbresult
                lbresult.Text = resultado.ToString(); // Exibe o fatorial calculado no rótulo lbresult
            }
        }
    }
}
