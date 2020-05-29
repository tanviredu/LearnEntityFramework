using System;
using System.Collections.Generic;

namespace Data.Domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }    //this is for one to many
        
        /// <summary>
        /// for one to one
        /// </summary>
        public AuthorBiography Biography { get; set; }
    }

    public class AuthorBiography
    {
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string placeOfbirth { get; set; }
        public string nationality { get; set; }
        
        /// <summary>
        /// just like one to many this
        /// have to be provided to make the one to one relationship
        /// </summary>
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}