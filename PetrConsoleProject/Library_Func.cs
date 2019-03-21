using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class Library_Func
    {

        List<Book> Library = new List<Book>();

        public void Create()
        {
            Book book = new Book();

            Console.WriteLine("Введите название");
            book.Name = Console.ReadLine();
            Console.WriteLine("Введите автора");
            book.Author = Console.ReadLine();
            Console.WriteLine("введите дату");
            book.Data = Console.ReadLine();

            Library.Add(book);

        }
        public void Delete() // можно сделать проще, без цикла, если возвращать индекс элемента, поле которого равно delName. Не сооброжу как.
                             // Список объектов List поддерживает поиск, но ищет он по типу Book, а надо по типу string (book.Name)
        {
            Console.WriteLine("Введите название удаляемой книги:");

            string delName = Console.ReadLine();

            for (int i = 0; i < Library.Count; i++)
            {
                if (Library[i].Name == delName)
                {
                    Library.RemoveAt(i);
                    Console.WriteLine("Книга удалена");
                    break;
                }
                else
                {
                    if (i == Library.Count - 1)
                    {
                        Console.WriteLine("Книга не найдена");
                    }
                }
            }


        }
        public void Show()
        {
            for (int i = 0; i < Library.Count; i++)
            {
                Console.WriteLine("Название: {0}\nАвтор: {1}\nДата: {2}",
                Library[i].Name, Library[i].Author, Library[i].Data);
            }
        }
    }
}