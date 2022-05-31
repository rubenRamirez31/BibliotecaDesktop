using System;
using System.Windows.Forms;
using OperacionesDLL;
namespace ElementoSolicitud
{
    public partial class SolicitudesRemotas : UserControl
    {
        SolicitudDePrestamo sp;
        TransaccionesSolicitudDePrestamo ts;
        string id;
        public SolicitudesRemotas(SolicitudDePrestamo sp)
        {
            InitializeComponent();
            this.sp = sp;
            lblID.Text = sp.Id;
            lblNombre.Text = sp.Nombre;
            lblLibro.Text = sp.Libro;
            lblDireccion.Text = sp.Direccion.ToUpper();

            ts = new TransaccionesSolicitudDePrestamo();
            id = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                SolicitudAceptada sa = new SolicitudAceptada()
                {
                    Nombre = lblNombre.Text,
                    Libro = lblLibro.Text,
                    Direccion = lblDireccion.Text,
                    Estatus = "PROCESADO",

                };
                bool registro = ts.AceptarSolicitud(sa);
            if (registro) MessageBox.Show("Procesado Correctamene");
                id = lblID.Text;
                ts.EliminarSolicitud(id);
            this.Dispose();

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            SolicitudRechazada sr = new SolicitudRechazada()
            {
                Nombre = lblNombre.Text,
                Libro = lblLibro.Text,
                Direccion = lblDireccion.Text
            };
            bool registro = ts.RechazarSolicitud(sr);
            if (registro) MessageBox.Show("Procesado correctamente");
            id = lblID.Text;
            ts.EliminarSolicitud(id);
            this.Dispose();
        }
    }
}
