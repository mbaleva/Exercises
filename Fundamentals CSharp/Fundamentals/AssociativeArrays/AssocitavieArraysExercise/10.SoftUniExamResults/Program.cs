using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="exam finished")
            {
                string[] arr = input.Split('-').ToArray();

                string user = arr[0];

                if (arr.Length>2)
                {
                    //Pesho-Java-84
                    string language = arr[1];
                    int points = int.Parse(arr[2]);

                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user]<points)
                        {
                            students[user] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    students.Remove(user);
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
