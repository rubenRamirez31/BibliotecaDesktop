using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class Libro
    {
        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("autor")]
        public string Autor { get; set; }

        [BsonElement("año")]
        public int Año { get; set; }

        [BsonElement("disponible")]
        public bool Disponible { get; set; }

        [BsonElement("genero")]
        public string Genero { get; set; }

        [BsonElement("url")]
        public string Url { get; set; }

    }
}
