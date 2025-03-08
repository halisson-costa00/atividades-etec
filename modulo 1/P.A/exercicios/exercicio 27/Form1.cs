namespace Ex27
{
    // Definindo a classe principal Form1, que herda de Form, usado no Windows Forms
    public partial class Form1 : Form
    {
        // Construtor da classe Form1, chamado quando o formulário é inicializado
        public Form1()
        {
            InitializeComponent(); // Inicializa todos os componentes do formulário
        }

        // Função que verifica se a string é um número (inteiro ou decimal)
        public bool StringNumerica(string str, string tipoDeDado, bool assinado)
        {
            // Verifica se a string é negativa (não permitido se "assinado" for falso)
            if (!assinado)
            {
                if (str[0] == '-') // Se começar com '-', retorna falso
                    return false;
            }

            // Verifica se a string é vazia ou contém apenas um separador de vírgula ou hífen
            if (str == "" || str == "," || str == "-")
                return false;

            // Se o tipo de dado for decimal, verifica se a string pode ser convertida para decimal
            if (tipoDeDado == "decimal")
            {
                int virgulas = 0; // Contador de vírgulas
                int i = 0;
                foreach (char c in str) // Itera sobre cada caractere da string
                {
                    if (c.Equals(',') || (c.Equals('-') && i == 0)) // Se for vírgula ou o primeiro caractere for '-'
                    {
                        if (c.Equals(','))
                        {
                            virgulas++; // Incrementa contador de vírgulas
                            if (virgulas > 1) // Não permite mais de uma vírgula
                                return false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(c) == false) // Se o caractere não for número, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Retorna verdadeiro se for válido
            }

            // Se o tipo de dado for inteiro, verifica se a string pode ser convertida para inteiro
            if (tipoDeDado == "int")
            {
                int i = 0;
                foreach (char c in str) // Itera sobre os caracteres da string
                {
                    if (!(c.Equals('-') && i == 0)) // Se não for o primeiro caractere '-' (para números negativos)
                    {
                        if (char.IsDigit(c) == false) // Se o caractere não for número, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Retorna verdadeiro se for válido
            }
            return false; // Retorna falso se o tipo de dado não for suportado
        }

        // Evento que limpa todos os campos de texto e rótulos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            labResult.Visible = false; // Torna invisível o rótulo de resultado
            foreach (Control txb in this.Controls) // Itera sobre todos os controles no formulário
            {
                if (txb.GetType() == typeof(TextBox)) // Verifica se o controle é do tipo TextBox
                    txb.Text = ""; // Limpa o conteúdo do TextBox
            }

            foreach (Control lab in this.Controls) // Itera sobre todos os controles novamente
            {
                if (lab.GetType() == typeof(Label)) // Verifica se o controle é do tipo Label
                    lab.ForeColor = SystemColors.ControlText; // Restaura a cor padrão do texto
            }
        }

        // Evento que é acionado ao clicar no botão de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Restaura a cor dos rótulos para o valor padrão (preto)
            foreach (Control lab in this.Controls)
            {
                if (lab.GetType() == typeof(Label))
                    lab.ForeColor = SystemColors.ControlText;
            }

            // Obtém todos os TextBox presentes no formulário
            var textboxes = this.Controls.OfType<TextBox>();
            bool tudoCerto = true; // Variável que verifica se todos os dados estão corretos

            // Verifica se cada TextBox contém um valor numérico válido
            foreach (TextBox txb in textboxes)
            {
                if (!StringNumerica(txb.Text, "int", true)) // Chama a função StringNumerica para validar o valor
                {
                    string i = "";
                    foreach (char c in txb.Name) // Itera sobre o nome do TextBox
                    {
                        if (char.IsDigit(c)) // Se o caractere for um número (indicando o número do TextBox)
                            i += c;
                    }
                    // Encontra o Label correspondente ao número do TextBox e altera sua cor para vermelho
                    var labsComErro = this.Controls.Find("labNum" + i, true);
                    foreach (Label l in labsComErro)
                        l.ForeColor = Color.Red; // Marca o Label como erro (cor vermelha)

                    tudoCerto = false; // Define como falso, indicando que houve um erro
                }
            }

            // Se todos os dados estiverem corretos
            if (tudoCerto)
            {
                int[] nums = new int[20]; // Cria um array para armazenar os números
                int menor, maior; // Variáveis para armazenar o menor e maior número

                int i = 0;
                foreach (Control txb in this.Controls) // Itera sobre todos os controles
                {
                    if (txb.GetType() == typeof(TextBox)) // Se for um TextBox
                    {
                        nums[i] = (Convert.ToInt32(txb.Text)); // Converte o valor para inteiro e armazena no array
                        i++;
                    }
                }

                menor = nums[0]; // Inicializa menor como o primeiro número
                maior = nums[0]; // Inicializa maior como o primeiro número

                foreach (int num in nums) // Itera sobre todos os números no array
                {
                    if (num > maior) // Verifica se o número atual é maior que o maior registrado
                        maior = num;
                    if (num < menor) // Verifica se o número atual é menor que o menor registrado
                        menor = num;
                }

                // Exibe o maior e menor número no rótulo labResult
                labResult.Text = $"Maior: {maior}   Menor: {menor}";
                labResult.Visible = true; // Torna o rótulo visível
            }
        }
    }
}
