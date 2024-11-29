using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LojaCelularAPI.Models
{
    public class Celulares
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nome")]
        [JsonPropertyName("Nome")]
        public string Nome { get; set; } = null!;

        public decimal Preco { get; set; }

        public string Marca { get; set; } = null!;

        public string Modelo { get; set; } = null!;

        public string SistemaOperacional { get; set; } = null!;
    }
}
