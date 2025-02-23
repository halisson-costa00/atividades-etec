// Função para inserir dados no display da calculadora
function insertToDisplay(data) {
    // Seleciona o elemento de entrada (display) e adiciona o valor 'data' ao final
    document.querySelector('#display').value += data;
}

// Função para limpar o display
function clean() {
    // Define o valor do display como uma string vazia, limpando a entrada
    document.querySelector('#display').value = "";
}

// Função para apagar o último caractere do display
function back() {
    const display = document.querySelector('#display'); // Seleciona o display
    // Remove o último caractere do valor atual do display
    display.value = display.value.slice(0, -1);
}

// Função para calcular o resultado da expressão no display
function result() {
    const display = document.querySelector('#display'); // Seleciona o display
    try {
        // Avalia a expressão no display 
        display.value = eval(display.value);
    } catch {
        // Se ocorrer um erro (por exemplo, entrada inválida), exibe 'error'
        display.value = 'error';
    }
}
