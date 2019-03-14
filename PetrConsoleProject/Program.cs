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
                Console.WriteLine("Введите требуемое действие:\n1-Создать книгу\n" +
                    "2-Удалить книгу\n3-Показать весь список книг");

                string Choice = Console.ReadLine();

                if (Choice == "1")
                {                   
                    me.Create();
                }

                if (Choice == "2")
                {
                    me.Delete();
                }

                if (Choice == "3")
                {
                    me.Show();
                }
            }
            while (true);
        }
    }
}
