using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliMania
{
    class Item
    {
        protected int Id { set; get; }
        protected String Title { set; get; }
        protected int Stock { set; get; }

        /// <summary>
        /// Constructor for Item
        /// </summary>
        /// <param name="id">Id of the item</param>
        /// <param name="title">Title of the item</param>
        /// <param name="stock">NB item on the stock</param>
        public Item(int id,String title,int stock)
        {
            this.Id = id;
            this.Title = title;
            this.Stock = stock;
        }
        /// <summary>
        /// This fucntion is use for borrow a item
        /// </summary>
        /// <returns>
        /// Return true if you have borrow the item
        /// Return flase if any item on the stock( stock == 0)
        /// </returns>
        public Boolean Borrow()
        {
            if(this.Stock>0)
            {
                this.Stock--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
