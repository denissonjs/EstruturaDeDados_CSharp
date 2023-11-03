using System;
using System.Collection.Generic;
using System.Windows.Forms;

// As classes a seguir são meramente ilustrativas e tentam trazer uma ideia de uso de estruturas de dados. Nelas não são incluidos tratamentos de erros, persistência de dados, diretivas de interface de usuário etc. Sendo assim, se pretende usá-las em projeto particular, talvez sejam necessárias adaptações.
internal class Estruturas_Lineares
{
    /* Para entender sobre Pilhas, vamos criar uma pilha de menus acessados pelo usuário. A intenção é retornar uma string com os menus que o usuário clicou. Você já deve ter visto algo parecido quando está na pagina de um produto no Mercado Livre*/
    public class Pilhas
    {
        // Declara a pilha que será usada para armazenar os menus clicados.
        private Stack<string> pilhaDeNavegacao = new Stack<string>();

        // O método NavegarPara() irá receber uma string, que será adicionada a nossa pilha de menus acessados.
        public void NavegarPara(string menu)
        {
            // Adiciona o menu fornecido no topo da pilhaDeNavegacao.
            pilhaDeNavegacao.Push(menu);
        }

        // Define o método ExibirCaminhoNavegacao que retorna a string que contém o caminho atual do usuário.
        public string ExibirCaminhoNavegacao()
        {
            // Converte a pilhaDeNavegacao em uma lista para consguirmos inverter a ordem dos elementos. Isso é necessário pois os itens são colocados na lista na ordem em que seriam removidos da pilha. Isso significa que o último menu para o qual o usuário navegou (o último item que foi adicionado à pilha) é o primeiro item na lista.
            List<string> listaDeNavegacao = new List<string>(pilhaDeNavegacao);
            listaDeNavegacao.Reverse();

            // Converte a listaDeNavegacao em uma string, separando cada elemento com " > ".
            string caminhoNavegacao = string.Join(" > ", listaDeNavegacao);

            // Retorna a string caminhoNavegacao, algo como "Menu 01 > Menu 02 > Menu 03...".
            return caminhoNavegacao;
        }

        // O método main vai ser o ponto de partida para salvar o caminho percorrido sempre que chamado.
        public static void Main()
        {
            Pilhas pilhas = new Pilhas();

            // Sempre que o usuário clicar em um menu, chama o método "NavegarPara" para incluir aquele menu na pilha.
            
            // Simula clique em "informárica".
            pilhas.NavegarPara("Informática");
            // Simula clique em "Portáteis e Acessórios".
            pilhas.NavegarPara("Portáteis e Acessórios");
            // Simula clique em "Acessórios para Notebook".
            pilhas.NavegarPara("Acessórios para Notebook");
            // Simula clique em "Maletas e Bolsas".
            pilhas.NavegarPara("Maletas e Bolsas");
            // Simula clique em "Mochilas".
            pilhas.NavegarPara("Mochilas");

            // Obtém o caminho de navegação como uma string.
            string caminhoNavegacao = pilhas.ExibirCaminhoNavegacao();
            // Exibe o caminho de navegação no console, que conforme as chamadas acima seria: "Informática> Portáteis e Acessórios > Acessórios para Notebook > Maletas e Bolsas > Mochilas"
            Console.WriteLine($"Caminho de navegação: {caminhoNavegacao}");
        }
    }

    public class Filas
    {
        // Declara a fila que será usada para armazenar os fornecedores agendados.
        private Queue<string> filaDeFornecedores = new Queue<string>();

        // O método AgendarFornecedor() irá receber uma string (em um sistema real, poderia ser o código do fornecedor), que será adicionada a nossa fila de fornecedores agendados.
        public void AgendarFornecedor(string fornecedor)
        {
            // Adiciona o fornecedor fornecido no final da filaDeFornecedores.
            filaDeFornecedores.Enqueue(fornecedor);
            Console.WriteLine($"Fornecedor {fornecedor} agendado.");
        }

        // O método AtenderFornecedor() irá remover e retornar o próximo fornecedor na fila de agendamento. Em um projeto robusto poderia ser gravado informações de log como comentários sobre a visita, data e hora e outros dados que a empresa declarar relevante.
        public void AtenderFornecedor()
        {
            // Verifica se tem algum fornecedor com atendimento pendente.
            if (filaDeFornecedores.Count > 0)
            {
                string fornecedorAtendido = filaDeFornecedores.Dequeue();
                Console.WriteLine($"Fornecedor {fornecedorAtendido} atendido.");
            }
            else
            {
                Console.WriteLine("Não há fornecedores na fila de agendamento.");
            }
        }

        // O método Main vai ser o ponto de partida para agendar e atender fornecedores.
        public static void Main()
        {
            Filas agendamento = new Filas();

            // As declarações abaixo adicionam três fornecedores da lista.
            agendamento.AgendarFornecedor("Fornecedor 1");
            agendamento.AgendarFornecedor("Fornecedor 2");
            agendamento.AgendarFornecedor("Fornecedor 3");

            // Os métodos abaixo removem um fornecedor a cada chamada. Como foi chamado três vezes, os três adicionados anteriormente serão removidos.
            agendamento.AtenderFornecedor();
            agendamento.AtenderFornecedor();
            agendamento.AtenderFornecedor();
        }

    }
}