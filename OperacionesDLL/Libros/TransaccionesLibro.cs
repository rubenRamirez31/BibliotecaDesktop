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
            //en este apartado hacemos referencia a que base datos y a que coleccion 
            //vamos a acceder
         cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
         db = cliente.GetDatabase("Biblioteca");
            libros = db.GetCollection<Libro>("Libros");
        }

        //este metodo es de tipo lista
        //retornamos los datos en forma de lista.
        public List<Libro> ObtenerLibros()
        {
            return libros.Find(p => true).ToList();

        }

        public Libro ObtenerLibroId(string id)
        {
            return libros.Find(p => p.Id == id).FirstOrDefault();
        }
        //En este casi recibimos el objeto libro ya con datos
        // y lo insertamos a la base de datos
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
        // eliminamos por id el libro en cuestion, este mtodo
        //recibe como parametro un id 
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
