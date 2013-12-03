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
    public partial class FormBienvenida : Form
    {
        Acciones acciones = new Acciones();

        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdministrador forma3 = new FormAdministrador();
            forma3.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Show();
        }

        private void btnVotante_Click(object sender, EventArgs e)
        {
            String Codigo = txtCodigo.Text;
            Boolean acceso = acciones.IngresoCiudadano(Codigo);
        }
    }
}
