using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiBilbioteca.Models
{
    public class CredencialUsuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("user")]
        public string User { get; set; }

        [BsonElement("pass")]
        public string Pass { get; set; }
    }
}
