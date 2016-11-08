using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            string proceed = "";
            Console.WriteLine("Welcome to MovieList!\n");
            do
            {   
            Console.WriteLine("There are 10 movies in this list. \nWhat category are you interested in?    ");
            string category = Console.ReadLine();
            string title = "";
            Movie movie = new Movie(title, category);
            List<Movie> MovieList = new List<Movie>();
            MovieList = PopulateMovieList(MovieList); 
           
            List<string> SearchList = new List<string>();
            SearchList = movie.SearchByCategory(category, MovieList);
            Console.WriteLine("Movies in category " + category + ":\n");
            for (int i = 0; i < SearchList.Count; i++)
            {
                Console.WriteLine(SearchList.ElementAt(i));
            }
            Console.Write("\nFind more movies? (y/n)  ");
            proceed = Proceed(Console.ReadLine());
            } while (proceed == "yes");
        }
        private static List<Movie> PopulateMovieList(List<Movie> MovieList)
        {
            MovieList.Add(new Movie("Blade Runner", "scifi"));
            MovieList.Add(new Movie("Brazil", "scifi"));
            MovieList.Add(new Movie("Ghost in the Shell", "animated"));
            MovieList.Add(new Movie("The Shawshank Redemption", "drama"));
            MovieList.Add(new Movie("The Shining", "horror"));
            MovieList.Add(new Movie("Metropolis", "scifi"));
            MovieList.Add(new Movie("American Beauty", "drama"));
            MovieList.Add(new Movie("The Man Who Fell To Earth", "scifi"));
            MovieList.Add(new Movie("Shrek", "animated"));
            MovieList.Add(new Movie("Leon, the Professional", "drama"));
            return MovieList;
        }

        private static string Proceed(string v)
        {
            string proceed = (v.ToLower().Trim());
            if (proceed == "y" || proceed == "yes" || proceed == "sure" || proceed == "ok")
            {
                proceed = "yes";
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("\nGoodbye!\n");
            }
            return proceed;
        }
    }
}
