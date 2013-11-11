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
            String Nombre = txtNombre.Text;
            String Telefono = txtTelefono.Text;
            String Direccion = txtDireccion.Text;
            String Celular = txtCelular.Text;
            String Oficina = txtOficiona.Text;
            String CP = txtCP.Text;
            String Sexo = txtSexo.Text;
            String Ciudad = txtCiudad.Text;
            String Contrasenia = txtContrasenia.Text;
            String Confirmacion = txtConfirmar.Text;


            if (Nombre.Trim() == "" || Oficina.Trim() == "" || Direccion.Trim() == "" || Contrasenia.Trim() == "")
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
                acciones.ClienteIncidentes(Nombre, Direccion, Telefono, Celular, Oficina, Ciudad, CP, Sexo);
            }
            else
            {

            }

            if (Contrasenia.Trim() != Confirmacion.Trim() || Contrasenia.Trim() == "" || Confirmacion.Trim() == "")
            {
               MessageBox.Show("Verifique contraseña","Contraseña..");
            }
        }
    }
}
