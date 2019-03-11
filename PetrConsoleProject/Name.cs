using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class Name
    {
       readonly string name;

        public Name(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Название: " + name);
        }
    }
}
