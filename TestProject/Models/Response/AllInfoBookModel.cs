using System.Text.Json.Serialization;

namespace TestProject.Models.Response
{
    public class AllInfoBookModel
    {
        [JsonPropertyName("book")]
        public Book Book { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AllInfoBookModel model &&
                   EqualityComparer<Book>.Default.Equals(Book, model.Book);
        }
    }
}
