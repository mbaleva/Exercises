using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> specialNumWithPower = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int bombNum = specialNumWithPower[0];
            int bombPower = specialNumWithPower[1];


            for (int i = 0; i < sequence.Count; i++)
            {
                int currentNum = sequence[i];
                if (currentNum==bombNum)
                {
                    int index = sequence.IndexOf(currentNum);
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex>sequence.Count-1)
                    {
                        endIndex = sequence.Count - 1;
                    }
                    int count = endIndex - startIndex + 1;
                    sequence.RemoveRange(startIndex, count);
                    i = startIndex - 1;
                }
                
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
