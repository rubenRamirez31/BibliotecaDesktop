using System;
using System.Windows.Forms;
using OperacionesDLL;

namespace ControlSolicitudes
{
    public partial class UserControl1 : UserControl
    {
        TransaccionesSolicitudDePrestamo sp;
        public UserControl1()
        {
            InitializeComponent();
            sp = new TransaccionesSolicitudDePrestamo();
            ConsultarSolicitudes();
        }

        public void ConsultarSolicitudes()
        {
            dataGridView1.DataSource = sp.ObtenerSolicitudes();
        }

    }
}
