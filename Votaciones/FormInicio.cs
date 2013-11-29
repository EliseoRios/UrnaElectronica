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
    public partial class FormInicio : Form
    {
        Acciones acciones = new Acciones();
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            String Nombre = txtNombre.Text;
            String Contraseña = txtContraseña.Text;
            String ContraseñaEncriptada;
            Boolean ValidarEntrada;

            ContraseñaEncriptada = password.Encriptar(Contraseña);
            ValidarEntrada = acciones.VerificarContraseña(ContraseñaEncriptada,Nombre.ToLower());

            if (ValidarEntrada == true)
            {
                FormBienvenida bienbenido = new FormBienvenida();
                bienbenido.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifique sus datos","Datos incorrectos..");
                txtContraseña.Text = "";
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            /*FormGenerales ayuda = new FormGenerales();
            ayuda.Show();
            this.SetVisibleCore(false);
            this.Hide();*/

            String nombre = "";
            acciones.ComprobarSiesPrimero();
            while (acciones.Leer.Read())
            {
                nombre = acciones.Leer["numero"].ToString();
            }

            if (nombre == "" || nombre.Trim() == null)
            {
                PrimerRegistro primerRegistro = new PrimerRegistro();
                primerRegistro.Show();
                MessageBox.Show("Los datos que introduzca serán utilizados para administrar el sistema\n\t\tPor seguridad: NO LOS OLVIDE","Bienbenido Administrador");
                this.Visible = false;
            }
        }
    }
}
