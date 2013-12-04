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
            FormIdAdmin admin = new FormIdAdmin();
            admin.Show();
            this.Close();
        }

        private void btnVotante_Click(object sender, EventArgs e)
        {
            String Codigo = txtCodigo.Text;
            Boolean acceso = acciones.IngresoCiudadano(Codigo);
        }
    }
}