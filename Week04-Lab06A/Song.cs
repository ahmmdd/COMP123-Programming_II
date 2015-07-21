/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Lab06A{
    public class Song{
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public double Length { get; private set; }
        public SongGenre Genre { get; private set; }
        
        public Song(string title, string artist, double length, SongGenre genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Length = length;
            this.Genre = genre;
        }
        public override string ToString(){
            return string.Format("{0}.{1}.{2}.{3}", Title, Artist, Length, Genre);
        }
    }
}
