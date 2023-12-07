using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly.Model
{
    internal class Playlist : Stamp
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set;}
        public TimeSpan Time { get { return GetLength(); } set { Time = value; } }

        private TimeSpan GetLength()
        {
            int length = 0;
            foreach (Song song in Songs) { length += song.Length; }
            return TimeSpan.FromSeconds(length);
        }

        public Playlist(string title, List<Song> songs) 
        {
            Title = title;
            Songs = songs;
        }

        public override string ToString()
        {
            string s = $"Title: {Title}\nLength: {Time}\nSongs: {Songs}\n";
            foreach (Song song in Songs) {  s += song.Title + "\n"; }
            return s;
        }
    }
}
