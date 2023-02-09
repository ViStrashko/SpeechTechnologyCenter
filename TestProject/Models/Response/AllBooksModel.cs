using System.Text.Json.Serialization;

namespace TestProject.Models.Response
{
    public class AllBooksModel
    {
        [JsonPropertyName("books")]
        public List<Book> Books { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AllBooksModel model &&
                   EqualityComparer<List<Book>>.Default.Equals(Books, model.Books);
        }
    }
}
