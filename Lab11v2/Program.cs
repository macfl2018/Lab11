using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11v2
{
    public class Movie
    {
        public Movie(string genre, string title, string runtime, string rating)
        {
            Genre = genre;
            Title = title;
            Runtime = runtime;
            Rating = rating;
        }
        private string Genre { get; set; }
        private string Title { get; set; }
        public string Runtime { get; set; }
        public string Rating { get; set; }

        public  string GetPrivateMovieTitle()
        {
            return Title; 
        }

        public string GetPrivateMovieGenre()
        {
            return Genre;
        }

    }
    public class DefaultmovieList
    {

        public static List<Movie> create()
        {
            var result = new List<Movie>();

            result.Add(new Movie("animated", "BIG HERO 6", "Runtime1", "Rating1"));
            result.Add(new Movie("animated", "LION KING", "Runtime2", "Rating2"));
            result.Add(new Movie("animated", "CARS", "Runtime3", "Rating3"));
            result.Add(new Movie("horror", "THE RING", "Runtime4", "Rating4"));
            result.Add(new Movie("horror", "IT", "Runtime5", "Rating5"));
            result.Add(new Movie("horror", "SAW", "Runtime6", "Rating6"));
            result.Add(new Movie("scifi", "STAR TREK", "Runtime7", "Rating7"));
            result.Add(new Movie("scifi", "STAR WARS", "Runtime8", "Rating8"));
            result.Add(new Movie("drama", "TITANIC", "Runtime9", "Rating9"));
            result.Add(new Movie("drama", "CAST AWAY", "Runtime10", "Rating10"));
            result.Add(new Movie("drama", "REMEMBER THE TITANS", "Runtime11", "Rating11"));

            return result;
        }
    }

    class Program
    {

        public static string getProperGenre()
        {

            string responseLow = "";
            bool properGenre = false;


            Console.WriteLine("Hello Welcome to the Movie Lookup Program");
            do
            {
            Console.WriteLine("Please enter a genre of movies you would like to learn more about?");
            Console.WriteLine("Choose from animated,drama, Horror, or Scifi. Please enter your response below");
            var response = Console.ReadLine();

                /// Confirm that string entered is one of four categories
                responseLow = response.ToLower(); 

                if (responseLow =="animated" || responseLow =="drama" || responseLow == "horror" || responseLow == "scifi")
                {
                    properGenre = true;
                }

            } while (properGenre ==false);

            return responseLow;
        }

        static void Main(string[] args)
        {
            string repeatlower = "";
            string repeat = "";


            do
            {
            string genreResponse = "";
            genreResponse = getProperGenre();
           
            var movies = DefaultmovieList.create();

            Console.WriteLine("The genre you selected is " + genreResponse);
            Console.WriteLine("The movies you can select within that genre are listed blow...please press enter");
            Console.ReadLine();

            foreach( var movie in movies)            
            {

                if (movie.GetPrivateMovieGenre() == genreResponse)
                {
                    Console.WriteLine(movie.GetPrivateMovieTitle()+ " " + movie.Rating + " " + movie.Runtime);
                }
              
            }
                    Console.ReadLine();
                    Console.WriteLine("Would you like to look at another genre? (Y/N)");
                    repeat = Console.ReadLine();
                    repeatlower = repeat.ToLower();

            } while (repeatlower == "y");

        }


    }
}
