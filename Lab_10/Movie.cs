using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
     public class Movie

    {
        private string catIndex;
        private string title;
        private string category;

        #region Properties
        public string CatIndex
        {
            get
            {
                return catIndex;
            }
            set
            {
                catIndex = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }



        #endregion

        #region constructors
        public Movie(string titl, string cat)
        {
            Title = titl;               //! Start with global var (=Property)!
            Category = cat;
        }
        public Movie(string cat)
        {
            Category = cat;
        }
        #endregion

        public List<string> SearchByCategory(string cat, List<Movie> MovieList)
        {
            List<string> SearchList = new List<string>();
            for (int i = 0; i < MovieList.Count; i++)
            {
                if (MovieList.ElementAt(i).Category == cat)         //another way to index a list
                {
                    SearchList.Add(MovieList[i].Title);
                }
                // else AddCategory(Category, Title, MovieList);
            }
            return SearchList;

        }
        public List<Movie> AddCategory(string cat, List<Movie> MovieList)
        {
            for(int i = 0; i < MovieList.Count; i++)
            {
                if (MovieList.ElementAt(i).Category != cat)
                    Console.WriteLine("No title found for that category.  Would you like to add one? (y/n)   ");
                if(Console.ReadLine() == "y" )
                Console.Write("Please supply a title for the new category:   ");
                 string title = Console.ReadLine();
                MovieList.Add(new Movie(Title, cat));
             }
            return MovieList;
        }
        //private void IndexCategory(List<Movie> MovieList)
        //{
        //    MovieList.ElementAt.Category. ;
        //    foreach (Movie category in MovieList)
        //    {
               
                    

                
        //    }
        }
        
    }
        
    }
