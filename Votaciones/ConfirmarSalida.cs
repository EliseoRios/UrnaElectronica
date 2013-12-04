using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Votaciones
{
    public partial class FormIdAdmin : Form
    {
        public FormIdAdmin()
        {
            InitializeComponent();
        }
        Acciones acciones = new Acciones();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            String Nombre = txtNombre.Text;
            String Contraseña = txtContrasenia.Text;
            String ContraseñaEncriptada;
            Boolean ValidarEntrada;

            ContraseñaEncriptada = password.Encriptar(Contraseña);
            ValidarEntrada = acciones.VerificarContraseña(ContraseñaEncriptada, Nombre.ToLower());

            if (ValidarEntrada == true)
            {
                FormAdministrador admin = new FormAdministrador();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique sus datos", "Datos incorrectos..");
                txtContrasenia.Text = "";
            }
        }

        private void btnCarcel_Click(object sender, EventArgs e)
        {
            FormBienvenida bienbenida = new FormBienvenida();
            bienbenida.Show();
            this.Close();
        }
        //WindowState = FormWindowState.Minimized;
    }
}
