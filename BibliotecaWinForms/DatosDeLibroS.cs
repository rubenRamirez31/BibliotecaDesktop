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
    public partial class DatosDeLibroS : Form
    {

        TransaccionesLibro tl;
        string id;
        bool disp;
        public DatosDeLibroS()
        {
            InitializeComponent();


            tl = new TransaccionesLibro();
            id = string.Empty;
            ConsultarLibros();

        }
        private void ConsultarLibros()
        {
            dataGridView1.DataSource = tl.ObtenerLibros();
        }

        private void DatosDeLibroS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }



        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {

            PrestamoFisico pf = new PrestamoFisico();


            id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            Libro ltemp = tl.ObtenerLibroId(id);
            disp = ltemp.Disponible;
            if (disp == false)
            {
                MessageBox.Show("Este libro no esta disponible");
            }
            else
            {
                pf.lblID.Text = id;
                pf.lblNombre.Text = ltemp.Nombre;
                pf.lblAutor.Text = ltemp.Autor;
                pf.lblGenero.Text = ltemp.Genero;
                pf.lblAño.Text = ltemp.Año.ToString();

                this.Hide();
                pf.StartPosition = FormStartPosition.CenterScreen;
                pf.Show();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PrestamoFisico pf = new PrestamoFisico();
            this.Dispose();
            pf.StartPosition = FormStartPosition.CenterScreen;
            pf.Show();
        }
    }
}
