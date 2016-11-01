using static System.Console;

namespace ConsoleBlogApp.SQLite
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new BloggingContext()) {
                WriteLine("Type in the blog url to store:");
                var userInput = ReadLine();
                db.Blogs.Add(new Blog {Url = userInput});
                var count = db.SaveChanges();
                WriteLine($"{count} records saved to database");
                WriteLine();
                WriteLine("List of blog Urls in SQLite Database:");
                foreach (var blog in db.Blogs)
                {
                    WriteLine($" - {blog.Url}");
                }
}       }
    }
}
