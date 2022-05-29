using System;
using MongoDB;
using MongoDB.Driver;

namespace OperacionesDLL
{
    public class TransaccionesLogin
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<CredencialAdmin> credencialesAdmin;

        public TransaccionesLogin()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            credencialesAdmin = db.GetCollection<CredencialAdmin>("CredencialesAdmin");
        }

        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                CredencialAdmin userTemp = credencialesAdmin.Find(u => u.Usuario == user && u.Password == pass).FirstOrDefault();
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
