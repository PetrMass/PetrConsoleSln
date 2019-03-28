using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class LibraryFunc
    {

        public static List<Book> Library = new List<Book>(); // непонятно, почему надо и паблик и статик
       
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
            
            File.WriteFile();
            XML.XmlCreate();

            Console.WriteLine("Книга добавлена");
            Console.WriteLine();
        }
        public void Delete() // можно сделать проще, без цикла, если возвращать индекс элемента, поле которого равно delName. Не сооброжу как.
                             // Список объектов List поддерживает поиск, но ищет он по типу Book, а надо по типу string (book.Name)
        {
            Console.WriteLine("Введите название удаляемой книги:");

            string delName = Console.ReadLine();

            if (Library.Count != 0)
            {
                for (int i = 0; i < Library.Count; i++)
                {

                    if (Library[i].Name == delName)
                    {
                        Library.RemoveAt(i);
                        Console.WriteLine("Книга удалена");
                        Console.WriteLine();
                        File.WriteFile();
                        XML.XmlCreate();
                        break;
                    }
                    else
                    {
                        if (i == Library.Count - 1)
                        {
                            Console.WriteLine("Книга не найдена");
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Список книг пуст, удалять нечего");
                Console.WriteLine();
            }

        }
        public void Show()
        {
            for (int i = 0; i < Library.Count; i++)
            {
                Console.WriteLine("Название: {0}\nАвтор: {1}\nДата: {2}",
                Library[i].Name, Library[i].Author, Library[i].Data);
                Console.WriteLine();
            }
        }
    }
}