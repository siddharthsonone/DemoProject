
//to be used later for inheritence 
using System;
namespace DemoProject.Models
{
    public class Media
    {
        //class attributes
        public string title;
        public string genre;
        public string artist;

        private Boolean _isSold;
        private static int _count = 0;
        public Boolean IsSold
        {
            get { return _isSold; }
            set { _isSold = true; }
        }



        //class constructor
        public Media(string aTitle, string aGenre, string aArtist)
        {
            Console.WriteLine("Creating Class!");
            title = aTitle;
            genre = aGenre;
            artist = aArtist;
            _count++;

        }
        public static void getTotalSoundCount()
        {
            Console.WriteLine("Total Count" + _count);
        }

    }
}