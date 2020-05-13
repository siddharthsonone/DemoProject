using System;
namespace DemoProject.Models
{
    public class Movies
    {
        public string genre;
        public string director;
        public int length;
        public int Id { get; set; }
        public string Name { get; set; }
        private static int _count = 0;

        public Movies(string aTitle, string aGenre, string aArtist, int aLength)
        {

            Name = aTitle;
            genre = aGenre;
            director = aArtist;
            length = aLength;
            _count++;

        }
        public static int getTotalSoundCount()
        {
            return _count;
        }

    }
}
