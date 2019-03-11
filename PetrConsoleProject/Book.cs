using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Book
    {
        //Создание объектов класса
        readonly Name name;
        readonly Author author;
        readonly Date date;

        //Пользовательский конструктор
        public Book(string name, string author, string date)
        {
            //Инициализация свойств для каждого объекта
            this.name = new Name(name);
            this.author = new Author(author);
            this.date = new Date(date);
        }

        
    }
} 


