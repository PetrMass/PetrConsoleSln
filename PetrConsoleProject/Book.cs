using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Book
    {
        public  string Name;
        public  Author Author;
        public  Date Date;

        public Book(string name, string author, string date)
        {
            this.Name = name;
            this.Author = new Author(author);
            this.Date = new Date(date);
        }


    }
} 


