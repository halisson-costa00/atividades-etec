using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex30
{
    // A classe Form1 herda de Form, que é a classe base para formulários do Windows Forms.
    public partial class Form1 : Form
    {
        // Construtor da classe Form1. Este é chamado quando o formulário é inicializado.
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes do formulário (gerado automaticamente).
        }

        // Método que verifica se uma string é numérica (para diferentes tipos de dados: decimal ou inteiro) e se pode ser negativa
        public bool StringNumerica(string str, string tipoDeDado, bool assinado)
        {
            // Verifica se a string está vazia ou contém apenas uma vírgula ou hífen, o que não seria um número válido
            if (str == "" || str == "," || str == "-")
                return false;

            // Se o número não for assinado (não permitir valores negativos), verifica se o primeiro caractere não é um '-'
            if (!assinado)
            {
                if (str[0] == '-') // Caso o primeiro caractere seja '-' e o número não for assinado, retorna falso
                    return false;
            }

            // Se o tipo de dado for decimal
            if (tipoDeDado == "decimal")
            {
                int virgulas = 0; // Contador para verificar se há mais de uma vírgula
                int i = 0;
                // Percorre todos os caracteres da string para verificar se são válidos
                foreach (char c in str)
                {
                    // Permite uma vírgula, mas não mais de uma
                    if (c.Equals(',') || (c.Equals('-') && i == 0))
                    {
                        if (c.Equals(','))
                        {
                            virgulas++; // Incrementa o contador de vírgulas
                            if (virgulas > 1) // Se houver mais de uma vírgula, retorna falso
                                return false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(c) == false) // Se o caractere não for um número, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Se passou por todas as verificações, a string é um número válido
            }

            // Se o tipo de dado for inteiro
            if (tipoDeDado == "int")
            {
                int i = 0;
                foreach (char c in str)
                {
                    // Permite um único sinal de '-' no início do número (para números negativos)
                    if (!(c.Equals('-') && i == 0))
                    {
                        if (char.IsDigit(c) == false) // Se o caractere não for um número, retorna falso
                            return false;
                    }
                    i++;
                }
                return true; // Se a string passou pelas verificações, é um número inteiro válido
            }
            return false; // Se o tipo de dado não for nem decimal nem inteiro, retorna falso
        }

        // Evento chamado quando o botão "Limpar" (btnLimpar) é clicado
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa a caixa de texto de idade (txbIdade) e esconde os rótulos
            txbIdade.Text = string.Empty;
            labCategoria.Visible = false;  // Esconde o rótulo que mostra a categoria
            labNumInv.Visible = false;  // Esconde o rótulo de erro
        }

        // Evento chamado quando o botão "Calcular" (btnCalcular) é clicado
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            labNumInv.Visible = false;  // Inicialmente, esconde a mensagem de erro (se houver)

            // Verifica se o valor digitado é um número válido inteiro
            if (StringNumerica(txbIdade.Text, "int", false))
            {
                int idade = Convert.ToInt32(txbIdade.Text); // Converte o valor para um inteiro

                // Verifica se a idade está fora do intervalo esperado (5 a 25 anos)
                if (idade < 5 || idade > 25)
                    labNumInv.Visible = true;  // Se a idade não for válida, exibe a mensagem de erro
                else
                {
                    // Categoriza a idade de acordo com os critérios estabelecidos
                    if (idade >= 5 && idade <= 10)
                        labCategoria.Text = "Categoria: Infantil";
                    else
                    {
                        if (idade <= 15)
                            labCategoria.Text = "Categoria: Juvenil";
                        else
                        {
                            if (idade <= 20)
                                labCategoria.Text = "Categoria: Júnior";
                            else
                                labCategoria.Text = "Categoria: Profissional";
                        }
                    }
                    labCategoria.Visible = true;  // Torna o rótulo de categoria visível
                }
            }
            else
                labNumInv.Visible = true;  // Se o valor não for numérico, exibe a mensagem de erro
        }

        // Evento gerado automaticamente quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
