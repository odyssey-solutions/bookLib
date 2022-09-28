using BookLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using BookLibrary.Data;

namespace EFApplication
{
    public static class jsonModelExtentions
    {
        public static T jsonObject<T>(this string source)
        {
            return JsonSerializer.Deserialize<T>(source)!;
        }
    }
    public class squidGame
    {
        
        public string Name { get; set; }
        public string Genre { get; set; }
        public IDictionary<string, double> Rating { get; set; }
        public int Year { get; set; }
        public List<string> Stars { get; set; }
        public string Language { get; set; }
        public string Budget { get; set; }
    }

    class Program
    {
        static IEnumerable<Author> CreateFakeData()
        {
            var authors = new List<Author>
            {
                new Author 
                {
                    Name = "Jane Austen", Books = new List<Book>
                    {
                        new Book {Title = "Emma", YearOfPublication = 1815},
                        new Book {Title = "Persuasion", YearOfPublication = 1818},
                        new Book {Title = "Mansfield Park", YearOfPublication = 1814}
                    }
                },
                new Author 
                {
                    Name = "Ian Fleming", Books = new List<Book>
                    {
                        new Book {Title = "Dr No", YearOfPublication = 1958},
                        new Book {Title = "Goldfinger", YearOfPublication = 1959},
                        new Book {Title = "From Russia with Love", YearOfPublication = 1957}
                    }
                }
            };

            return authors;
        }
        
        static void Main()
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json")
                  .Build();

            var options = new DbContextOptionsBuilder<BookLibraryContext>()
                .UseMySQL(Configuration.GetConnectionString("BooksLibrary:mySQLServer"))
                .Options;

            using var db = new BookLibraryContext(options);

            JsonTest();

            DataTest(db);
        }

        static void DataTest(BookLibraryContext db)
        {
            db.Database.EnsureCreated();
            
            var authors = CreateFakeData();

            db.Authors.AddRange(authors);

            db.SaveChanges();


            //var recentBooks = from b in db.Books where b.YearOfPublication > 1900 select b;

            //foreach (var book in recentBooks.Include(b => b.Author))
            //{
            //    Console.WriteLine($"{book} is by {book.Author}");
            //}
        }

        static void JsonTest()
        {
            // NativeJsonUnitTest.cs
            String jsonString = @"
            {
                ""Name"": ""Squid Game"",
                ""Genre"": ""Thriller"",
                ""Rating"": {
                    ""Imdb"": 8.1,
                    ""Rotten Tomatoes"": 0.94
                },
                ""Year"": 2021,
                ""Stars"": [""Lee Jung-jae"", ""Park Hae-soo""],
                ""Language"": ""Korean"",
                ""Budget"": ""$21.4 million""
            }";

            string classname = "EFApplication.squidGame";

            var dynamicObject = JsonSerializer.Deserialize<squidGame>(jsonString)!;
            var game = jsonString.jsonObject<squidGame>();
            
            /*
            Type jsonClassType = Type.GetType(classname);
            // Get the generic method `Foo`
            var methodJsonObject = typeof(jsonModelExtentions).GetMethod("jsonObject");

            // Make the non-generic method via the `MakeGenericMethod` reflection call.
            // Yes - this is confusing Microsoft!!
            var methodJsonClassObject = methodJsonObject.MakeGenericMethod(new[] { jsonClassType });
    
            // Invoke the method just like a normal method.
            methodJsonClassObject.Invoke(new jsonModelExtentions(), new object[] { new object() });
            */
            
            Console.WriteLine(dynamicObject);
            var genre = dynamicObject.Genre;
        }
    }
}
