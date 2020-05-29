namespace Data.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        // the author object will be here
        // and the authorid
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        
    }
}