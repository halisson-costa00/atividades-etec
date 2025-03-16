// // 1. **Declaração de Variáveis**
// //    **Descrição**: Declare uma variável de cada tipo básico (`int`, `double`, `String`, `bool`) e atribua valores a elas. Exiba esses valores no console.

// void main() {
//   // Declarando variáveis de tipos básicos

//   int numeroInteiro = 10;      // Tipo int: Armazena números inteiros, sem casas decimais
//   double numeroDecimal = 3.14; // Tipo double: Armazena números com casas decimais
//   String texto = "Olá"; // Tipo String: Armazena sequências de caracteres (textos)
//   bool estaAtivo = true;       // Tipo bool: Armazena valores lógicos, verdadeiro (true) ou falso (false)

//   // Exibindo os valores das variáveis no console usando a função print
//   print("Valor do int: $numeroInteiro");    // Exibe o valor da variável numeroInteiro
//   print("Valor do double: $numeroDecimal"); // Exibe o valor da variável numeroDecimal
//   print("Valor do String: $texto");         // Exibe o valor da variável texto
//   print("Valor do bool: $estaAtivo");       // Exibe o valor da variável estaAtivo
// }



// ### 2. **Interpolação de Strings**
//    **Descrição**: Crie uma variável para o nome e outra para a idade. Utilize interpolação para exibir uma mensagem como: "Olá, meu nome é [nome] e eu tenho [idade] anos."
// void main() {
//   // Declarando as variáveis
//   String nome = "bgugyhvg";  // Variável para o nome
//   int idade = 25;        // Variável para a idade

//   // Usando interpolação de strings para exibir a mensagem
//   print("Olá, meu nome é $nome e eu tenho $idade anos.");
// }

// ### 3. **Condicionais Simples**
//    **Descrição**: Crie uma variável `idade` e, com base no valor dela, imprima se a pessoa é maior ou menor de idade. Considere maior de idade a partir de 18 anos.

// void main() {
//   // Declarando a variável idade
//   int idade = 20;  // Você pode modificar esse valor para testar diferentes idades

//   // Condicional para verificar se a pessoa é maior ou menor de idade
//   if (idade >= 18) {
//     // Se a idade for 18 ou maior, a pessoa é maior de idade
//     print("Você é maior de idade.");
//   } else {
//     // Se a idade for menor que 18, a pessoa é menor de idade
//     print("Você é menor de idade.");
//   }
// }


// ### 4. **Condicionais com Else If**
//    **Descrição**: Crie uma variável `nota` e, com base no valor dela, imprima a classificação do aluno (>= 9 A; >=8 B, >=6 C, >= 4 D < 4 F).

// void main() {
//   // Variável que armazena a nota do aluno
//   double nota = 7.5;

//   // Condicional para classificar o aluno
//   if (nota >= 9) {  // Se a nota for maior ou igual a 9
//     print('Classificação: A');  // Imprime "A" para nota excelente
//   } else if (nota >= 8) {  // Se a nota for maior ou igual a 8 (mas menor que 9)
//     print('Classificação: B');  // Imprime "B" para bom desempenho
//   } else if (nota >= 6) {  // Se a nota for maior ou igual a 6 (mas menor que 8)
//     print('Classificação: C');  // Imprime "C" para desempenho médio
//   } else if (nota >= 4) {  // Se a nota for maior ou igual a 4 (mas menor que 6)
//     print('Classificação: D');  // Imprime "D" para desempenho abaixo da média
//   } else {  // Se a nota for menor que 4
//     print('Classificação: F');  // Imprime "F" para reprovado
//   }
// }
