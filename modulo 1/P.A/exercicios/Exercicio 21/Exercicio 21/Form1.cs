// Namespace necessário para utilizar a interface gráfica Windows Forms
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Definindo a classe Form1 que herda da classe Form do Windows Forms
namespace Exercicio_21
{
    public partial class form1 : Form
    {
        // Construtor da classe form1
        // É chamado quando o formulário é inicializado.
        public form1()
        {
            InitializeComponent(); // Inicializa os componentes da interface (botões, caixas de texto, etc).
        }

        // Evento chamado quando o formulário é carregado (não está sendo usado neste momento)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Aqui não há ações programadas para a inicialização do formulário
        }

        // Evento que ocorre quando o botão "Limpar" é clicado
        // Limpa os campos de texto e o rótulo de média
        private void btnlimp_Click(object sender, EventArgs e)
        {
            txb1.Text = ""; // Limpa o primeiro campo de texto
            txb2.Text = ""; // Limpa o segundo campo de texto
            txb3.Text = ""; // Limpa o terceiro campo de texto
            lbmedia.Text = ""; // Limpa o rótulo onde a média é exibida
        }

        // Evento chamado quando o botão "Calcular" é clicado
        private void btncalc_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis necessárias
            float n1, n2, n3, media;

            // Lendo os valores dos campos de texto e convertendo para float
            n1 = float.Parse(txb1.Text); // Lê o valor do primeiro campo
            n2 = float.Parse(txb2.Text); // Lê o valor do segundo campo
            n3 = float.Parse(txb3.Text); // Lê o valor do terceiro campo

            // Calculando a média
            media = (n1 + n2 + n3) / 3;

            // Exibindo o resultado da média no rótulo, arredondado para 2 casas decimais
            lbmedia.Text = $"media={Math.Round(media, 2)}";

            // Tornando o rótulo de média visível
            lbmedia.Visible = true;
        }

        // Este método está associado a um evento de clique em uma label, mas não está sendo utilizado
        private void label4_Click(object sender, EventArgs e)
        {
            // Não há nenhuma ação aqui
        }

        // Evento que é acionado toda vez que o texto no campo txb1 muda
        // Também não está sendo utilizado neste momento
        private void txb1_TextChanged(object sender, EventArgs e)
        {
            // Não há ações programadas aqui
        }
    }
}
