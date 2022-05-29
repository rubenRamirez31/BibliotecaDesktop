using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApiBilbioteca.Models
{
    public class SolicitudRemota
    {
        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("libro")]
        public string Libro { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; }
    }
}
