# Árvore Binária em C# - README

Este é um exemplo de implementação de uma Árvore Binária em C#. A árvore binária é uma estrutura de dados que consiste em nós, onde cada nó tem no máximo dois filhos, denominados esquerdo e direito. Este README irá explicar o processo passo a passo do código.

## Estrutura do Código

O código é dividido em três partes principais: a definição da classe `Node`, a definição da classe `BinaryTree`, e o programa principal.

### Classe Node

A classe `Node` representa um nó na árvore binária. Cada nó contém um valor inteiro e referências para os seus nós filhos esquerdo e direito. Aqui está a estrutura da classe `Node`:

- `value`: Armazena o valor inteiro do nó.
- `left`: Referência para o nó filho esquerdo.
- `right`: Referência para o nó filho direito.

### Classe BinaryTree

A classe `BinaryTree` representa a árvore binária em si e contém métodos para inserir valores na árvore, buscar valores e percorrer a árvore. Aqui está a estrutura da classe `BinaryTree`:

- `root`: Referência para o nó raiz da árvore.

### Programa Principal

O programa principal contém o método `Main`, onde uma instância da classe `BinaryTree` é criada e alguns valores são inseridos na árvore. Em seguida, é feita uma busca por um valor específico na árvore e o tempo de execução é medido.

## Passo a Passo da Execução

1. **Inicialização da Árvore**: Uma instância da classe `BinaryTree` é criada.

2. **Inserção de Valores**: Alguns valores são inseridos na árvore usando o método `Insert`.

3. **Impressão da Árvore**: Os valores da árvore são impressos em ordem usando o método `InOrderTraversal`.

4. **Busca por um Valor**: É realizada uma busca por um valor específico na árvore usando o método `Search`.

5. **Medição do Tempo de Execução**: O tempo de execução da busca é medido usando a classe `Stopwatch`.

6. **Exibição dos Resultados**: O resultado da busca e o tempo de execução são exibidos no console.

## Conclusão

Este é um exemplo simples de uma implementação de uma árvore binária em C#. A árvore binária é uma estrutura de dados poderosa e versátil, amplamente utilizada em muitas aplicações e algoritmos.
