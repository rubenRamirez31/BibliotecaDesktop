using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class TransaccionesDatoSolicitante
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<DatoSolicitante> datossolicitantes;
        IMongoCollection<Libro> libros;

        public TransaccionesDatoSolicitante()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                   "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            datossolicitantes = db.GetCollection<DatoSolicitante>("DatosSolicitantes");
            libros = db.GetCollection<Libro>("Libros");
        }

        public bool AgregarDatoSolicitante(DatoSolicitante ds)
        {
            try
            {
                datossolicitantes.InsertOne(ds);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
        public bool ActualizarEstatus(Libro l)
        {
            try
            {
                libros.ReplaceOne(ant => ant.Id == l.Id, l);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
