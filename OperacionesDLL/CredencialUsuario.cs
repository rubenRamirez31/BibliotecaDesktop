using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class CredencialUsuario
    {

        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("usuario")]
        public string Usuario { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

    }
}
