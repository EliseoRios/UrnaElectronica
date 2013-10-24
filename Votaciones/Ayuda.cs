using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Votaciones
{
    public partial class FormAyuda : Form 
    {
        Acciones acciones = new Acciones();
        MySqlDataReader Leer;

        public FormAyuda()
        {
            InitializeComponent();
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            acciones.IncisoAyuda();
            this.Leer = acciones.Leer;

            while(Leer.Read())
            {
                txtIncidencias.Items.Add(Leer["nombre"].ToString());
            }
            txtIncidencias.SelectedIndex = 1;
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            //Object Incidencia = txtIncidencias.SelectedItem;
            int NumeroInciso = txtIncidencias.SelectedIndex;
            acciones.CantidadIncidencias(NumeroInciso);
            acciones.TextoAyuda(NumeroInciso+1);
            
            while(acciones.Leer.Read())
            {
                txtSolucion.Text = acciones.Leer["solucion"].ToString(); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}  