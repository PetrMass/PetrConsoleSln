using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Book
    {
        string name;
        string data;
        string author;
        public string Name { set { name = value; } get { return name; } }
        public string Data { set { data = value; } get { return data; } }
        public string Author { set { author = value; } get { return author; } }


    }
} 


