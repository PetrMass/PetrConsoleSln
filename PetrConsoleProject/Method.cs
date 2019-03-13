using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class Method
    {
        public Book[] Massiv_of_books = new Book[2];

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
                if (i < Massiv_of_books.Length && Massiv_of_books[i].Name == null) // как прочитать поле имени
                {
                    Console.WriteLine("Книга создана");
                    Massiv_of_books[i] = book;                    
                }
                else
                {
                    Console.WriteLine("Каталог книг переполнен\nУдалите книгу из каталога для внесения новой книги");
                }
            }



        }
        public void Delete()
        {
            Console.WriteLine("Введите название удаляемой книги:");
            string DelBook = Console.ReadLine();
            
            for (int i = 0; i < Massiv_of_books.Length; i++)
            {
                if (Massiv_of_books[i] != null && Massiv_of_books[i].Name == delName) //
                {
                    Massiv_of_books[i] = null;
                    Console.WriteLine("Книга удалена");
                    Console.WriteLine("-------------------");                   
                }
                else
                {
                    if (i == Massiv_of_books.Length-1)
                        Console.WriteLine("Книга не найдена");
                }
            } 
            

        }
        public void Show()
        {
            for (int i = 0; i < Massiv_of_books.Length; i++)
            {
                if (Massiv_of_books[i] != null)
                {
                    Massiv_of_books[i].Name.Show();
                    Massiv_of_books[i].Author.Show();
                    Massiv_of_books[i].Date.Show();
                }
            }
        }
    }
}