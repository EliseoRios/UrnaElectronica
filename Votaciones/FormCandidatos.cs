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
    public partial class FormCandidatos : Form
    {
        public FormCandidatos()
        {
            InitializeComponent();
        }

        Acciones acciones = new Acciones();

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

        private void cargosYPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerales Generales = new FormGenerales();
            Generales.Show();
            this.Close();
        }

        private void organizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer VerTodos = new FormVer();
            VerTodos.MostrarNombre("TODOS LOS REGISTROS");
            VerTodos.Show();
        }

        private void menúAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrador admin = new FormAdministrador();
            admin.Show();
            this.Close();
        }

        private void páginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBienvenida bienbenida = new FormBienvenida();
            bienbenida.Show();
            this.Close();
        }

        private void btnCandidato_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            String Cargo = txtCargo.Text;
            String Partido = txtPartido.Text;
            String Descripcion = txtDescripcion.Text;

            acciones.GuardarCandidato(Nombre, Cargo, Partido, Descripcion);

            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void FormCandidatos_Load(object sender, EventArgs e)
        {
            while(true)
            {
              txtCargo.Items.Add("lo que obtenga");
              txtPartido.Items.Add("lo que obtenga");
            }
        }
    }
}
