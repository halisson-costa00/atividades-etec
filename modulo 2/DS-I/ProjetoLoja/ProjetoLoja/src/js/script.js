// Declarando as variáveis
// 'const' define uma constante que não pode ser alterada, enquanto 'let' permite alteração
// 'const' para itens que não devem mudar e 'let' para o total que pode ser alterado

const items = document.querySelectorAll(".item");  // Seleciona todos os itens com a classe 'item'
const taxaEntrega = 8;  // Define o valor da taxa de entrega
let total = 0;  // Inicializa o total como 0

// Função que percorre a lista de itens e adiciona um ouvinte de eventos
items.forEach((item) => {
    item.addEventListener('click', () => {
        item.classList.toggle('selected');  // Alterna a classe 'selected' quando o item é clicado
        calcularTotal();  // Atualiza o total após a seleção
    });
});

// FUNÇÃO CALCULAR TOTAL
function calcularTotal() {
    total = 0;  // Reinicia o total para recalcular
    const itemsSelecionados = document.querySelectorAll('.selected');  // Seleciona todos os itens com a classe 'selected'
    
    // Percorre os itens selecionados e soma seus preços
    itemsSelecionados.forEach((item) => {
        total += parseFloat(item.dataset.preco);  // Converte o preço do item para número e soma
    });
    
    // Se houver itens selecionados, adiciona a taxa de entrega ao total
    if (itemsSelecionados.length > 0) {
        total += taxaEntrega;
    }
    
    // Exibe o total calculado no elemento com id 'total'
    document.getElementById('total').textContent = `Total: R$ ${total.toFixed(2)}`;
    return total;  // Retorna o total calculado
}

// FUNÇÃO DO SWEETALERT PARA CRIAR UM ALERTA AO CLICAR NO BOTÃO FINALIZAR PEDIDO
const loadingBtn = document.getElementById('loadingBtn'); // Seleciona o botão pelo id

if (loadingBtn) {  // Verifica se o botão foi encontrado na página
    loadingBtn.addEventListener('click', () => {  // Adiciona um evento de click no botão
        Swal.fire({  // Exibe uma caixa de diálogo (modal) com o título "Carregando..."
            title: 'Carregando...',
            allowOutsideClick: false,  // Impede que o modal feche se o usuário clicar fora dele
            didOpen: () => {  // Função que é executada quando o modal abre
                Swal.showLoading();  // Exibe um indicador de carregamento no modal
                finalizarPedido()  // Chama a função para finalizar o pedido
                    .then((pedido) => {  // Quando a promessa é resolvida com sucesso
                        Swal.close();  // Fecha o modal de carregamento
                        exibirMensagemSucesso(pedido);  // Exibe a mensagem de sucesso
                    })
                    .catch((erro) => {  // Se houver erro ao finalizar o pedido
                        Swal.close();
                        Swal.fire('Erro!', erro, 'error');  // Exibe a mensagem de erro
                    });
            },
        });
    });
}

// FUNÇÃO FINALIZAR PEDIDO
async function finalizarPedido() {
    return new Promise((resolve, reject) => {  // Promessa que resolve ou rejeita com base na validação
        const endereco = document.getElementById('endereco').value;  // Pega o valor do campo de endereço
        const pagamento = document.querySelector('input[name="pagamento"]:checked');  // Pega a forma de pagamento selecionada
        const itemsSelecionados = document.querySelectorAll('.selected');  // Pega os itens selecionados

        // Validação dos dados
        if (itemsSelecionados.length === 0) {  // Verifica se nenhum item foi selecionado
            reject('Selecione pelo menos um item para fazer o pedido!');  // Rejeita a promessa com uma mensagem de erro
            return;
        }
        if (!endereco) {  // Verifica se o campo de endereço está vazio
            reject('Por favor, informe o endereço de entrega!');
            return;
        }
        if (!pagamento) {  // Verifica se nenhuma forma de pagamento foi selecionada
            reject('Selecione uma forma de pagamento!');
            return;
        }
        
        // Criação do objeto pedido com os dados do pedido
        const pedido = {
            items: Array.from(itemsSelecionados).map((item) => item.querySelector('h3').textContent),  // Mapeia os itens selecionados para um array de nomes
            endereco,  // Endereço fornecido
            formaPagamento: pagamento.value,  // Forma de pagamento selecionada
            total: calcularTotal(),  // Total calculado
        };

        // Função que resolve a promessa após 2 segundos (simulando um processo assíncrono)
        setTimeout(() => {
            resolve(pedido);  // Resolve a promessa com o objeto pedido
        }, 2000);
    });
}

// FUNÇÃO QUE EXIBE A MENSAGEM DE SUCESSO DO PEDIDO
function exibirMensagemSucesso(pedido) {
    const { items, endereco, formaPagamento, total } = pedido;  // Desestrutura o objeto pedido
    
    // Cria a mensagem que será exibida no modal de sucesso
    const mensagem = `
        Itens: ${items.join(', ')}<br>
        Endereço: ${endereco}<br>
        Forma de pagamento: ${formaPagamento}<br>
        Total (com taxa de entrega R$ ${taxaEntrega.toFixed(2)}): R$ ${total.toFixed(2)}<br>
    `;
    
    // Exibe a mensagem de sucesso com SweetAlert
    Swal.fire('Pedido realizado com sucesso!', mensagem, 'success').then(() => {
        novoPedido();  // Chama a função para preparar o próximo pedido (não definida aqui)
    });
}
