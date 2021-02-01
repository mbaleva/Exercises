using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> concatList = new List<int>();
            int lengthConcatList = Math.Min(firstListNumbers.Count, secondListNumbers.Count) * 2;
            int firstRemainderNum = 0;
            int secondRemainderNum = 0;


            for (int i = 0; i < firstListNumbers.Count; i++)
            {
                for (int k = secondListNumbers.Count - 1; k >= 0; k--)
                {
                    concatList.Add(firstListNumbers[i]);
                    concatList.Add(secondListNumbers[k]);
                    i = i + 1;

                    if (concatList.Count == lengthConcatList)
                    {
                        break;
                    }
                }
                if (concatList.Count == lengthConcatList)
                {
                    break;
                }
            }

            if (firstListNumbers.Count > secondListNumbers.Count)
            {
                firstRemainderNum = firstListNumbers[firstListNumbers.Count - 1];
                secondRemainderNum = firstListNumbers[firstListNumbers.Count - 2];
            }

            else if (secondListNumbers.Count > firstListNumbers.Count)
            {
                firstRemainderNum = secondListNumbers[0];
                secondRemainderNum = secondListNumbers[1];
            }

            int minNum = Math.Min(firstRemainderNum, secondRemainderNum);
            int maxNum = Math.Max(firstRemainderNum, secondRemainderNum);

            var listResult = concatList.Where(x => x > minNum && x < maxNum).ToList();
            var OrderedList = listResult.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", OrderedList));
        }
    }
}
