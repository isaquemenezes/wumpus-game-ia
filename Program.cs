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

        ImprimirMatrizComGrades();

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

        // Exibindo a matriz para verificar se está correta
        Console.WriteLine($"Matriz criada: {linhas} linhas x {colunas} colunas");

        for (int i = 0; i < linhas; i++)
        {

            for (int j = 0; j < colunas; j++)
            {
                Console.Write("|");

                Console.Write($"____");
            }
            Console.WriteLine("|");
        }



    }

    static void ImprimirMatrizComGrades()
    {
        Console.WriteLine("chamou! imprimir");
    }
}



