using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] date = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string type = date[0];
                string name = date[1];
                string time = date[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {   
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    public class Song
    { 
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
    }
}
