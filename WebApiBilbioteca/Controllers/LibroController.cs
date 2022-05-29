using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using WebApiBilbioteca.Models;

namespace WebApiBilbioteca.Controllers
{
    [Route("api/Libros")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        [HttpGet("ObtenerLibros")]
        public List<Libro> ObtenerLibros()
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101." +
                "@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w" +
                "=majority");
            IMongoDatabase db = cliente.GetDatabase("Biblioteca");
            IMongoCollection<Libro> libros = db.GetCollection<Libro>("Libros");

            return libros.Find(l => true).ToList();

        }


        [HttpGet("ObtenerProductoXId/{id}")]
        public Libro ObtenerLibroPorId(string id)
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<Libro> libros =
                db.GetCollection<Libro>("Libros"); //indicar las coleciones

            return libros.Find(l => l.Id == id).FirstOrDefault();
        }

        [HttpPut("ActualizarLibro")]
        public Libro ActualizarProducto([FromBody] Libro l)
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<Libro> libros =
                db.GetCollection<Libro>("Libros");
            libros.ReplaceOne(ant => ant.Id == l.Id, l);
            return l;
        }

        [HttpPost("InsertarLibro")]
        public Libro InsertarProducto([FromBody] Libro p)
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<Libro> libros =
                db.GetCollection<Libro>("Libros");
            libros.InsertOne(p);
            return p;
        }

        [HttpPost("InsertarSolicitud")]
        public SolicitudRemota InsertarRegistroRemoto([FromBody] SolicitudRemota sr)
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<SolicitudRemota> solicitudesremotas =
                db.GetCollection<SolicitudRemota>("SolicitudesDePrestamo");
            solicitudesremotas.InsertOne(sr);
            return sr;
        }

        [HttpPost("Login")]
        public Respuesta IniciarSesion([FromBody]CredencialUsuario u)
        {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<CredencialUsuario> credencialesusuarios =
                db.GetCollection<CredencialUsuario>("CredencialesUsuarios");
            CredencialUsuario userTemp = credencialesusuarios.Find(x => x.User == 
            u.User && x.Pass == u.Pass).FirstOrDefault();
            Respuesta r = new Respuesta();
            if (userTemp != null) 
            {
                r.Estatus = 200;
                r.Mensaje = "Usuario Valido";
            }
            else
            {
                r.Estatus = 500;
                r.Mensaje = "Usuario y/o Password incorrecto";
            }
            return r;
        }


        [HttpPost("Registro")]
        public Respuesta Registrar([FromBody] CredencialUsuario u)
        {
            Respuesta r = new Respuesta();
            try
            {
            MongoClient cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net/myFirstDatabase?retryWrites=true&w=majority"); //Conexion
            IMongoDatabase db = cliente.GetDatabase("Biblioteca"); //Indicar el nombre de base de datos
            IMongoCollection<CredencialUsuario> credencialesusuarios =
                db.GetCollection<CredencialUsuario>("CredencialesUsuarios");
                credencialesusuarios.InsertOne(u);
                r.Estatus = 200;
                r.Mensaje = "Usuario agregado correctamente";
            }
            catch (System.Exception ex)
            {

                r.Estatus=500;
                r.Mensaje = ex.Message;
            }
            return r;
        }

    }
}
