using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrConsoleProject
{
    class File
    {

        public static void WriteFile()
        {
            string writePath = @"C:\Library.txt";







            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default)) // не ясно, почему не работает без юсинг
            {
                for (int i = 0; i < LibraryFunc.Library.Count; i++)
                {
                    sw.WriteLine("Книга № {0}", i + 1);
                    sw.WriteLine(LibraryFunc.Library[i].Name);
                    sw.WriteLine(LibraryFunc.Library[i].Author);
                    sw.WriteLine(LibraryFunc.Library[i].Data);
                }
            }



        }

    }
}
