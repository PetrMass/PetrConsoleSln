using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Book
    {
        readonly Name name;
        readonly Author author;
        readonly Date date;

        public Book(string name, string author, string date)
        {
            this.name = new Name(name);
            this.author = new Author(author);
            this.date = new Date(date);
        }


    }
} 


