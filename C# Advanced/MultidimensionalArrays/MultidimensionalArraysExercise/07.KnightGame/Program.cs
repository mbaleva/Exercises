using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];


            for (int i = 0; i < n; i++)
            {
                char[] pesho = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = pesho[j];
                }
            }
            int counter = 0;
            while (true)
            {
                int max = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char ch = matrix[row, col];

                        if (ch == 'K')
                        {
                            int currentKilledKnights = CountAttackedKnight(matrix,row,col);

                            if (currentKilledKnights>max)
                            {
                                max = currentKilledKnights;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }
                if (max==0)
                {
                    break;
                }
                matrix[maxRow, maxCol] = '0';
                counter++;
            }
            Console.WriteLine(counter);
        }
        static int CountAttackedKnight(char[,] matrix, int row, int col)
        {
            int counter = 0;
            int n = matrix.GetLength(0);
            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
            {
                counter++;
            }
            if (row - 2 >= 0 && col + 1 < n && matrix[row - 2, col + 1] == 'K')
            {
                counter++;
            }




            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
            {
                counter++;
            }
            if (row - 1 >= 0 && col + 2 < n && matrix[row - 1, col + 2] == 'K')
            {
                counter++;
            }



            if (row + 1 < n && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
            {
                counter++;
            }
            if (row + 1 < n && col + 2 <n  && matrix[row + 1, col + 2] == 'K')
            {
                counter++;
            }






            if (row + 2 < n && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
            {
                counter++;
            }
            if (row + 2 < n && col + 1 < n && matrix[row + 2, col + 1] == 'K')
            {
                counter++;
            }


            return counter;
        }
    }
}
