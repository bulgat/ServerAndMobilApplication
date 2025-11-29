using AngularStrike.Server.model;

namespace ServerAndMobil.Server.model
{
    public class QueryGraph
    {
        public List<Score> GetBooks(BookService bookService) => bookService.GetBooks();
    }
}
