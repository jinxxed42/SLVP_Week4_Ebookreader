using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week4_Ebookreader
{
    internal class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Pages { get; set; }

        public Book(string author, string title, DateTime releaseDate, int pages)
        {
            Author = author;
            Title = title;
            ReleaseDate = releaseDate;
            Pages = pages;
        }
 

        public string Read (int numPages)
        {
            string result = "";
            for (int i = 1; i <= numPages; i++)
            {
                result += "Page " + i + ". ";
            }
            return result;
        }

    }
}
