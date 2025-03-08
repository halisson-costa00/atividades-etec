using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex29
{
    // A classe Form1 herda de Form, que é a classe base para formulários do Windows Forms.
    public partial class Form1 : Form
    {
        // Construtor da classe Form1. Este é chamado quando o formulário é inicializado.
        public Form1()
        {
            InitializeComponent(); // Método gerado automaticamente para inicializar os componentes do formulário.
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
            // Limpa a caixa de texto (txbNum) e esconde os rótulos
            txbNum.Text = "";
            labMes.Visible = false;  // Esconde o rótulo que mostra o mês
            labNumInv.Visible = false;  // Esconde o rótulo de erro
        }

        // Evento chamado quando o botão "Calcular" (btnCalcular) é clicado
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            labNumInv.Visible = false;  // Inicialmente, esconde a mensagem de erro (se houver)

            // Verifica se o valor digitado é um número válido (decimal) e não negativo
            if (!StringNumerica(txbNum.Text, "decimal", false))
                labNumInv.Visible = true;  // Se não for válido, exibe a mensagem de erro
            else
            {
                // Converte o número inserido para inteiro
                int num = Convert.ToInt32(txbNum.Text);

                // Verifica se o número está no intervalo de 1 a 12 (correspondendo aos meses do ano)
                if (num <= 0 || num > 12)
                {
                    labNumInv.Visible = true;  // Se não estiver entre 1 e 12, exibe a mensagem de erro
                }
                else
                {
                    // Declara a variável mes que armazenará o nome do mês correspondente
                    string mes;

                    // Utiliza uma expressão condicional ternária para definir o nome do mês baseado no número inserido
                    mes = num == 1 ? "Janeiro" :
                    num == 2 ? "Fevereiro" :
                    num == 3 ? "Março" :
                    num == 4 ? "Abril" :
                    num == 5 ? "Maio" :
                    num == 6 ? "Junho" :
                    num == 7 ? "Julho" :
                    num == 8 ? "Agosto" :
                    num == 9 ? "Setembro" :
                    num == 10 ? "Outubro" :
                    num == 11 ? "Novembro" : "Dezembro";

                    // Exibe o mês correspondente no rótulo labMes
                    labMes.Text = $"Mês correspondente = {mes}";
                    labMes.Visible = true;  // Torna o rótulo visível
                }
            }
        }

        // Evento gerado automaticamente quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
