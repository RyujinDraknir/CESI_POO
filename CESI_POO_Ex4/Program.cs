using CESI_POO_Ex4.Model;
using System;

namespace CESI_POO_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Name", 10);
            book.Authors.Add(new Author("Cédric", "super@gmail.com"));
            book.Authors.Add(new Author("Michel", "michel@gmail.com"));

            Console.WriteLine(book);
        }
    }
}
