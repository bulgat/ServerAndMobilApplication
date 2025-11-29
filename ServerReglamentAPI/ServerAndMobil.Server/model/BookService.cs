using AngularStrike.Server.model;

namespace ServerAndMobil.Server.model
{
    public class BookService
    {
        public List<Score> GetBooks()
        {
            return new List<Score>
        {
            new Score { Id = 1, Name = "Война и мир", Family = "Л. Толстой" },
            new Score { Id = 2, Name = "Мастер и Маргарита", Family = "М. Булгаков" }
        };
        }
    }
}
