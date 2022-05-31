using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperacionesDLL;
using ElementoSolicitud;

namespace BibliotecaWinForms
{
    public partial class Envios : Form
    {
        SolicitudAceptadaTransacciones sa;
        public Envios()
        {
            InitializeComponent();
            sa = new SolicitudAceptadaTransacciones();
            //llamamos al metodo obtener datos
            ObtenerDatos();
        }

        //obtenermos los datos mediante un for each para que recorra y despliegue
        //en el flow layoud panel por cada registro en la db
        public void ObtenerDatos()
        {
            foreach (var item in sa.ObtenerDatos())
            {
                UserControleEnvio s = new UserControleEnvio(item);
                this.flowLayoutPanel1.Controls.Add(s);
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Hide();

        }

        private void pbEnvios_Click(object sender, EventArgs e)
        {

        }

        private void pbSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesDePrestamo sd = new SolicitudesDePrestamo();
            sd.StartPosition = FormStartPosition.CenterScreen;
            sd.Show();
            this.Hide();
        }

        private void pbPrestamoPrecencial_Click(object sender, EventArgs e)
        {
            PrestamoFisico pf = new PrestamoFisico();
            pf.StartPosition = FormStartPosition.CenterScreen;
            pf.Show();
            this.Hide();
        }
    }
}
