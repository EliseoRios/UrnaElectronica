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
using System.Collections;

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
            }
        }

        private void btnIngresoCandidatos_Click(object sender, EventArgs e)
        {
            FormCandidatos forma5 = new FormCandidatos();
            forma5.Show();
            this.Close();
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
            if (txtCargos.Text.Trim() != "")
            {
                acciones.GuardadCargo(txtCargos.Text);
                txtCargos.Text = "";
            }

            FormGenerales_Load(sender, e);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text.Trim() != "")
            {
             acciones.GuardarFecha(txtFecha.Text);
             txtFecha.Text = "";
             FormGenerales_Load(sender, e);
            }
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            String Partido = txtPartidos.Text;

            if (Partido.Trim() != "")
            {
                String letra = "";
                String url = "";

                if(pbLogo.Image != null)
                {
                 int i = 0;
                 for (i = 0; i < Direccion.Length; i++ )
                 {
                     letra = Direccion.Substring(i,1);

                     if (letra == "\\")
                     {
                         url = url + letra + "\\";
                     }
                     else
                     {
                         url = url + letra;
                     }
                 }
                }

                acciones.GuardarPartido(Partido, url);

                txtPartidos.Text = "";
                pbLogo.Image = null;

                FormGenerales_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Agregue nombre del partido","No valido..");
            }

        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCandidatos forma5 = new FormCandidatos();
            forma5.Show();
            this.Close();
        }

        private void menúAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrador administrador = new FormAdministrador();
            administrador.Show();
            this.Close();
        }

        private void páginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Close();
        }

        private void FormGenerales_Load(object sender, EventArgs e)
        {
            txtMostrar.Items.Clear();
            txtMostrar.Items.Add("LISTA DE CARGOS");
            acciones.RegistrosGeneralesCargos();

            while (acciones.Leer.Read())
            {
                String Cargo = acciones.Leer["Nombre"].ToString();
                txtMostrar.Items.Add(Cargo);
            }

            txtMostrar.Items.Add("\n");
            txtMostrar.Items.Add("LISTA DE PERIODOS");
            acciones.RegistrosGeneralesPeriodos();

            while (acciones.Leer.Read())
            {
                String Periodos = acciones.Leer["Duracion"].ToString();
                txtMostrar.Items.Add(Periodos);
            }

            txtMostrar.Items.Add("\n");
            txtMostrar.Items.Add("LISTA DE PARTIDOS");
            acciones.RegistrosGeneralesPartidos();

            while (acciones.Leer.Read())
            {
                String Partidos = acciones.Leer["nombre"].ToString();
                txtMostrar.Items.Add(Partidos);
            }
        }

        private void páginaSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAdministrador admin = new FormAdministrador();
            admin.Show();
            this.Close();
        }


    }
}
