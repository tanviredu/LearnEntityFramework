using System.Collections.Generic;

namespace Data.Domain
{
    public class Category
    {
        public Category()
        {
            Books = new List<Book>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        /// <summary>
        /// this list of books for many to many
        /// init the list
        /// inthe constructor
        /// </summary>
        public List<Book> Books { get; set; }
    }
}