using System.Text.Json.Serialization;

namespace TestProject.Models.Response
{
    public class BookAllInfoModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("isElectronicBook")]
        public bool IsElectronicBook { get; set; }
    }
}
