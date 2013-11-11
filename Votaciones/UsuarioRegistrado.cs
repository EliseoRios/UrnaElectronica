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
    public partial class UsuarioRegistrado : Form
    {
        public UsuarioRegistrado()
        {
            InitializeComponent();
        }

        private void UsuarioRegistrado_Load(object sender, EventArgs e)
        {

        }
        Acciones acciones = new Acciones();
        FormAyuda ayuda = new FormAyuda();

        private void button1_Click(object sender, EventArgs e)
        {
            acciones.SiExiste(txtNombre.Text,txtTelefono.Text);
            ayuda.nombre = txtNombre.Text.ToString();
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPerfil perfil = new FormPerfil();
            this.Dispose();
            perfil.Show();
        }
    }
}
