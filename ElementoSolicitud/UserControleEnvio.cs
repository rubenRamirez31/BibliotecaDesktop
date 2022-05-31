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

namespace ElementoSolicitud
{
   
    public partial class UserControleEnvio : UserControl

    { SolicitudAceptadaTransacciones sat;
        SolicitudAceptada sa;
        string id;
        public UserControleEnvio(SolicitudAceptada sa)
        {
            InitializeComponent();
            sat = new SolicitudAceptadaTransacciones();
            this.sa = sa;
            lblID.Text = sa.Id;
            lblNombre.Text = sa.Nombre;
            lblLibro.Text = sa.Libro;
            lblDireccion.Text = sa.Direccion.ToUpper();
            lblEstatus.Text = sa.Estatus.ToUpper();
            if (lblEstatus.Text== "ENTREGADO")
            {
                btnCambiar.Enabled = false;
            }
            id = string.Empty;
        }

        int contador;
        string status;
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            
            contador++;
            lblEstatus.Text = contador.ToString();
            if (contador >= 3)
            {
                contador = 0;
            }
            switch (contador)
            {
                    case 1: lblEstatus.Text = "ENVIADO";
                    break ;
                    case 2: lblEstatus.Text = "ENTREGADO";
                    btnCambiar.Enabled = false;
                    break;
                    default : lblEstatus.Text = "null";
                    break;
            }
            id = lblID.Text;
            SolicitudAceptada sap = new SolicitudAceptada
            {
                Id = id,
                Nombre = lblNombre.Text,
                Libro = lblLibro.Text,
                Direccion = lblDireccion.Text,
                Estatus = lblEstatus.Text,
            };
            sat.ActualizarEstatus(sap);
        }

    }
}
