using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class SolicitudAceptadaTransacciones
    {

        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<SolicitudAceptada> solicitudesceptadas;
        public SolicitudAceptadaTransacciones()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            solicitudesceptadas = db.GetCollection<SolicitudAceptada>("SolicitudesAceptadas");
        }

        public List<SolicitudAceptada> ObtenerDatos()
        {
            List<SolicitudAceptada> sptemp = solicitudesceptadas.
                Find(sp => true).ToList();

            return sptemp;
        }

        public bool ActualizarEstatus(SolicitudAceptada l)
        {
            try
            {
                solicitudesceptadas.ReplaceOne(ant => ant.Id == l.Id, l);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
