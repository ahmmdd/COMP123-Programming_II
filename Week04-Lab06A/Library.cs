/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week04_Lab06A{
    class Library{
        private static List<Song> songs = new List<Song>();
        public static void DisplaySongs(){
            for (int i = 0; i < songs.Count; i++){
                Console.WriteLine(songs[i]);
            }
        }

        public static void DisplaySongs(double longerThan){
            for (int i = 0; i < songs.Count; i++){
                if (songs[i].Length > longerThan){
                    Console.WriteLine(songs[i]);
                }
            }
        }
        public static void DisplaySongs(SongGenre genre){
            for (int i = 0; i < songs.Count; i++){
                if (songs[i].Genre == genre){
                    Console.WriteLine(songs[i]);
                }
            }
        }
        public static void DisplaySongs(string artist) {
            for (int i = 0; i < songs.Count; i++){
                if (songs[i].Artist == artist){
                    Console.WriteLine(songs[i]);
                }
            }
        }

        public static void LoadSongs(string fileName) {
            TextReader reader = new StreamReader("songs4.txt");
            songs = new List<Song>();
            string title = reader.ReadLine();
            while (title != null){
                string artist = reader.ReadLine();
                double length = Convert.ToDouble(reader.ReadLine());
                SongGenre genre = (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine());
                Song s = new Song(title, artist, length, genre);
                songs.Add(s);
                title = reader.ReadLine();
            }
            reader.Close();
        }

    }
}
