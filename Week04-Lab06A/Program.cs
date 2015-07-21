/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Lab06A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            Library.LoadSongs("songs4.txt");
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine("\n\n{0} songs", genre);
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine("\n\nSongs by {0}", artist);
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine("\n\nSongs more than {0}mins", length);
            Library.DisplaySongs(length);
            Console.ReadLine();
        }
    }
}
