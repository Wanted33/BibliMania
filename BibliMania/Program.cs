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
            Book book = new Book(11111111, BookType.EROTICISM, "JALLAN", 1, "Son cul était du poulet.", 0);
            Console.WriteLine(book.ToString());
            book.Borrow();
            Console.WriteLine(book.ToString());
            Console.ReadLine();
            book.Borrow();
            Console.WriteLine(book.ToString());
            Console.ReadLine();
        }
    }
}
