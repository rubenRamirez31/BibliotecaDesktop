using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class TransaccionesSolicitudDePrestamo
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<SolicitudDePrestamo> solicitudesdeprestamo;
        IMongoCollection<SolicitudAceptada> solicitudesceptadas;
        IMongoCollection<SolicitudRechazada> solicitudesrechazadas;
        public TransaccionesSolicitudDePrestamo()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            solicitudesdeprestamo = db.GetCollection<SolicitudDePrestamo>("SolicitudesDePrestamo");
            solicitudesceptadas = db.GetCollection<SolicitudAceptada>("SolicitudesAceptadas");
            solicitudesrechazadas = db.GetCollection<SolicitudRechazada>("SolicitudesRechazadas");
        }

        public List<SolicitudDePrestamo> ObtenerDatos()
        {
            List<SolicitudDePrestamo> sptemp = solicitudesdeprestamo.
                Find(sp => true).ToList();

            return sptemp;
        }

        public bool EliminarSolicitud(string id)
        {
            try
            {
                solicitudesdeprestamo.DeleteOne(p => p.Id == id);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public bool AceptarSolicitud(SolicitudAceptada sa)
        {
            try
            {
                solicitudesceptadas.InsertOne(sa);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public bool RechazarSolicitud(SolicitudRechazada sr)
        {
            try
            {
                solicitudesrechazadas.InsertOne(sr);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }


    }
}
