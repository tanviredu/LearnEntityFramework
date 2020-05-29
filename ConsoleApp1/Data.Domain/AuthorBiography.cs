using System;

namespace Data.Domain
{
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