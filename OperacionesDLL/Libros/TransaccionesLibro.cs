using MongoDB;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace OperacionesDLL
{ 
    public class TransaccionesLibro
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<Libro> libros;

        public TransaccionesLibro()
        {
         cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
         db = cliente.GetDatabase("Biblioteca");
            libros = db.GetCollection<Libro>("Libros");
        }

        public List<Libro> ObtenerLibros()
        {
            return libros.Find(p => true).ToList();

        }
        public Libro ObtenerLibroId(string id)
        {
            return libros.Find(p => p.Id == id).FirstOrDefault();
        }

        public bool AgregarLibro(Libro l)
        {
            try
            {
                libros.InsertOne(l);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public bool EliminarLibro(string id)
        {
            try
            {
                libros.DeleteOne(p => p.Id == id);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

    }
}
