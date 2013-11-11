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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        Acciones acciones = new Acciones();
        FormAyuda ayuda = new FormAyuda();

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            String Telefono= txtTelefono.Text;
            String Direccion= txtDireccion.Text;
            String Celular = txtCelular.Text;
            String Oficina = txtOficiona.Text;
            String CP = txtCP.Text;
            String Sexo = txtSexo.Text;
            String Ciudad = txtCiudad.Text;
            ayuda.nombre = Nombre;

            acciones.ClienteIncidentes(Nombre,Direccion,Telefono,Celular,Oficina,Ciudad,CP,Sexo);
            FormAyuda Ayuda = new FormAyuda();
            acciones.IdAdministrador = Nombre;
            Ayuda.Show();
            this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UsuarioRegistrado FormRegistrado = new UsuarioRegistrado();
            FormRegistrado.Show();
            this.Dispose();
        }
    }
}
