using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class TransaccionesPrestamosFisicos
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<AlmacenarDatosPrestamoFisico> datosprestamosfisicos;

        public TransaccionesPrestamosFisicos()
        {
            cliente = new MongoClient("mongodb+srv://morris:Morris3101.@topicosrrh.0w8px.mongodb.net" +
                "/myFirstDatabase?retryWrites=true&w=majority");
            db = cliente.GetDatabase("Biblioteca");
            datosprestamosfisicos = db.GetCollection<AlmacenarDatosPrestamoFisico>("DatosPrestamosFisicos");
        }

        public bool AgregarDatoDePrestamoFisico(AlmacenarDatosPrestamoFisico dpf)
        {
            try
            {
                datosprestamosfisicos.InsertOne(dpf);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }


    }
}
