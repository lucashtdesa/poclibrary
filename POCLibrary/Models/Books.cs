using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace POCLibrary.Models
{
    public class Books
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("error")]
        public bool Error { get; set; }

        [JsonPropertyName("statusCode")]
        public long StatusCode { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("suggestions")]
        public List<string> Suggestions { get; set; }

        [JsonPropertyName("books")]
        public List<Book> Books { get; set; }
    }

    public partial class Book
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("link")]
        public Uri Link { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("value")]
        public float Value { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
