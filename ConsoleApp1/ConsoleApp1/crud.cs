using System.Linq;
using Data.Domain;
using Data.Data;

namespace ConsoleApp1
{
    public class crud
    {
        public static void static_create_data()
        {
            var author = new Author
            {
                FirstName = "Tanvir ",
                LastName = "Rahman"
            };
            
            // create a deatch database connection
            using (var context = new DataContext())
            {
                context.Authors.Add(author);
                context.SaveChanges();
                System.Console.WriteLine($"[*] Data is added");
            }
        }

        public static void RetreveData()
        {
            using (var context = new DataContext())
            {
                var author = context.Authors.Single(s => s.AuthorId == 1);
                
                System.Console.WriteLine($"[+]  First Name : {author.FirstName}");
                System.Console.WriteLine($"[+]  Last Name : {author.LastName}");
            }
        }
        
        
        public static void RetreveDataWithName()
        {
            using (var context = new DataContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.FirstName == "Tanvir ");
                
                System.Console.WriteLine($"[+]  First Name : {author.FirstName}");
                System.Console.WriteLine($"[+]  Last Name : {author.LastName}");
            }
        }
        
        
        public static void RetreveDataWithPrimaryKey()
        {
            using (var context = new DataContext())
            {
                var author = context.Authors.Find(1);
                
                System.Console.WriteLine($"[+]  First Name : {author.FirstName}");
                System.Console.WriteLine($"[+]  Last Name : {author.LastName}");
            }
        }


        public static void modify_data(int authorId)
        {
            using (var context = new DataContext())
            {
                var author = context.Authors.Find(authorId);
                author.LastName = "Ornob";
                context.SaveChanges();
                System.Console.WriteLine($"[*] Database Updated");

            }
        }

        public static void deleteData(int authorId)
        {
            using (var context = new DataContext())
            {
                var author = context.Authors.Find(authorId);
                context.Authors.Remove(author);
                context.SaveChanges();
            }
        }
        
    }
}