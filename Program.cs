using System;

namespace ConsoleBlogApp.SQLite
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new BloggingContext()) {
                Console.WriteLine("Type in the blog url to store:");
                var userInput = Console.ReadLine();
                db.Blogs.Add(new Blog {Url = userInput});
                var count = db.SaveChanges();
                Console.WriteLine($"{count} records saved to database");
                Console.WriteLine();
                Console.WriteLine("All blogs in SQLite Database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($" - {blog.Url}");
                }
}       }
    }
}
