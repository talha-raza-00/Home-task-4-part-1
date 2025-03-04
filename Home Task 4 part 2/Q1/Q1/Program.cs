using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {

        // this is a class for book.
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.ISBN = "001203";
            book1.name = "Talhaaaa";
            book1.title = "oop";
            book1.price = 100;

            book1.display();
            book1.discount();

            Console.WriteLine();
            book book2 = new book();
            book2.title = "Maths";
            book2.name = "xyz";
            book2.price = 2000;
            book2.ISBN = "0908";
            
            book2.display();
            book2.discount();

        }
    }
}
