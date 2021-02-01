using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colsAndRows = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = colsAndRows[0];
            int cols = colsAndRows[1];

            char[,] matrix = new char[rows, cols];


            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < rows; row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];

                    if (arr[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            foreach (char direction in directions)
            {
                int currentPlayerRow = playerRow;
                int currentPlayerCol = playerCol;
                switch (direction)
                {
                    case 'U':
                        currentPlayerRow--;
                        break;
                    case 'D':
                        currentPlayerRow++;
                        break;
                    case 'L':
                        currentPlayerCol--;
                        break;
                    case 'R':
                        currentPlayerCol++;
                        break;
                }
                isWon = IsWon(matrix, currentPlayerRow, currentPlayerCol);
                if (IsWon(matrix, currentPlayerRow, currentPlayerCol))
                {
                    matrix[playerRow, playerCol] = '.';
                }
                else
                {

                    if (matrix[currentPlayerRow, currentPlayerCol] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '.';
                        matrix[currentPlayerRow, currentPlayerCol] = 'P';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;

                    }
                }



                List<int> binnues = new List<int>();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i,j]=='B')
                        {
                            binnues.Add(i);
                            binnues.Add(j);
                        }
                    }
                }
                for (int i = 0; i < binnues.Count; i+=2)
                {
                    int bunnieRow = binnues[i];
                    int bunnieCol = binnues[i + 1];

                    Bunnie(matrix, bunnieRow, bunnieCol);
                }
                if (IsWon(matrix, currentPlayerRow, currentPlayerCol)||matrix[playerRow,playerCol]=='B')
                {
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);

                    
                }
                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void Bunnie(char[,] matrix, int bunnieRow, int bunnieCol)
        {
            if (bunnieRow-1>=0)
            {
                matrix[bunnieRow - 1, bunnieCol] = 'B';
            }
            if (bunnieRow + 1 < matrix.GetLength(0))
            {
                matrix[bunnieRow + 1, bunnieCol] = 'B';
            }
            if (bunnieCol - 1 >= 0)
            {
                matrix[bunnieRow, bunnieCol-1] = 'B';
            }
            if (bunnieCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnieRow, bunnieCol+1] = 'B';
            }
        }

        private static bool IsWon(char[,] matrix, int currentPlayerRow, int currentPlayerCol)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            return currentPlayerRow < 0 || currentPlayerRow >= n || currentPlayerCol < 0 || currentPlayerCol >= m;
        }
    }
}
