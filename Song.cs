using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Song
    {
        //using static class attributes to illustrate
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
                
            artist = aArtist;
                
            duration = aDuration;
            songCount++;
 
        }

    }

    class Programs
    {

        static void Main(string[] args)
        {
            //static attributes( is an attribute that is not unique to the objects but to the class) <<
             Song holiday = new Song("Holiday","Green Day", 200);
             Console.WriteLine(Song.songCount);
             Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

             //songcount applies to the class here
             Console.WriteLine(Song.songCount);
        }
    }
 }
