using System;
namespace DemoProject.Models
{
    public class Songs
    {
        //class attributes
        public string title;
        public string genre;
        public string artist;
        public int length;
        private Boolean _isSold;
        private static int _count = 0;
        public Boolean IsSold
        {
            get { return _isSold; }
            set { _isSold = true; }
        }



        //class constructor
        public Songs(string aTitle, string aGenre, string aArtist, int aLength)
        {
            Console.WriteLine("Creating Class!");
            title = aTitle;
            genre = aGenre;
            artist = aArtist;
            length = aLength;
            _count++;

        }
        public static void getTotalSoundCount()
        {
            Console.WriteLine("Total Count" + _count);
        }

    }
}
