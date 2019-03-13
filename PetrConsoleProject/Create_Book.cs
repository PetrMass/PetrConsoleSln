using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class Create_Book
    {
        public Book[] Massiv_of_books = new Book[2]; // Почему не могу переместить в другой класс
        public void Create()
        {           
            Console.WriteLine("");
            string Name = Console.ReadLine();
            Console.WriteLine("");
            string Author = Console.ReadLine();
            Console.WriteLine("");
            string Date = Console.ReadLine();

            Book book = new Book(Name, Author, Date);

            for (int i = 0; i <= Massiv_of_books.Length; i++)
            {
                if (i < Massiv_of_books.Length && Massiv_of_books[i] == null)
                {
                    Massiv_of_books[i] = book;
                    Console.WriteLine("Книга создана");
                }
                else
                {
                    Console.WriteLine("Каталог книг переполнен\nУдалите книгу из каталога для внесения новой книги");
                }
            }



        }
    }
}