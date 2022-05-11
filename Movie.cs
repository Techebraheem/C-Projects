using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie (string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //property
        public string Rating
        {
            //allows us get access to a rating attribute on the movie class to the program class
            get { return rating; }

            //allows us modify the rating on the program class 
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
              }
            } 
        }
    }
    class Programs
    {

        static void Main (string[] args)
        {
            //getters and setters

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            // our movie ratings should only accept these ratings G, PG, PG-13, R, NR
            Console.WriteLine(movie1.Rating);
        }
    }
}
