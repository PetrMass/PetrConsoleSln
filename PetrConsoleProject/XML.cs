using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetrConsoleProject
{
    class XML
    {
        public static void XmlCreate()
        {
            XDocument xdoc = new XDocument();
            XElement root = new XElement("books");

            for (int i = 0; i < LibraryFunc.Library.Count; i++)
            {
                XElement xBook = new XElement("book",
                    new XAttribute("name", $"{LibraryFunc.Library[i].Name}"),
                    new XAttribute("author", $"{LibraryFunc.Library[i].Author}"),
                    new XAttribute("date", $"{LibraryFunc.Library[i].Data}"));
                root.Add(xBook);
                
            }

            xdoc.Add(root);
            xdoc.Save("Books.xml");

        }

    }
}
