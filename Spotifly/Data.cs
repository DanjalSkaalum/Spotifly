using Spotifly.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly.Model
{
    internal class Data
    {
        public static List<Song> Songs {  get; set; } = new();
        public static List<Artist> Artists { get; set; } = new();
        public static List<Playlist> Playlists { get; set; } = new();

        public static void AddData()
        {
            Artist a1 = new Artist();
            a1.Name = "Michael Jackson";
            a1.Birthday = new DateTime(1958, 8, 29);
            a1.User = "Henrik";
            a1.Country = "USA";
            Artists.Add(a1);

            Artist a2 = new Artist()
            {
                Name = "Bob Marley",
                Country = "Jamaica",
                Birthday = new DateTime(1945, 2, 6)
            };
            Artists.Add(a2);

            var s1 = new Song()
            {
                Title = "Stay with me",
                Genre = "Pip Roeggae",
                Length = 225,
                ReleaseDate = new DateTime(1984, 12, 1),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };

            var s2 = new Song()
            {
                Title = "Stay with me part 2",
                Genre = "Pip Roeggae",
                Length = 225,
                ReleaseDate = new DateTime(1985, 12, 1),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };

            Songs.AddRange(new List<Song>() { s1, s2});

            Playlist p1 = new("Bedroom", new List<Song>() { s1, s2 });
        
            Playlists.Add(p1);
        }
    }
}
