# Exercicios_CSharp

## Soma de Vetores em C# (Console App)

Este projeto em C# permite que o usuário insira valores em dois vetores (`vetorA` e `vetorB`) e exibe a soma elemento a elemento.

###  Funcionalidade

- Solicita ao usuário que insira 5 valores para o **vetor A**.
- Solicita ao usuário que insira 5 valores para o **vetor B**.
- Calcula a soma dos elementos nas mesmas posições dos dois vetores.
- Exibe o resultado da soma para cada par de elementos.

## Exercicio 2
Mostrando matrizes, criando e mostrando para o usuário.

##  Matrizes com Padrões em C# (8x8)

Este projeto demonstra a construção de diferentes padrões em **matrizes 8x8** usando C#. Cada matriz é preenchida de uma forma diferente, simulando "quartéis" com estruturas específicas.

### Estrutura do Projeto

- São criadas **6 matrizes 8x8** (tipo `int[,]`), cada uma preenchida com o número `1` em posições específicas para representar diferentes padrões.
- A função `showHeadquarters` imprime cada matriz formatada no console.

###  Matrizes Geradas

1. **Primeira matriz**: Preenche a **primeira coluna** com `1`.
2. **Segunda matriz**: Preenche a **primeira linha** com `1`.
3. **Terceira matriz**: Preenche a **diagonal principal** com `1`.
4. **Quarta matriz**: Desenha um **contorno (bordas)** com `1` (superior, inferior, esquerda e direita).
5. **Quinta matriz**: Preenche a **primeira linha**, **primeira coluna**, e **diagonal principal** com `1`.
6. **Sexta matriz**: Preenche a **diagonal principal** e a **diagonal secundária** com `1`.

## Fila de Pedidos em Restaurante (Pilha Fila Classe com LinkedList)
Este projeto simula uma **fila de pedidos** em um restaurante, utilizando a estrutura `LinkedList<T>` da linguagem C#.

###  Funcionalidades

- Adiciona pedidos à fila em ordem de chegada.
- Mostra todos os pedidos da fila.
- Remove um pedido específico pelo nome.
- Adiciona um pedido prioritário no início da fila.
- Limpa completamente a fila.

## Cardápio de Produtos em C# (Estruturas)

Este projeto em C# demonstra o uso de **estruturas** para representar e exibir informações sobre **produtos** em uma loja. Cada produto possui atributos como nome, preço, descrição, categoria e criador.

### Estrutura do Produto

Cada produto é representado pela estrutura `Product`, que contém as seguintes propriedades:
- `name`: nome do produto.
- `price`: preço do produto.
- `description`: descrição do produto.
- `category`: categoria do produto (ex: Infoproduto, Produto Físico).
- `creator`: nome do criador ou fabricante do produto.

### Funcionalidade

O programa armazena uma lista de 5 produtos no cardápio e imprime as informações de cada um deles no console.

## Manipulação de Arrays em C#

Este projeto em C# demonstra a criação e manipulação de diferentes arrays de dados, incluindo frutas, números, nomes, jogos e hobbies. O programa preenche cinco arrays e imprime os valores armazenados em cada um, exibindo-os no console.

###  Funcionalidade

O programa faz o seguinte:

1. Cria e preenche cinco arrays:
   - **listFruits**: Um array com 5 frutas.
   - **listNumbers**: Um array com 5 números inteiros.
   - **listNames**: Um array com 5 nomes de pessoas.
   - **listGames**: Um array com 5 nomes de jogos.
   - **listHoobies**: Um array com 5 hobbies.