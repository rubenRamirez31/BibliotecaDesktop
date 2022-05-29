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
    public partial class AgregarLibro : Form
    {
        TransaccionesLibro tl;
        Menu m = new Menu();
        public AgregarLibro()
        {
            InitializeComponent();
            tl = new TransaccionesLibro();
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Dispose();
            
        }

       
        private void btnAgregarL_Click(object sender, EventArgs e)
        {
            Libro l = new Libro()
            {
                Nombre = txtNombreL.Text.ToUpper(),
                Autor = txtAutor.Text.ToUpper(),
                Genero = cbGenero.Text,
                Año = int.Parse(txtAñoP.Text),
                Url = txtUrl.Text,
                Disponible = true
            };

            bool registro = tl.AgregarLibro(l);
            if (registro)
            {
                MessageBox.Show("Libro Registrado");
                
                
            }
            else
            {
                MessageBox.Show("Erro Al Registrar");
            }
        }

        private void AgregarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Dispose();
        }
    }
}
