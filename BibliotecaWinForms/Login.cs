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
using CustomControls;

namespace BibliotecaWinForms
{ 
    public partial class Logon : Form
    {
        TransaccionesLogin t;
        public Logon()
        {
            InitializeComponent();
            t = new TransaccionesLogin();
            tbCaracteres.Checked = false;

            if (tbCaracteres.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool sesion = t.ValidarLogin(txtUsuario.Text, txtPassword.Text);
            if (sesion)
            {
                MessageBox.Show("Bienvenido: " + txtUsuario.Text);
                this.Hide();
                Menu m = new Menu();
                m.StartPosition = FormStartPosition.CenterScreen;
                m.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos, si no " +
                    "posee uno comuniquese con su administrador.");
            }
        }
        private void Logon_Load(object sender, EventArgs e)
        {

        }

     

        private void Logon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCaracteres.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
               
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = txtPassword.Text;
            }
         
        }
    }
}
