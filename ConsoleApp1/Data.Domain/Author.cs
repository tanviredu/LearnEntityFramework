﻿using System.Collections.Generic;

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
}