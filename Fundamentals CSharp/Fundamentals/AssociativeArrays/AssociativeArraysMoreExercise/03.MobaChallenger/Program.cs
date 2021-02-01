using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> IAmAngry = new Dictionary<string, Dictionary<string, int>>();

            string player = string.Empty;
            string position = string.Empty;
            int skill = 0;
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "Season")
                {
                    break;
                }

                if (!(input.Contains("vs")))
                {
                    player = input[0];
                    position = input[1];
                    skill = int.Parse(input[2]);

                    if (IAmAngry.ContainsKey(player))
                    {
                        if (IAmAngry[player].ContainsKey(position))
                        {
                            if (IAmAngry[player][position] < skill)
                            {
                                IAmAngry[player][position] = skill;
                            }
                        }
                        else
                        {
                            IAmAngry[player][position] = skill;
                        }
                    }
                    else
                    {
                        Dictionary<string, int> pesho = new Dictionary<string, int>();
                        pesho.Add(position, skill);
                        IAmAngry[player] = pesho;
                    }
                }
                else
                {
                    string playerOne = input[0];
                    string playerTwo = input[2];
                    if (IAmAngry.ContainsKey(playerOne) && IAmAngry.ContainsKey(playerTwo))
                    {
                        string playerToRemove = string.Empty;
                        foreach (var item in IAmAngry[playerOne])
                        {
                            foreach (var gosho in IAmAngry[playerTwo])
                            {
                                if (item.Key == gosho.Key)
                                {
                                    if (IAmAngry[playerOne].Values.Sum() > IAmAngry[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerTwo;
                                    }
                                    else if (IAmAngry[playerOne].Values.Sum() < IAmAngry[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerOne;
                                    }
                                }
                            }
                        }
                        IAmAngry.Remove(playerToRemove);
                    }
                }
            }
            foreach (var tosho in IAmAngry.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{tosho.Key}: {tosho.Value.Values.Sum()} skill");
                foreach (var pair in tosho.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}
