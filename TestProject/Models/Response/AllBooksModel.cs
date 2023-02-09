using System.Text.Json.Serialization;

namespace TestProject.Models.Response
{
    public class AllIBooksModel
    {
        [JsonPropertyName("books")]
        public List<Book> Books { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AllIBooksModel model &&
                   EqualityComparer<List<Book>>.Default.Equals(Books, model.Books);
        }
    }
}
