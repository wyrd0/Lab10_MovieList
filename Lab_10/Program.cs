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
            Console.WriteLine("Welcome to MovieList!\n");
            Console.WriteLine("There are 10 movies in this list. \nWhat category are you interested in?    ");
            string category = Console.ReadLine();
            string title = "";
            Movie movie = new Movie(title, category);
            List<Movie> MovieList = new List<Movie>();
            
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

            List<string> SearchList = new List<string>();
            SearchList = movie.SearchByCategory(category, MovieList);
            Console.WriteLine("Movies in category " + category + ":\n");
            for (int i = 0; i<SearchList.Count; i++)
            {
                Console.WriteLine(SearchList.ElementAt(i));
            }
            Console.WriteLine("\nFind more movies? (y/n)  ");
            
            //for (int i = 0; i < MovieList.Count; i++)
            //{
               
            //    Console.WriteLine(MovieList[i].Title1 + MovieList[i].Category1);
            //}


           // List<string> result = Movie.SearchByCategory("scifi", MovieList);



        }
    }
}
