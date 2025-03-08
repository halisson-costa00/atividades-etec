import 'dart:io';

void main(List<String> arguments) {
  int valor = 5; // Número para o qual calcularemos o fatorial
  int resul = 1; // Inicializa o resultado com 1

  // Loop para calcular o fatorial
  for (int i = valor; i >= 1; i--) {
    resul *= i; // Multiplica o resultado pelo valor de i em cada iteração
  }

  // Imprime o resultado final do fatorial
  print('O fatorial de $valor é $resul');
}
