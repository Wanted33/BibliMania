using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliMania
{
    enum BookType { FANTASY=1,MANGA,ART,SPORT,WAR,ROMANCE,FICTION,EROTICISM,MANUEL,YOUTH};
    class Book : Item
    {
        private int ISBN { set; get; }
        private BookType BookType { set; get; }
        private String Author { set; get; }

        /// <summary>
        /// Constructor for Book 
        /// </summary>
        /// <param name="isbn">Number ISBN form the book </param>
        /// <param name="bookType">ENUM for the book type</param>
        /// <param name="author">author for the book</param>
        /// <param name="id">id for the book</param>
        /// <param name="title">title for the book</param>
        /// <param name="stock">NB book in the stock</param>
        public Book(int isbn,BookType bookType,String author,int id,String title,int stock): base(id,title,stock)
        {
            this.ISBN = isbn;
            this.BookType = bookType;
            this.Author = author;
        }
        /// <summary>
        /// Return in String the object 
        /// </summary>
        /// <returns>Title : 
        /// Author:
        /// Type:
        /// NB in stock:</returns>
        public override string ToString()
        {
            String returnStringBook;
            returnStringBook = "Title : " + this.Title + "\nAuthor : " + this.Author + "\nType : " + 
                this.BookType + "\nNb in stock : " + this.Stock;
            return returnStringBook;
        }
    }
}
