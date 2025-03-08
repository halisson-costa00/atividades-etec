void main(List<String> arguments) {
  // Inicializa a lista 'numeros' com alguns valores inteiros
  List<int> numeros = [10, -2, 32, 44, 12, 64, 64, 22, 897, 12125];
  
  // Inicializa 'maior' e 'menor' com o primeiro valor da lista (numeros[0])
  int maior = numeros[0];  // Maior valor começa com o primeiro número da lista
  int menor = numeros[0];  // Menor valor começa com o primeiro número da lista
  
  // Lista para armazenar os números que são menores ou iguais ao maior encontrado
  List<int> ateomaior = []; 

  // Loop que percorre toda a lista 'numeros' para encontrar o maior e menor número
  // e também preencher a lista 'ateomaior' com os números que são menores ou iguais ao maior
  for (int a = 0; a < numeros.length; a++) {
    // Verifica se o número atual é menor que o valor armazenado em 'menor'
    if (menor > numeros[a]) {
      menor = numeros[a];  // Atualiza o menor número
    }

    // Verifica se o número atual é maior que o valor armazenado em 'maior'
    if (maior < numeros[a]) {
      maior = numeros[a];  // Atualiza o maior número
    }

    // Se o número atual for menor ou igual ao maior número encontrado até agora,
    // adiciona ele à lista 'ateomaior'
    if (numeros[a] <= maior) {
      ateomaior.add(numeros[a]);  // Adiciona à lista
    }
  }

  // Imprime o maior e menor número encontrados
  print("Maior: $maior");
  print("Menor: $menor");
  
  // Imprime a lista com todos os números menores ou iguais ao maior número
  print("Lista até o maior número: $ateomaior");
}
