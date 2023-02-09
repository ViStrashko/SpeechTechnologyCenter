using System.Text.Json.Serialization;

namespace TestProject.Models.Request
{
    public class BookRegistrationModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("author")]
        public string? Author { get; set; }

        [JsonPropertyName("year")]
        public int? Year { get; set; }

        [JsonPropertyName("isElectronicBook")]
        public bool? IsElectronicBook { get; set; }
    }
}
