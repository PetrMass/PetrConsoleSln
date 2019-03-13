using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Date
    {
        string date;

        public Date(string date)
        {
            this.date = date;
        }

        public void Show()
        {
            Console.WriteLine("Дата: " + date);
        }
    }
}
