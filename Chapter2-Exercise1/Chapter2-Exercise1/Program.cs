using System;
using System.Collections.Generic;

namespace Chapter2_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new List<Song>();
            var song1 = new Song("First song", "Yusuke", 358);
            songs.Add(song1);
            var song2 = new Song("Second Sons", "yskeno", 866);
            songs.Add(song2);
            var song3 = new Song("3rdPlace", "YE", 241);
            songs.Add(song3);

            foreach (var item in songs)
            {
                Console.WriteLine("Title: {0}\nArtist: {1}\nLength: {2}:{3:00}\n", item.Title, item.ArtistName, item.Length / 60, item.Length % 60);
            }
            Console.WriteLine("-EOF-");
        }
    }
}
