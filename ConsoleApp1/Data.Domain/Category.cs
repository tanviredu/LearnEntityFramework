using System.Collections.Generic;

namespace Data.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        /// <summary>
        /// this list of books for many to many
        /// </summary>
        public List<Book> Books { get; set; }
    }
}