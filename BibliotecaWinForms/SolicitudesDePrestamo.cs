using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElementoSolicitud;
using OperacionesDLL;

namespace BibliotecaWinForms
{

    public partial class SolicitudesDePrestamo : Form
    {
        TransaccionesSolicitudDePrestamo sp;
        public SolicitudesDePrestamo()
        {
            InitializeComponent();
            sp = new TransaccionesSolicitudDePrestamo();
            ObtenerDatos();
        }

        /// se llena el flow layout panel por cada elemento en el registro
        public void ObtenerDatos()
        {
            foreach (var item in sp.ObtenerDatos())
            {
                SolicitudesRemotas s = new SolicitudesRemotas(item);
                this.flowLayoutPanel1.Controls.Add(s);
            }
        }
        

        private void pbMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Hide();
        }

        private void pbPrestamoPrecencial_Click(object sender, EventArgs e)
        {
            PrestamoFisico pp = new PrestamoFisico();
            pp.StartPosition = FormStartPosition.CenterScreen;
            pp.Show();
            this.Hide();
        }

        private void pbEnvios_Click(object sender, EventArgs e)
        {
            Envios env = new Envios();
            env.StartPosition = FormStartPosition.CenterScreen;
            env.Show();
            this.Hide();
        }
    }
}
