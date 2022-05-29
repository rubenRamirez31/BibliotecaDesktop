using OperacionesDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWinForms
{
    public partial class Menu : Form
    {
        TransaccionesLibro tl;
        string id;
        string url;
        public Menu()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Logon login = new Logon();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            this.Dispose();
        }

        private void pbSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesDePrestamo sdp = new SolicitudesDePrestamo();
            sdp.StartPosition = FormStartPosition.CenterScreen;
            sdp.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarLibro agl = new AgregarLibro();
            agl.StartPosition = FormStartPosition.CenterScreen;
            agl.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            url = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            Libro ltemp = tl.ObtenerLibroId(id);
            pictureBox2.ImageLocation = url;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id == String.Empty)
            {
                MessageBox.Show("Seleccione Algun Registro","Precaucion"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                tl.EliminarLibro(id);
                MessageBox.Show("Eliminado Correctamente",
                    "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = String.Empty;
                ConsultarLibros();
            }
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
            Envios en = new Envios();
            en.Show();
            this.Hide();
        }
    }
}
