using System;
using System.Linq;

namespace _10._Lady_bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < ladyBugIndexes.Length; i++)
            {
                int currentIndex = ladyBugIndexes[i];

                if (currentIndex>=0&&currentIndex<field.Length)
                {
                    field[currentIndex] = 1;
                }
            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladyBugStartIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (ladyBugStartIndex < 0 || ladyBugStartIndex > field.Length - 1 || field[ladyBugStartIndex] == 0)
                {
                    continue;
                }
                field[ladyBugStartIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladyBugStartIndex + flyLength;
                    if (landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] ==1)
                        {
                            landIndex += flyLength;
                            if (landIndex>field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex>=0&&landIndex<=field.Length-1)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugStartIndex - flyLength;
                    if (landIndex <0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', field));
        }
    }
}
