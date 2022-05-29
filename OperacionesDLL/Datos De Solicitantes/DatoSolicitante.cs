using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class DatoSolicitante
    {
        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombreC")]
        public string NombreC { get; set; }

        [BsonElement("domicilio")]
        public string Domicilio { get; set; }

        [BsonElement("contacto")]
        public string Contacto { get; set; }

    }
}
