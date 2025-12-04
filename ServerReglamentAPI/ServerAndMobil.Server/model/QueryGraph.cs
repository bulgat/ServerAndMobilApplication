using AngularStrike.Server.model;
using TriangleDocker.Models.graphQL;

namespace ServerAndMobil.Server.model
{
    public class QueryGraph
    {
        //public List<Score> GetBooks(BookService bookService) => bookService.GetBooks();

        public Book GetBook() =>
       new Book
       {
           Title = "C# in depth.",
           Author = new Author
           {
               Name = "Jon Skeet"
           }
       };
    }
}
