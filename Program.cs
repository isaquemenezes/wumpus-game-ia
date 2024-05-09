using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Jogo do Wumpus!");
        Console.WriteLine("Escolha o tamanho da matriz:");
        Console.WriteLine("Opção 1. 4 por 4");
        Console.WriteLine("Opção 2. 5 por 4");
        Console.WriteLine("Opção 3. 6 por 6");

      

        int opcao;
        do
        {
            Console.Write("Opção: ");
        } while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3);

        int linhas, colunas;

        switch (opcao)
        {
            case 1:
                linhas = 4;
                colunas = 4;
                break;
            case 2:
                linhas = 5;
                colunas = 4;
                break;
            case 3:
                linhas = 6;
                colunas = 6;
                break;
            default:
                linhas = 4;
                colunas = 4;
                break;
        }
        // Criando a matriz escolhida
        int[,] matriz = new int[linhas, colunas];

        // Definindo as percepções (pocos e brisas)
        DefinirPercepcoes(matriz, 3, 2);

        // Exibindo a matriz com as percepções
        ImprimirMatrizComPercepcoes(matriz);

        /* / Exibindo a matriz para verificar se está correta
        Console.WriteLine($"Matriz criada: {linhas} linhas x {colunas} colunas");

        for (int i = 0; i < linhas; i++)
        {
            
            for (int j = 0; j < colunas; j++)
            {
                
                Console.Write("|");

                Console.Write($"___");
            }
            Console.WriteLine("|");
        }
        */




    }

    static void DefinirPercepcoes(int[,] matriz, int numeroPocos, int numeroBrisas)
    {
        Random rand = new Random();
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        // Define poços (representados pelo valor 1)
        for (int i = 0; i < numeroPocos; i++)
        {
            int linha = rand.Next(0, linhas);
            int coluna = rand.Next(0, colunas);
            matriz[linha, coluna] = 1;
        }

        // Define brisas (representadas pelo valor 2)
        for (int i = 0; i < numeroBrisas; i++)
        {
            int linha = rand.Next(0, linhas);
            int coluna = rand.Next(0, colunas);
            if (matriz[linha, coluna] != 1) // Evita colocar brisa onde há poço
            {
                matriz[linha, coluna] = 2;
            }
        }
    }
    static void ImprimirMatrizComPercepcoes(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        Console.WriteLine($"Matriz criada: {linhas} linhas x {colunas} colunas");

        // Imprime a linha de grades superior
        Console.Write("┌");
        for (int i = 0; i < colunas; i++)
        {
            Console.Write("--------");
        }
        Console.WriteLine("┐");

        // Imprime o conteúdo da matriz com percepções
        for (int i = 0; i < linhas; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == 1) // Percepção de poço
                {
                    Console.Write(" Poco ");
                }
                else if (matriz[i, j] == 2) // Percepção de brisa
                {
                    Console.Write(" Brisa");
                }
                else // Célula normal
                {
                    Console.Write("     ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            // Imprime a linha de grades entre as linhas da matriz
            if (i < linhas - 1)
            {
                Console.Write("├");
                for (int k = 0; k < colunas; k++)
                {
                    Console.Write("--------");
                }
                Console.WriteLine("┤");
            }
        }

        // Imprime a linha de grades inferior
        Console.Write("└");
        for (int i = 0; i < colunas; i++)
        {
            Console.Write("--------");
        }
        Console.WriteLine("┘");
    }



}



