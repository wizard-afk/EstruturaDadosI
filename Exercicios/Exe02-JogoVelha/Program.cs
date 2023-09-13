using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = '1';

    static void Main()
    {
        InitializeBoard();
        bool gameOver = false;

        Console.WriteLine("Bem-vindo ao Jogo da Velha!");

        while (!gameOver)
        {
            PrintBoard();
            Console.WriteLine($"É a vez do jogador {currentPlayer}");
            Console.Write("Informe a linha (0, 1, ou 2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Informe a coluna (0, 1, ou 2): ");
            int col = int.Parse(Console.ReadLine());

            if (IsValidMove(row, col))
            {
                MakeMove(row, col);

                if (CheckForWin())
                {
                    PrintBoard();
                    Console.WriteLine($"O jogador {currentPlayer} ganhou!");
                    gameOver = true;
                }
                else if (IsBoardFull())
                {
                    PrintBoard();
                    Console.WriteLine("O jogo terminou em empate.");
                    gameOver = true;
                }
                else
                {
                    SwitchPlayer();
                }
            }
            else
            {
                Console.WriteLine("Posição inválida. Tente novamente.");
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (i < 2)
            {
                Console.WriteLine("  -+-+-");
            }
        }
    }

    static bool IsValidMove(int row, int col)
    {
        return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ';
    }

    static void MakeMove(int row, int col)
    {
        board[row, col] = currentPlayer;
    }

    static bool CheckForWin()
    {
        // Verificar linhas, colunas e diagonais
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                return true; // Linha
            }

            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
            {
                return true; // Coluna
            }
        }

        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            return true; // Diagonal principal
        }

        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            return true; // Diagonal secundária
        }

        return false;
    }

    static bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == '1') ? '0' : '1';
    }
}