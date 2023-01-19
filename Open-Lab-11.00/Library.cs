using Open_Lab_10._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Lab_11._00;

namespace Open_Lab_11._00
{
    internal class Library
    {
        int numberOfBooks;
        int numberOfStudents;
        List<string> studentsList = new List<string>();
        List<Book> booksList = new List<Book>();

        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        
        }

        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public List<string> StudentsList
        {
            get { return studentsList; }
        }

        public List<Book> BooksList
        {
            get { return booksList; }
        }

        public override string ToString()
        {
            string students = "";
            string books = "";

            foreach (var item in StudentsList)
            {
                students = students + item + " ";
            }

            foreach (var item in BooksList)
            {
                books = books + item + "\n";
            }

            return String.Format($"Total books: {numberOfBooks} \n ({books}), Total students: {numberOfStudents} ({students})");
        }

    }
}