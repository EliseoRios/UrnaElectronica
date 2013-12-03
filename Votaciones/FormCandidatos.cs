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
            FormNumeros VerCandidatos = new FormNumeros();
            VerCandidatos.MostrarNombre("LISTA DE CANDIDATOS");
            VerCandidatos.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNumeros VerPartidos = new FormNumeros();
            VerPartidos.MostrarNombre("LISTA DE PARTIDOS");
            VerPartidos.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNumeros VerCargos = new FormNumeros();
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
            FormNumeros VerTodos = new FormNumeros();
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

            if (Nombre.Trim() != "")
            {
                acciones.GuardarCandidato(Nombre, Cargo, Partido, Descripcion);
                FormCandidatos_Load(sender, e);
            }
            else
            {
                MessageBox.Show("El nombre esta vacio","Aviso..");
            }

            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void FormCandidatos_Load(object sender, EventArgs e)
        {
            CargarDatosGenerales();
            CargarCandidatos();
        }

        private void CargarDatosGenerales()
        {
            acciones.RegistrosGeneralesCargos();

            while (acciones.Leer.Read())
            {
                txtCargo.Items.Add(acciones.Leer["Nombre"]);
            }

            acciones.RegistrosGeneralesPartidos();

            while (acciones.Leer.Read())
            {
                txtPartido.Items.Add(acciones.Leer["nombre"]);
            }

            acciones.RegistrosGeneralesPeriodos();

            while (acciones.Leer.Read())
            {
                txtPeriodo.Items.Add(acciones.Leer["Duracion"]);
            }
        }

        private void CargarCandidatos()
        {
            acciones.CandidatosRegistrados();

            txtMostrar.Items.Clear();
            while(acciones.Leer.Read())
            {
                txtMostrar.Items.Add("CANDIDATO "+acciones.Leer["Id"]+" ("+acciones.Leer["Cargo"]+")");
                txtMostrar.Items.Add(acciones.Leer["Nombre"]);
                txtMostrar.Items.Add(acciones.Leer["Cargo"]);
                txtMostrar.Items.Add(acciones.Leer["Partido"]);
                txtMostrar.Items.Add(acciones.Leer["Descripcion"]);
                txtMostrar.Items.Add("");
            }
        }

        private void páginaSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormGenerales generales = new FormGenerales();
            generales.Show();
            this.Close();
        }
    }
}
