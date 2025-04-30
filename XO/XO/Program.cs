using System;

class Program
{
    static void Main()
    {
        char[,] board = new char[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }

        char currentPlayer = 'X';
        bool gameWon = false;

        while (!gameWon)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("-----");
            }

            Console.WriteLine($"player turn {currentPlayer}:");
            Console.Write("Row (0-2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("cloumn (0-2): ");
            int col = int.Parse(Console.ReadLine());

            if (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;

                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                        gameWon = true;
                    if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                        gameWon = true;
                }
                if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                    gameWon = true;
                if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                    gameWon = true;

                if (gameWon)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(board[i, j]);
                            if (j < 2) Console.Write("|");
                        }
                        Console.WriteLine();
                        if (i < 2) Console.WriteLine("-----");
                    }

                    Console.WriteLine($"player  {currentPlayer} win!");
                    break;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("this location is not empty.");
            }
        }
    }
}