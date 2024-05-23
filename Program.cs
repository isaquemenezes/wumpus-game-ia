using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //Define o tamanho da matriz
        Console.WriteLine("Digite o tamanho da matriz que deseja criar:");
        int tamanho = int.Parse(Console.ReadLine());

        //Cria a Matriz
        int[,] matriz = new int[tamanho, tamanho];
        Random rand = new Random(); //Instancia a variável rand para gerar posições aleatórias dentor da matriz    

        //Métodos de Criação
        criaPoco(tamanho, rand, matriz);
        criaWumpus(tamanho, rand, matriz);
        criaGold(tamanho, rand, matriz);

        //Insere o agente na casa [0,0]
        matriz[0, 0] = 7;

        //Teste de nova matriz
        int[,] novaMatriz = new int[tamanho, tamanho];

        //Método de exibição
        exibirGrid(tamanho, matriz);
        // EM DESENVOLVIMENTO exibirGrid(tamanho, percepcaoBrisa(tamanho, matriz, novaMatriz)); // Teste de nova matriz
    }

    static void criaPoco(int tamanho, Random rand, int[,] matriz)
    {
        int numPocos = (int)Math.Round(Math.Pow(tamanho, 2) * 0.1875f); //Definição do número de poços para cada mapa

        for (int i = 0; i < numPocos; i++) //Cria o elemento poço aleatório no grid
        {
            int randomRow = rand.Next(1, tamanho);
            int randomCol = rand.Next(1, tamanho);

            //Verifica se a posição gerada está vazia
            while (matriz[randomRow, randomCol] != 0)
            {
                randomRow = rand.Next(1, tamanho);
                randomCol = rand.Next(1, tamanho);
            }
            matriz[randomRow, randomCol] = 2; //Imprime o elemento poço na posição gerada
        }
    }
    static void criaWumpus(int tamanho, Random rand, int[,] matriz)
    {
        //Cria o Wumpus no mapa
        int wumpusPosRow = rand.Next(1, tamanho);
        int wumpusPosCol = rand.Next(1, tamanho);

        while (matriz[wumpusPosRow, wumpusPosCol] != 0) //Verifica se a posição gerada está vazia
        {
            wumpusPosRow = rand.Next(1, tamanho);
            wumpusPosCol = rand.Next(1, tamanho);
        }
        matriz[wumpusPosRow, wumpusPosCol] = 1; //Imprime o elemento Wumpus na posição gerada
    }
    static void criaGold(int tamanho, Random rand, int[,] matriz)
    {
        //Cria o ouro no mapa
        int goldPosRow = rand.Next(1, tamanho);
        int goldPosCol = rand.Next(1, tamanho);

        while (matriz[goldPosRow, goldPosCol] != 0 && matriz[goldPosRow, goldPosCol] != 1) //Verifica se a posição gerada está vazia
        {
            goldPosRow = rand.Next(1, tamanho);
            goldPosCol = rand.Next(1, tamanho);
        }
        if (matriz[goldPosRow, goldPosCol] == 1)
        {
            matriz[goldPosRow, goldPosCol] = 4; //Imprime os elementos Wumpus e Gold na posição gerada
        }
        else
        {
            matriz[goldPosRow, goldPosCol] = 3; //Imprime o elemento Gold na posição gerada
        }
    }

    /* Percepções - EM DESENVOLVIMENTO 
    static int[,] percepcaoBrisa(int tamanho, int[,] matriz, int[,] novaMatriz)
     {
         for (int i = 0; i < tamanho; i++)
         {
             for (int j = 0; j < tamanho; j++)
             {
                 if (matriz[i, j] == 2)
                 {

                     if (i - 1 >= 0 && i + 1 < tamanho && j - 1 >= 0 && j + 1 < tamanho)
                     {
                         novaMatriz[i, j - 1] = 2;
                         novaMatriz[i, j + 1] = 2;
                         novaMatriz[i - 1, j] = 2;
                         novaMatriz[i + 1, j] = 2;
                     }

                 }
             }
         }
         return novaMatriz;
     } */
    static void exibirGrid(int tamanho, int[,] matriz)
    {
        //Criando o preenchimento a DataTable com os elementos da matriz 
        DataTable dataTable = new DataTable();

        for (int j = 0; j < tamanho; j++)
        {
            dataTable.Columns.Add($"Coluna{j + 1}", typeof(int));
        }

        for (int i = 0; i < tamanho; i++)
        {
            DataRow row = dataTable.NewRow();
            for (int j = 0; j < tamanho; j++)
            {
                row[j] = matriz[i, j];
            }
            dataTable.Rows.Add(row);
        }

        // Exibindo a DataTable como tabela
        Console.WriteLine("\nMapa do 'Mundo de Wumpus':");
        foreach (DataRow dataRow in dataTable.Rows)
        {
            foreach (var item in dataRow.ItemArray)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}