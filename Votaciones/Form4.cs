using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Votaciones
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //1350*725
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "Archivos de imagen|*.jpg;*.png;*gif;";
            Imagen.InitialDirectory = "C:\\pictures";

            if (Imagen.ShowDialog()==DialogResult.OK)
            {
                String Direccion = Imagen.FileName;
                this.picLogo.ImageLocation = Direccion;
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnIngresoCandidatos_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            forma5.Show();
        }

        private void registroCandidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer VerCandidatos = new FormVer();
            VerCandidatos.MostrarNombre("LISTA DE CANDIDATOS");
            VerCandidatos.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer VerPartidos = new FormVer();
            VerPartidos.MostrarNombre("LISTA DE PARTIDOS");
            VerPartidos.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer VerCargos = new FormVer();
            VerCargos.MostrarNombre("LISTA DE CARGOS");
            VerCargos.Show();
        }

        private void organizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer VerTodos = new FormVer();
            VerTodos.MostrarNombre("TODOS LOS REGISTROS");
            VerTodos.Show();
        }
    }
}
