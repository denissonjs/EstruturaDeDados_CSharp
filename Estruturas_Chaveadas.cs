//
using System;
using System.Collection.Generic;
internal class Estruturas_Chaveadas
{
     class Dictionary
    {
        /*  Como mensionei no readme, dicionários funcionam com chave e valor.
        Um uso particularmente comum de dicionários é no relacionamento de colunas
        banco de dados com colunas de um DataGridView, que nada mais são que a
        representação visual de uma tabela em aplicações Windows form. */

        /* Apesar de os dados serem fictícios, esse exemplo de aplicação 
            foi usado algumas vezes no projeto "Rotina9817_AnaliseDeCredito" 
            disponível também no meu GitHub. */

        public static void Main()
        {
            // Criamos um DataGridView e adicionamos as colunas.
            DataGridView dgv = new DataGridView();

            dgv.Columns.Add("dgvColumn_ID", "ID");
            dgv.Columns.Add("dgvColumn_NOME", "Nome");
            dgv.Columns.Add("dgvColumn_EMAIL", "Email");

            // Criamos um array de strings com dados aleatórios e adicionamos à linha do DataGridView. 
            string[] row = new string[] { "123", "John Doe", "johndoe@teste.com.br" };
            dgv.Rows.Add(row);

            // Agora crio meu dicionário declarando as chaves com os mesmos nomes das colunas do DataGridView e valor com os nomes das colunas no banco de dados.
            Dictionary<string, string> usuario = new Dictionary<string, string>()
            {
                { "dgvColumn_ID", "ID" },
                { "dgvColumn_NOME", "NOME" },
                { "dgvColumn_EMAIL", "EMAIL" },
            };

            string query = RelacionamentoColunas(dgv, usuario);
            // Por causa da lógica da função "RelacionamentoColunas" discriminada abaixo, a string "query" receberá a clausula insert "INSERT INTO TABELA_QUALQUER (ID, NOME, EMAIL) VALUES ("123", "John Doe", "johndoe@teste.com.br") 
            // Com essa string você pode chamar a função de execução no banco de dados usando essa string.
        }

        public static string RelacionamentoColunas(DataGridView dgv, Dictionary<string, string> usuario)
        {
            string query = "";

            // Vamos criar uma string que irá armazena a query de inserção de dados em uma tabela. Mas qual valor incluir? Aí entra meu looping no dictionary "usuarios".
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string columnNames = "";
                string values = "";

                foreach (KeyValuePair<string, string> entry in usuario)
                {
                    // Aqui estou pegando o nome da chave atual do dicionário. Vamos imaginar que está na vez de "dgvColumn_NOME" no loop. 
                    string dgvColumnName = entry.Key;

                    // Sendo a vez de "dgvColumn_NOME", logo o nome da coluna no banco de dados é "NOME".
                    string dbColumnName = entry.Value;

                    // Para que os dados sejam separados corretamente, formato nossa string adicionando " , ".
                    columnNames += dbColumnName + ", ";

                    // Aqui pego o valor definitivo de "dgvColumn_NOME" no dataGridView.
                    values += "'" + dgv.Rows[i].Cells[dgvColumnName].Value.ToString() + "', ";

                    /* Dessa forma "columnNames" receberá "NOME" e "values" receberá o valor de
                        "dgvColumn_NOME" do DataGridView, que nesse caso será "john doe". */
                }

                // Pra não gerar o erro "comando não encerrado adequandamente" no banco de dados, retiro a virgula no final das strings.
                columnNames = columnNames.TrimEnd(',', ' ');
                values = values.TrimEnd(',', ' ');

                // Por fim, adiciono a sequencia de nome de colunas que o loop guardou junto a seus valores. Garantindo que cada coluna receba o valor devido.
                query += "INSERT INTO TABELA_QUALQUER (" + columnNames + ") VALUES (" + values + ")";
            }
            return query;
     }
 }

class Conjuntos
{
    /* A função abaixo permite bloquear vários clientes de uma vez. 
       Para evitar múltiplas tentativas de modificação do mesmo cliente, 
       o que poderia gerar uma demanda desnecessária no banco de dados, 
       usamos um conjunto (HashSet) de clientes. */

    public static string BloquearClientes(int[] idsClientes)
    {
        // Cria um conjunto de elementos únicos com a classe "HashSet<T>", que não aceita dados repetidos.
        HashSet<int> conjuntoClientes = new HashSet<int>(idsClientes);

        // Converte o conjunto de IDs de clientes em uma string formatada.
        string idsClientesString = string.Join(",", conjuntoClientes);

        // Por fim, com as duplicatas removidas e a string formatada, unimos à cláusula "update".
        string query = $"UPDATE TABELA_CLIENTES SET BLOQUEIO = 'S' WHERE IDCLIENTE IN ({idsClientesString})";

        return query;
    }

    /* Chamar a função BloquearClientes(new int[] {123, 123, 123, 321, 321,321}) irá retornar:
       UPDATE TABELA_CLIENTES SET BLOQUEIO = 'S' WHERE IDCLIENTE IN (123, 321). */  
}

}