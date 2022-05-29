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

namespace BibliotecaWinForms
{
    public partial class PrestamoFisico : Form
    {
        TransaccionesDatoSolicitante ds;
        TransaccionesPrestamosFisicos pf;
        string id;
        public PrestamoFisico()
        {
            InitializeComponent();
            id = string.Empty;
            ds = new TransaccionesDatoSolicitante();
            pf = new TransaccionesPrestamosFisicos();
         
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Hide();
        }

        private void pbSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesDePrestamo sp = new SolicitudesDePrestamo();
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
            this.Hide();
        }



        //private void btnAgregarDatos_Click(object sender, EventArgs e)
        //{
        //    if (txtNombre.Text.Length == 0 && txtCalle.Text.Length == 0 && txtContacto.Text.Length == 0)
        //    {
        //        MessageBox.Show("Complete Todos Los Campos");
        //    }
        //    else
        //    {
        //        DatoSolicitante dat = new DatoSolicitante()
        //        {
        //            NombreC = txtNombre.Text.ToUpper(),
        //            Domicilio = txtCalle.Text.ToUpper(),
        //            Contacto = txtContacto.Text
        //        };

        //        bool registro = ds.AgregarDatoSolicitante(dat);
        //        if (registro)
        //        {
        //            MessageBox.Show("Datos Registrados");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error Al Registrar");
        //        }
        //    }

        //}

        private void rjButton2_Click(object sender, EventArgs e)
        {

            DatosDeLibroS dl = new DatosDeLibroS();
            dl.StartPosition = FormStartPosition.CenterScreen;
            dl.Show();
            this.Hide();
        }

        private void btnAceptarLibro_Click(object sender, EventArgs e)
        {
            id = lblID.Text;
            if (id == String.Empty)
            {
                MessageBox.Show("Debe seleciconar un libro",
                    "Precaucion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Libro ptemp = new Libro
                {
                    Id = id,
                    Nombre = lblNombre.Text,
                    Autor = lblAutor.Text,
                    Genero = lblGenero.Text,
                    Año = int.Parse(lblAño.Text),
                    Disponible = false

                };
                ds.ActualizarEstatus(ptemp);
                MessageBox.Show("Procesado Correctamente",
                    "Exito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                id = String.Empty;
            }
        }

        private void btnRegistrarPres_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0 && txtCalle.Text.Length == 0 && txtContacto.Text.Length == 0 && lblAutor.Text == "-----")
                {
                    MessageBox.Show("Asegurese de que \nlos campos esten llenos");
                }
                else
                {
                    AlmacenarDatosPrestamoFisico datpf = new AlmacenarDatosPrestamoFisico
                    {
                        NombreC = txtNombre.Text.ToUpper(),
                        Domicilio = txtCalle.Text.ToUpper() + " " + txtNumero.Text.ToString().ToUpper() + "," + txtColonia.Text.ToUpper(),
                        Contacto = txtContacto.Text,
                        Nombre = lblNombre.Text,
                        Autor = lblAutor.Text,
                        Genero = lblGenero.Text,
                        Año = int.Parse(lblAño.Text),

                    };
                    bool registro = pf.AgregarDatoDePrestamoFisico(datpf);
                    if (registro)
                    {
                        MessageBox.Show("Procesado Correctamen");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }


        }

    }
}
