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
            /*
            foreach (Book xc in LibraryFunc.Library)  
            {
                XElement xBook = new XElement("book",
                   new XAttribute("name", $"{xc.Name}"),
                   new XAttribute("author", $"{xc.Author}"),
                   new XAttribute("date", $"{xc.Data}"));
                root.Add(xBook);
            }
            */
            xdoc.Add(root);
            xdoc.Save("Books.xml");

        }
        
        public static void XmlRead()
        {
            try
            {
                XDocument xdoc = XDocument.Load("Books.xml");
                XElement root = xdoc.Root;


                foreach (XElement xr in xdoc.Element("books").Elements("book"))
                {
                    Book book = new Book
                    {
                        Name = xr.Attribute("name").Value,
                        Author = xr.Attribute("author").Value,
                        Data = xr.Attribute("date").Value
                    };

                    LibraryFunc.Library.Add(book);
                }
            }
            catch
            {
                Console.WriteLine("!!! Файл не найден или еще чето");
                Console.WriteLine();
            }
            
        }

    }
}
