using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 

namespace Votaciones
{
    public partial class FormNumeros : Form
    {
        String NombreVista="";

        public FormNumeros()
        {
            InitializeComponent();
        }

        public void MostrarNombre(String Nombre)
        {
            NombreVista = Nombre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormAdministrador administrador = new FormAdministrador();
            administrador.Show();
            this.Close();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCandidatos candidatos = new FormCandidatos();
            candidatos.Show();
            this.Close();
        }

        private void cargosYPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerales generales = new FormGenerales();
            generales.Show();
            this.Close();
        }

        private void menúAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrador admin = new FormAdministrador();
            admin.Show();
            this.Close();
        }

        private void páginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Close();
        }

        private void páginaSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int aleatorios;

            for (int i = 0; i <= int.Parse(txtCantidad.Text);i++ )
            {
                aleatorios = random.Next(200, 80000);
            }
        }

        public void generarPDF()
        {

        }
    }
}
