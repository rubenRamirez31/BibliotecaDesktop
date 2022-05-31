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
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

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
            
            cloud = new CloudinaryDotNet.Cloudinary(account);

        }
        //instanciamos un objeto de tipo cloudinary
        public static CloudinaryDotNet.Cloudinary cloud;
        //le pasamos los parametros de la cuenta de cloudianry
        Account account = new Account(
            "dncpitu2x",
            "688623594754413",
            "OKyQ0ksErXegtD86d3F3DacjFik");


        //abrimos un open file dialog para seleccionar el archivo para subir 
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            DialogResult result = op.ShowDialog();

            if (result == DialogResult.OK)
            {
                //le pasamos la ruta a un label para poder visualizarla
                lblrutalocal.Text = op.FileName;
            }
        }
        //el metodo cargar imagen recibe la ruta en tipo string
        //
        public void CargarImagen(String ruta)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(ruta),
                    PublicId = txtNombreL.Text,
                };
                var uploadResult = cloud.Upload(uploadParams);
                ruta = uploadResult.SecureUri.ToString();
                MessageBox.Show("Foto procesada correctamente");
                txtUrl.Text = ruta;

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
        //ahora en el boton llamamos a la accion de cargar la imagen
        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (lblrutalocal.Text.Trim() != "")
            {
                CargarImagen(lblrutalocal.Text);
            }
            else
            {
                MessageBox.Show("Nesesita tener la ruta para subir la imagen");
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
            this.Dispose();
            
        }

       
        //Este btn hace el registro a la base de datos obteniendo los datos
        //de los txt. y hace la validacion de que todos los campos esten llenos
        private void btnAgregarL_Click(object sender, EventArgs e)
        {
            if (txtNombreL.Text.Length == 0 && txtAutor.Text.Length == 0 && txtAñoP.Text.Length == 0 && txtUrl.Text.Length == 0)
            {
                MessageBox.Show("Para continuar, rellene todos los campos");
            }
            else
            {
                     Libro l = new Libro()
            {
                Nombre = txtNombreL.Text.ToUpper(),
                Autor = txtAutor.Text.ToUpper(),
                Genero = cbGenero.Text.ToUpper(),
                Año = int.Parse(txtAñoP.Text),
                Url = txtUrl.Text,
                Disponible = true
            };

            bool registro = tl.AgregarLibro(l);
            if (registro)
            {
                MessageBox.Show("Libro Registrado");
                    txtNombreL.Text = "";
                    txtAñoP.Text = "";
                    txtAutor.Text = "";
                    txtUrl.Text = "";
                    cbGenero.Text = "";
                    lblrutalocal.Text = "";
                
            }
            else
            {
                MessageBox.Show("Error Al Registrar");
            }
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
