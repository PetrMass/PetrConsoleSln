using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class Program
    {
        static void Main()
        {
             Method me = new Method();

            do
            {
                Console.WriteLine("Введите требуемое действие:\nСоздать книгу\nУдалить книгу\nПоказать весь список книг");

                if (Console.ReadLine() == "Создать книгу")
                {                   
                    me.Create();
                }

                if (Console.ReadLine() == "Удалить книгу")
                {
                    me.Delete();
                }

                if (Console.ReadLine() == "Удалить книгу")
                {
                    me.Show();
                }
            }
            while (true);
        }
    }
}
