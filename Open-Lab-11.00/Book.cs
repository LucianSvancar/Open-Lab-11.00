using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using Open_Lab_11._00;


namespace Open_Lab_10._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {

                if (value <= 0)
                {
                    pages = 1;
                }

                else
                {
                    pages = value;
                }
            }
        }
        public string Category
        {

            set { category = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value < 1450 || value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
      
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            category = "-1";
            author = "-1";
            releaseDate = -1;
            this.title = title;
            this.pages = pages;
        }
        public Book(string title, int pages, string author, string category, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.author = author;
            this.category = category;
            this.releaseDate = releaseDate;
            
        }

        public override string ToString()
        {
            return String.Format($"{this.title}, number of pages: {this.pages}, category: {this.category}, written by: {this.author}, released in: {this.releaseDate}");
        }

        /// <summary>
        /// Tento zoznam obsahuje kategórie pre knihy(Len pre autora)
        /// </summary>

        public static List<string> categoryList = new List<string>()
        {"For kids", "Romantic", "Science fiction", "Adventurous", "Academically" };
    }
}
