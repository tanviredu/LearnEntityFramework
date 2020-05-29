using System.Collections.Generic;

namespace Data.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// this author and author id habe to be given
        /// for one to many
        /// </summary>
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        
        /// <summary>
        /// this List category go many to many
        /// </summary>
        public List<Category> Categories { get; set; }


    }
}