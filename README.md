# Estrutura de dados C# na prática

# Sumário
- [Introdução](#introdução)
- [Estruturas Lineares](#estruturas-lineares)
    - [Pilhas](#pilhas)
    - [Filas](#filas)
    - [Arrays e Listas](#arrays-e-listas)
- [Estruturas não Lineares](#estruturas-não-lineares)
    - [Arvores](#arvores)
    - [Grafos](#grafos)
- [Estruturas Chaveadas](#estruturas-chaveadas)
    - [Dicionários]()
    - [Conjuntos (sets)]()

# Introdução
Bem-vindo ao meu repositório sobre estruturas de dados! Aqui, você encontrará exemplos práticos do dia a dia para cada tipo de estrutura de dados, desde as mais simples, como arrays e listas, até as mais complexas, como árvores e grafos. Cada exemplo foi cuidadosamente elaborado para demonstrar como essas estruturas podem ser aplicadas em situações reais. Espero que este repositório seja um recurso valioso para o seu aprendizado e prática em estruturas de dados. Boa jornada!

# Estruturas Lineares
Estruturas de dados lineares são aquelas em que os elementos são organizados de maneira sequencial, ou seja, um elemento vem após o outro. Isso significa que cada elemento na estrutura tem uma posição definida em relação aos outros. Exemplos comuns de estruturas de dados lineares incluem arrays, listas, pilhas e filas. Cada um desses tipos de estruturas tem suas próprias características e usos específicos, mas todos compartilham a propriedade comum de terem seus elementos dispostos de forma linear.

## Pilhas
Pilhas são estruturas de dados que seguem o princípio de "último a entrar, primeiro a sair" (LIFO - Last In, First Out). Uma maneira fácil de visualizar isso é pensar em uma pilha de livros. Você só pode adicionar um novo livro no topo da pilha e, da mesma forma, só pode remover um livro do topo. Cada livro representa um dado e a pilha de livros representa a estrutura de dados.

Em uma aplicação prática, as pilhas podem ser usadas para registrar os menus acessados pelos usuários em um site. Por exemplo, em um e-commerce, o usuário pode navegar por vários menus para chegar a um produto específico. A pilha registraria esse caminho, permitindo ao usuário ver claramente como chegou a esse produto. Isso também ajudaria o usuário a saber em qual seção clicar para encontrar produtos semelhantes.

## Filas
As filas são estruturas de dados que funcionam de maneira semelhante às pilhas, mas com uma diferença fundamental: elas seguem o princípio de "primeiro a entrar, primeiro a sair" (FIFO - First In, First Out). Isso pode ser comparado a uma fila de banco, onde a primeira pessoa que chega é a primeira a ser atendida.

No contexto da programação, as filas são usadas para gerenciar a ordem de requisições. A primeira requisição feita será a primeira a ser respondida. Isso é útil em cenários onde a ordem das operações é importante.

Um projeto de agendamento de visita de fornecedores demonstra bem o uso dessa estrutura. Fornecedores definidos com menor prioridade sçao atendidos em modo de fila de espera, onde o primeiro a agendar é o primeiro a ser atendido.

## Arrays e Listas
Arrays e listas podem ser comparados a caixas de sapato numeradas, também conhecidas como índices, onde você pode armazenar itens. Ambos podem armazenar qualquer tipo de dados, mas em C#, todos os dados devem ser do mesmo tipo.

A principal diferença entre arrays e listas é que os arrays têm um tamanho fixo. Isso significa que você precisa definir quantos elementos ele terá antes de criá-lo. Por outro lado, as listas têm um tamanho dinâmico, permitindo adicionar ou remover elementos conforme necessário.

Os arrays são mais rápidos no acesso aos elementos, pois eles são armazenados em posições consecutivas na memória. Isso permite que o processador saiba exatamente quantos elementos serão processados.

As listas, por sua vez, são mais fáceis de modificar. Você pode usar métodos como `Add` e `Remove` para alterar a lista sem precisar criar uma nova. No caso dos arrays, se você quiser alterar o tamanho ou o tipo de dado, precisará criar um novo array.

# Estruturas Não Lineares
As estruturas de dados não lineares são um tipo distinto de estruturas de dados que não seguem uma sequência linear. Isso significa que, ao contrário das estruturas de dados lineares, onde cada elemento tem exatamente um antecessor e um sucessor, os elementos em uma estrutura de dados não linear podem ter mais de um antecessor ou sucessor.

Essas estruturas são particularmente úteis para representar relações complexas entre os dados. Por exemplo, elas podem ser usadas para representar hierarquias, onde um elemento (como um gerente) pode ter vários subordinados. Além disso, as estruturas de dados não lineares também são usadas para representar redes e grafos, onde os elementos podem estar conectados de várias maneiras diferentes.

## Arvores
As árvores são um tipo de estrutura de dados não linear que representam relações hierárquicas entre os elementos. Elas são chamadas de "árvores" porque a estrutura se assemelha a uma árvore invertida, com um elemento no topo chamado de "raiz" e vários níveis de elementos abaixo dela, chamados de "nós".

Cada nó em uma árvore tem um "pai" (o nó acima dele) e pode ter vários "filhos" (os nós abaixo dele). A raiz é o único nó que não tem pai. Os nós sem filhos são chamados de "folhas".

As árvores são usadas em muitas áreas da ciência da computação, incluindo a organização de hierarquias de arquivos em sistemas operacionais, a análise sintática em compiladores e a implementação de bancos de dados.

Um exemplo comum de uma árvore é a árvore binária, onde cada nó tem no máximo dois filhos. As árvores binárias são usadas em muitos algoritmos eficientes de busca e classificação.

Portanto, as árvores oferecem uma maneira flexível e eficiente de representar e manipular dados hierárquicos.

## Grafos
Os grafos são estruturas de dados que representam relações entre pares de elementos, chamados de "vértices" ou "nós". As relações são representadas por "arestas" ou "arcos". Diferente das árvores, os grafos não possuem uma hierarquia definida, permitindo representar relações complexas e não hierárquicas. São utilizados para representar redes, como a internet, ou relações sociais. Existem vários tipos de grafos, incluindo direcionados, não direcionados, ponderados e não ponderados.

# Estruturas Chaveadas
As estruturas de dados baseadas em chaves são um tipo especial de estrutura que não segue uma ordem sequencial nem possui uma hierarquia definida. O nome “baseadas em chaves” vem do fato de que os elementos dentro dessas estruturas são identificados e acessados por meio de chaves únicas. Cada chave é associada a um valor específico na estrutura de dados, permitindo o acesso rápido e eficiente a esse valor.

## Dicionários
Podemos associar essa estrutura de dados um dicionário de palavras comum, onde encontramos seus significados. Digamos que você quer saber o que significa a palavra "estapafúrdio". Essa palavra é a chave, ou seja, o que você quer encontrar e "algo que não é comum, que estranho" é o significado, ou seja, o valor. Ele é útil quando você precisa associar valores a uma chave específicas. O exemplo da classe "Dictionary" do arquivo `Estruturas_Chaveadas` consegue mostrar bem isso.

## Conjuntos (Sets)
Os conjuntos, também conhecidos como "sets", são uma estrutura de dados que armazena elementos únicos em uma coleção não ordenada. Isso significa que cada elemento só pode aparecer uma vez no conjunto e a ordem dos elementos não é importante.

Os conjuntos são úteis quando você quer manter uma coleção de itens, mas está interessado principalmente na presença ou ausência de um item, em vez de sua ordem ou frequência. Eles também fornecem operações eficientes para calcular a união, interseção e diferença entre conjuntos.

Portanto, os conjuntos oferecem uma maneira eficiente de manipular coleções de elementos únicos e realizar operações de conjunto.