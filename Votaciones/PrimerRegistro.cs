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
    public partial class PrimerRegistro : Form
    {
        public PrimerRegistro()
        {
            InitializeComponent();
        }

        Acciones acciones = new Acciones();


        private void btnGuargar_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            String ContraseñaEncriptada;
            String Nombre = txtNombre.Text;
            String Direccion = txtDireccion.Text;
            String Telefono = txtTelefono.Text;
            String Celular = txtCelular.Text;
            String Oficina = txtOficiona.Text;
            String Ciudad = txtCiudad.Text;
            String CP = txtCP.Text;
            String Sexo = txtSexo.Text;
            String Contrasenia = txtContrasenia.Text;
            String Confirmacion = txtConfirmar.Text;

            if (Nombre.Trim() == "" || Oficina.Trim() == "" || Direccion.Trim() == "" || Contrasenia.Trim() == "" || Confirmacion.Trim() == "")
            {
                if (Nombre.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un nombre", "Información..");
                }
                else if (Oficina.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar oficina", "Información..");
                }
                else if (Direccion.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar dirección", "Información..");
                }
                else if (Contrasenia.Trim() == "" || Confirmacion.Trim() == "")
                {
                    MessageBox.Show("Verifique contraseña", "Información..");
                }
            }
            else if (Contrasenia.Trim() != Confirmacion.Trim())
            {
                MessageBox.Show("Verifique contraseña", "Información..");
            }
            else if(Contrasenia == Confirmacion)
            {
                acciones.AlmacenarComoPrimero();
                ContraseñaEncriptada = password.Encriptar(Contrasenia);
                acciones.PrimerRegistro(Nombre.ToLower(), Direccion, Telefono, Celular, Oficina, Ciudad, CP, Sexo, ContraseñaEncriptada);
                MessageBox.Show("No olvide su contraseña ya que es única", "Bienbenido Administrador");
                FormBienvenida bienbenido = new FormBienvenida();
                bienbenido.Show();
                this.Hide();
            }
        }
    }
}
