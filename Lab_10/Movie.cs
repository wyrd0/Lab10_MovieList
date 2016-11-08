using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
     public class Movie

    {         

        private string title;
        private string category;

        #region Properties
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
             }
            return SearchList;
        }
        
    }
        
    }
