# Projeto: Estrutura de Dados - Árvore Binária em C#

Este projeto é uma implementação de uma árvore binária em C#, com operações básicas como adição, remoção e exibição ordenada dos elementos. O código foi desenvolvido para fins educacionais, na disciplina de Estrutura de Dados.

## Funcionalidades
- **Adicionar Elemento:** Insere um novo nodo na árvore de acordo com a ordem alfabética.
- **Remover Elemento:** Remove um nodo da árvore, reorganizando-a para manter a propriedade binária.
- **Exibir em Ordem Crescente:** Percorre e exibe os elementos da árvore em ordem crescente.
- **Exibir em Ordem Decrescente:** Percorre e exibe os elementos da árvore em ordem decrescente.

## Estrutura das Classes
- **Arvore.cs**: Classe principal que gerencia as operações da árvore.
- **Nodo.cs** *(presumido)*: Estrutura de dados representando cada nodo da árvore, contendo:
  - `Valor`: Valor armazenado no nodo.
  - `Menor`: Referência para o nodo filho à esquerda.
  - `Maior`: Referência para o nodo filho à direita.

## Lógica de Implementação
- **Adicionando Elementos:** Utiliza comparação de strings para determinar a posição correta na árvore.
- **Remoção:**
  - Caso o nodo tenha dois filhos, substitui pelo menor valor da subárvore direita.
  - Se tiver apenas um filho, substitui diretamente.
  - Se for um nodo folha, simplesmente remove.
- **Exibição:** Utiliza o algoritmo de percurso in-order para crescente e reverse in-order para decrescente.

## Exemplo de Uso
```csharp
Arvore arvore = new Arvore();
arvore.Adicionar("Banana");
arvore.Adicionar("Maçã");
arvore.Adicionar("Abacaxi");

Console.WriteLine("Ordem Crescente:");
arvore.MostrarCrescente();

Console.WriteLine("Ordem Decrescente:");
arvore.MostrarDecrescente();

arvore.Remover("Maçã");
Console.WriteLine("Após Remoção:");
arvore.MostrarCrescente();
```
