using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    public class Name
    {
        public string name;


        public Name(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Название: " + name);
        }
              

        public override bool Equals(object obj)
        {            
            if (obj is Name)
            {
                Name compBooook = (Name)obj;
                return this.name.Equals(compBooook.name);
            }
            return false;           
        }
    }
}
