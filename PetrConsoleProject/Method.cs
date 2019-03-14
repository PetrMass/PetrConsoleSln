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
           
                Book book = new Book();

                Console.WriteLine("Введите название");
                book.Name = Console.ReadLine();
                Console.WriteLine("Введите автора");
                book.Author = Console.ReadLine();
                Console.WriteLine("введите дату");
                book.Data = Console.ReadLine();

            for (int i = 0; i < Massiv_of_books.Length; i++)
            {
                if (i < Massiv_of_books.Length && Massiv_of_books[i] == null) 
                {
                    Massiv_of_books[i] = book;
                    Console.WriteLine("Книга создана");
                    break;
                }
                else
                {
                    if (i == Massiv_of_books.Length-1)
                    {
                        Console.WriteLine("Каталог книг переполнен\nУдалите книгу из каталога для внесения новой книги");
                    }                   
                }
                
            }

        }
        public void Delete()
        {
            Console.WriteLine("Введите название удаляемой книги:");
            string delName = Console.ReadLine();
            
            for (int i = 0; i < Massiv_of_books.Length; i++)
            {
                if (Massiv_of_books[i] != null && Massiv_of_books[i].Name == delName) 
                {
                    Massiv_of_books[i] = null;
                    Console.WriteLine("Книга удалена");
                    Console.WriteLine("-------------------");
                    break;
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
                    Console.WriteLine("Название: {0}\nАвтор: {1}\nДата создания: {2}",
                    Massiv_of_books[i].Name, Massiv_of_books[i].Author, Massiv_of_books[i].Data);
                    Console.WriteLine("-");
                }
            }
        }
    }
}