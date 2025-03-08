namespace Ex27
{
    // Definindo a classe principal Form1, que herda de Form, usado no Windows Forms
    public partial class Form1 : Form
    {
        // Construtor da classe Form1, chamado quando o formul�rio � inicializado
        public Form1()
        {
            InitializeComponent(); // Inicializa todos os componentes do formul�rio
        }

        // Fun��o que verifica se a string � um n�mero (inteiro ou decimal)
        public bool StringNumerica(string str, string tipoDeDado, bool assinado)
        {
            // Verifica se a string � negativa (n�o permitido se "assinado" for falso)
            if (!assinado)
            {
                if (str[0] == '-') // Se come�ar com '-', retorna falso
                    return false;
            }

            // Verifica se a string � vazia ou cont�m apenas um separador de v�rgula ou h�fen
            if (str == "" || str == "," || str == "-")
                return false;

            // Se o tipo de dado for decimal, verifica se a string pode ser convertida para decimal
            if (tipoDeDado == "decimal")
            {
                int virgulas = 0; // Contador de v�rgulas
                int i = 0;
                foreach (char c in str) // Itera sobre cada caractere da string
                {
                    if (c.Equals(',') || (c.Equals('-') && i == 0)) // Se for v�rgula ou o primeiro caractere for '-'
                    {
                        if (c.Equals(','))
                        {
                            virgulas++; // Incrementa contador de v�rgulas
                            if (virgulas > 1) // N�o permite mais de uma v�rgula
                                return false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(c) == false) // Se o caractere n�o for n�mero, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Retorna verdadeiro se for v�lido
            }

            // Se o tipo de dado for inteiro, verifica se a string pode ser convertida para inteiro
            if (tipoDeDado == "int")
            {
                int i = 0;
                foreach (char c in str) // Itera sobre os caracteres da string
                {
                    if (!(c.Equals('-') && i == 0)) // Se n�o for o primeiro caractere '-' (para n�meros negativos)
                    {
                        if (char.IsDigit(c) == false) // Se o caractere n�o for n�mero, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Retorna verdadeiro se for v�lido
            }
            return false; // Retorna falso se o tipo de dado n�o for suportado
        }

        // Evento que limpa todos os campos de texto e r�tulos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            labResult.Visible = false; // Torna invis�vel o r�tulo de resultado
            foreach (Control txb in this.Controls) // Itera sobre todos os controles no formul�rio
            {
                if (txb.GetType() == typeof(TextBox)) // Verifica se o controle � do tipo TextBox
                    txb.Text = ""; // Limpa o conte�do do TextBox
            }

            foreach (Control lab in this.Controls) // Itera sobre todos os controles novamente
            {
                if (lab.GetType() == typeof(Label)) // Verifica se o controle � do tipo Label
                    lab.ForeColor = SystemColors.ControlText; // Restaura a cor padr�o do texto
            }
        }

        // Evento que � acionado ao clicar no bot�o de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Restaura a cor dos r�tulos para o valor padr�o (preto)
            foreach (Control lab in this.Controls)
            {
                if (lab.GetType() == typeof(Label))
                    lab.ForeColor = SystemColors.ControlText;
            }

            // Obt�m todos os TextBox presentes no formul�rio
            var textboxes = this.Controls.OfType<TextBox>();
            bool tudoCerto = true; // Vari�vel que verifica se todos os dados est�o corretos

            // Verifica se cada TextBox cont�m um valor num�rico v�lido
            foreach (TextBox txb in textboxes)
            {
                if (!StringNumerica(txb.Text, "int", true)) // Chama a fun��o StringNumerica para validar o valor
                {
                    string i = "";
                    foreach (char c in txb.Name) // Itera sobre o nome do TextBox
                    {
                        if (char.IsDigit(c)) // Se o caractere for um n�mero (indicando o n�mero do TextBox)
                            i += c;
                    }
                    // Encontra o Label correspondente ao n�mero do TextBox e altera sua cor para vermelho
                    var labsComErro = this.Controls.Find("labNum" + i, true);
                    foreach (Label l in labsComErro)
                        l.ForeColor = Color.Red; // Marca o Label como erro (cor vermelha)

                    tudoCerto = false; // Define como falso, indicando que houve um erro
                }
            }

            // Se todos os dados estiverem corretos
            if (tudoCerto)
            {
                int[] nums = new int[20]; // Cria um array para armazenar os n�meros
                int menor, maior; // Vari�veis para armazenar o menor e maior n�mero

                int i = 0;
                foreach (Control txb in this.Controls) // Itera sobre todos os controles
                {
                    if (txb.GetType() == typeof(TextBox)) // Se for um TextBox
                    {
                        nums[i] = (Convert.ToInt32(txb.Text)); // Converte o valor para inteiro e armazena no array
                        i++;
                    }
                }

                menor = nums[0]; // Inicializa menor como o primeiro n�mero
                maior = nums[0]; // Inicializa maior como o primeiro n�mero

                foreach (int num in nums) // Itera sobre todos os n�meros no array
                {
                    if (num > maior) // Verifica se o n�mero atual � maior que o maior registrado
                        maior = num;
                    if (num < menor) // Verifica se o n�mero atual � menor que o menor registrado
                        menor = num;
                }

                // Exibe o maior e menor n�mero no r�tulo labResult
                labResult.Text = $"Maior: {maior}   Menor: {menor}";
                labResult.Visible = true; // Torna o r�tulo vis�vel
            }
        }
    }
}
