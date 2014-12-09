using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliMania
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library("Bibliothèque Nationale de Toulouse");
            myLibrary.mainMenu();
        }
    }
}
