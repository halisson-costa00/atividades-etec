namespace exercicios24
{
    public partial class Form1 : Form
    {
        // Construtor da classe Form1
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formul�rio (como bot�es, r�tulos, etc.)
        }

        // Evento chamado quando o texto da caixa de texto (textBox1) � alterado
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este evento est� vazio, mas pode ser utilizado para realizar a��es quando o texto da caixa de texto for alterado.
        }

        // Evento chamado quando o bot�o "Limpar" (btnlimp) � clicado
        private void btnlimp_Click(object sender, EventArgs e)
        {
            // Limpa o conte�do das caixas de texto (txb1, txb2) e o r�tulo (lbn3)
            txb1.Text = ""; // Limpa a caixa de texto do ano de nascimento
            txb2.Text = ""; // Limpa a caixa de texto do ano atual
            lbn3.Text = ""; // Limpa o r�tulo que mostra a idade calculada
        }

        // Evento chamado quando o bot�o "Calcular" (btncalc) � clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declara vari�veis para o ano de nascimento, ano atual e idade
            int anodenascimento, anoatual, idade;

            // Converte o texto das caixas de texto para inteiros
            anodenascimento = Convert.ToInt32(txb1.Text); // Ano de nascimento fornecido pelo usu�rio
            anoatual = Convert.ToInt32(txb2.Text); // Ano atual fornecido pelo usu�rio

            // Calcula a idade subtraindo o ano de nascimento do ano atual
            idade = anoatual - anodenascimento;

            // Exibe o resultado no r�tulo lbn3
            lbn3.Text = idade.ToString(); // Converte a idade para string e exibe
            lbn3.Visible = true; // Torna o r�tulo vis�vel (em caso de n�o estar vis�vel)
        }

        // Evento chamado quando o formul�rio � carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento est� vazio, mas pode ser utilizado para inicializa��es quando o formul�rio for carregado.
        }

        // Evento chamado quando o r�tulo lbn1 � clicado
        private void lbn1_Click(object sender, EventArgs e)
        {
            // Este evento est� vazio, mas pode ser utilizado se houver alguma a��o desejada ao clicar no r�tulo lbn1.
        }
    }
}
