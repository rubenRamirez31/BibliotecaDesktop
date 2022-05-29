using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    
    public class TransaccionesCredencialUsuario
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<CredencialUsuario> credencialesUsuario;

        public TransaccionesCredencialUsuario()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            credencialesUsuario = db.GetCollection<CredencialUsuario>("CredencialesUsuarios");
        }

        public bool Registrar(CredencialUsuario u)
        {
            try
            {
                CredencialUsuario utemp = credencialesUsuario.Find(u2 => u2.Usuario == u.Usuario).FirstOrDefault();
                if (utemp != null)
                    return false;

                credencialesUsuario.InsertOne(u);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                CredencialUsuario userTemp = credencialesUsuario.Find(u => u.Usuario == user && u.Password == pass).FirstOrDefault();
                if (userTemp != null)
                    return true;
                return false;
            }

            catch (Exception)
            {

                return false;
            }


        }

    }
}
