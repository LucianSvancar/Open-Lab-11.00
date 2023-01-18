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
            Book Math = new Book();
            Book Chemistry = new Book();
            Book Biology = new Book();
            Book Physics = new Book();
          
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
