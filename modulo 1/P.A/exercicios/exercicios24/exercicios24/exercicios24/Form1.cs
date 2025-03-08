namespace exercicios24
{
    public partial class Form1 : Form
    {
        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário (como botões, rótulos, etc.)
        }

        // Evento chamado quando o texto da caixa de texto (textBox1) é alterado
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este evento está vazio, mas pode ser utilizado para realizar ações quando o texto da caixa de texto for alterado.
        }

        // Evento chamado quando o botão "Limpar" (btnlimp) é clicado
        private void btnlimp_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo das caixas de texto (txb1, txb2) e o rótulo (lbn3)
            txb1.Text = ""; // Limpa a caixa de texto do ano de nascimento
            txb2.Text = ""; // Limpa a caixa de texto do ano atual
            lbn3.Text = ""; // Limpa o rótulo que mostra a idade calculada
        }

        // Evento chamado quando o botão "Calcular" (btncalc) é clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declara variáveis para o ano de nascimento, ano atual e idade
            int anodenascimento, anoatual, idade;

            // Converte o texto das caixas de texto para inteiros
            anodenascimento = Convert.ToInt32(txb1.Text); // Ano de nascimento fornecido pelo usuário
            anoatual = Convert.ToInt32(txb2.Text); // Ano atual fornecido pelo usuário

            // Calcula a idade subtraindo o ano de nascimento do ano atual
            idade = anoatual - anodenascimento;

            // Exibe o resultado no rótulo lbn3
            lbn3.Text = idade.ToString(); // Converte a idade para string e exibe
            lbn3.Visible = true; // Torna o rótulo visível (em caso de não estar visível)
        }

        // Evento chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento está vazio, mas pode ser utilizado para inicializações quando o formulário for carregado.
        }

        // Evento chamado quando o rótulo lbn1 é clicado
        private void lbn1_Click(object sender, EventArgs e)
        {
            // Este evento está vazio, mas pode ser utilizado se houver alguma ação desejada ao clicar no rótulo lbn1.
        }
    }
}
