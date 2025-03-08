using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_27
{
    // Definindo a classe do formulário FIBONACCI que herda de Form (a classe base para formulários do Windows)
    public partial class FIBONACCI : Form
    {
        // Variáveis para controlar o número inserido, o maior e o menor número
        int i = 1;           // Índice para contar quantos números foram inseridos (começa em 1)
        double numero = 0;   // Variável para armazenar o número inserido pelo usuário
        double Ma, Me;       // Variáveis para armazenar o maior (Ma) e o menor (Me) número

        // Construtor da classe FIBONACCI (formulário)
        public FIBONACCI()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        // Evento chamado quando o botão "Limpar" (btnLIMP) é clicado
        private void btnLIMP_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo dos campos de entrada e dos rótulos
            txb1.Text = " ";        // Limpa a caixa de texto onde o número é inserido
            lblMa.Text = " ";       // Limpa o rótulo do maior número
            lblMe.Text = " ";       // Limpa o rótulo do menor número
            lblErro.Text = " ";     // Limpa o rótulo de erro
            lblI.Text = " ";        // Limpa o rótulo que exibe o índice (quantos números foram inseridos)
            i = 1;                  // Reseta o índice de contagem para 1 (indica que ainda não foi inserido nenhum número)
        }

        // Evento que seria chamado se algum rótulo fosse clicado, mas não está sendo utilizado
        private void lbl_Click(object sender, EventArgs e)
        {
        }

        // Evento chamado quando o botão "Adicionar" (btnADC) é clicado
        private void btnADC_Click(object sender, EventArgs e)
        {
            try
            {
                // Tenta converter o valor inserido no TextBox (txb1) para um número do tipo double
                numero = Convert.ToDouble(txb1.Text);

                // Se for o primeiro número (i == 1), inicializa as variáveis Ma e Me
                if (i == 1)
                {
                    Ma = numero;    // O primeiro número inserido é considerado tanto o maior quanto o menor
                    Me = numero;    // Inicializa o menor número com o primeiro valor inserido

                    // Verifica se o número inserido é maior ou menor que Ma e Me e atualiza-os se necessário
                    if (numero > Ma)
                    {
                        Ma = numero; // Atualiza o maior número, se o número inserido for maior
                    }
                    if (numero < Me)
                    {
                        Me = numero; // Atualiza o menor número, se o número inserido for menor
                    }

                    i++;    // Incrementa o índice (agora i será 2, indicando que o primeiro número foi inserido)
                    lblI.Text = Convert.ToString(i); // Atualiza o rótulo lblI com o valor do índice (quantos números foram inseridos)
                }

                // Se o índice for menor ou igual a 20, permite inserir mais números
                if (i <= 20)
                {
                    // Verifica se o número inserido é maior que o maior número e atualiza Ma, se necessário
                    if (numero > Ma)
                    {
                        Ma = numero; // Atualiza o maior número, se necessário
                    }

                    // Verifica se o número inserido é menor que o menor número e atualiza Me, se necessário
                    if (numero < Me)
                    {
                        Me = numero; // Atualiza o menor número, se necessário
                    }

                    i++;    // Incrementa o índice (quantidade de números inseridos)
                    lblI.Text = Convert.ToString(i); // Atualiza o rótulo lblI para mostrar o índice atual
                }
                else if (i == 21)
                {
                    // Quando o índice atingir 21 (20 números inseridos), exibe o maior e menor número encontrados
                    lblMa.Text = Convert.ToString(Ma);  // Exibe o maior número no rótulo lblMa
                    lblMe.Text = Convert.ToString(Me);  // Exibe o menor número no rótulo lblMe
                    i++;    // Incrementa o índice (o valor de i se torna 22, e nenhuma nova entrada é permitida)
                }
                else
                {
                    // Se o índice for maior que 21, não permite inserir mais números e solicita que o formulário seja limpo
                    lblErro.Text = "Limpe primeiro";  // Exibe uma mensagem de erro no rótulo lblErro informando que é necessário limpar os campos
                }
            }
            catch
            {
                // Se ocorrer um erro ao tentar converter o valor para double, exibe uma mensagem de erro
                lblErro.Text = "Valor inválido";  // Informa que o valor inserido não é válido
            }
        }
    }
}
