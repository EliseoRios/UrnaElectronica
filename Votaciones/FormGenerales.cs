using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Drawing.Imaging;

namespace Votaciones
{
    public partial class FormGenerales : Form
    {
        public FormGenerales()
        {
            InitializeComponent();
            //1350*725
        }

        Acciones acciones = new Acciones();
        String Direccion;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de imagen|*.jpg|*.png|*.gif";

            BuscarImagen.InitialDirectory = @"C:\\Documents\Images";

            if(BuscarImagen.ShowDialog()==DialogResult.OK)
            {
                this.Direccion = BuscarImagen.FileName;
                this.pbLogo.ImageLocation = this.Direccion;

                Image imagen = new Bitmap(Direccion);
            }
        }

        private void btnIngresoCandidatos_Click(object sender, EventArgs e)
        {
            FormCandidatos forma5 = new FormCandidatos();
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

        public byte[] ConvertirAByte(Image Imagen, ImageFormat FormatoImagen)
        {
            byte[] ImagenByte;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Imagen.Save(ms, FormatoImagen);
                    ImagenByte = ms.ToArray();
                }
            }
            catch (Exception) 
            { 
                throw; 
            }

            return ImagenByte;
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (txtPartidos.Text.Trim() != null)
            {
                acciones.GuardadCargo(txtPartidos.Text);
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            acciones.GuardarFecha(txtFecha.Text);
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            String Partido = txtPartidos.Text;

            if (Partido.Trim() != "")
            {
               
               label4.Text = Direccion;
               acciones.GuardarPartido(Partido, label4.Text);
            }
            else
            {
                MessageBox.Show("Agregue nombre del partido","No valido..");
            }

        }
    }
}
