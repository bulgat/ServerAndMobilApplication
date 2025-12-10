using AngularStrike.Server.model;
using TriangleDocker.dataBasa;
using TriangleDocker.Models.graphQL;

namespace ServerAndMobil.Server.model
{
    public class QueryGraph
    {
        private readonly AppDBcontent _context;
        public QueryGraph(AppDBcontent context)
        {
            _context = context;
        }
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

        public Score GetScore()=>
            new Score { Id = 1, Name = "Война и мир", Family = "Л. Толстой" };
        /*
        return new List<Score>
    {
        new Score { Id = 1, Name = "Война и мир", Family = "Л. Толстой" },
        new Score { Id = 2, Name = "Мастер и Маргарита", Family = "М. Булгаков" }
    };
    }
*/
        public Score GetScore(string Name) =>
new Score { Id = 1, Name = "Война и мир", Family = "Л. Толстой" };

        public List<Player> GetPlayer() => _context.Player.ToList();

    }
}
