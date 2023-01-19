using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Open_Lab_11._00;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book Math = new Book("Matematika v kocke", 120, "Jaroslav Eisler", "Academically",2008 ); 
            Book Chemistry = new Book("50 Chemistry Ideas You Really Need to Know",360, "Hayley Birch Hardcover ", "Academically", 2015);
            Book Biology = new Book("Základy biologie a genetiky člověka",244, "Romana Mihalová", "Academically",2021);
            Book Physics = new Book("Fyzika",284,"Ivan Šantavý", "Academically", 2000);
          
            Library schoolLibrary = new Library();
            schoolLibrary.NumberOfStudents = 2;
            schoolLibrary.NumberOfBooks = 4;
            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add(Math);
            schoolLibrary.BooksList.Add(Chemistry);
            schoolLibrary.BooksList.Add(Biology);
            schoolLibrary.BooksList.Add(Physics);


            Console.WriteLine(schoolLibrary.ToString());

        }
    }
}
