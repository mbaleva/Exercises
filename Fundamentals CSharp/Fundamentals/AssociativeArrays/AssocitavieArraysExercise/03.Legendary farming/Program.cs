using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Legendary_farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryElement = new Dictionary<string, int>();
            legendaryElement.Add("shards", 0);
            legendaryElement.Add("motes", 0);
            legendaryElement.Add("fragments", 0);
            Dictionary<string, int> junkElements = new Dictionary<string, int>();

            

            bool isTimeForBreak = false;

            while (true)
            {
                string[] arr = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();

                for (int i = 0; i < arr.Length; i+=2)
                {
                    int quantity = int.Parse(arr[i]);
                    string item = arr[i + 1].ToLower();


                    if (item=="shards"||item=="motes"||item=="fragments")
                    {
                        legendaryElement[item] += quantity;

                        if (legendaryElement[item]>=250)
                        {
                            legendaryElement[item] -= 250;


                            if (item=="shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (item == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (item=="fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            isTimeForBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkElements.ContainsKey(item))
                        {
                            junkElements.Add(item, quantity);
                        }
                        else
                        {
                            junkElements[item] += quantity;
                        }
                    }
                }
                if (isTimeForBreak == true)
                {
                    break;
                }
            }
            Dictionary<string, int> filteredKeyMaterials = legendaryElement
                                                          .OrderByDescending(a => a.Value)
                                                          .ThenBy(a => a.Key)
                                                          .ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in filteredKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkElements.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
