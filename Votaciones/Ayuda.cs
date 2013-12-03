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
        public String nombre;

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
            txtIncidencias.SelectedIndex = 0;

            //txtCliente.Text = nombre;
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath;

            //Object aIncidenci = txtIncidencias.SelectedItem;
            int NumeroInciso = txtIncidencias.SelectedIndex;
            acciones.CantidadIncidencias(NumeroInciso + 1);

            switch (NumeroInciso)
            {
                case 0:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\NO_ENCIENDE_SU_COMPUTADORA.pdf"); 
                    break;

                case 1:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\FALLO_AL_ABRIR_SISTEMA.pdf");
                    break;

                case 2:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\SERVICIO_A_LA_RED.pdf");
                    break;

                case 3:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\NO_SE_ENVIA_CORREO.pdf");
                    break;

                case 4:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\SE_ME_BORRO_LA_BASE_DE_DATOS.pdf");
                    break;

                case 5:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\NO_ACEPTA_CONTRASEÑA.pdf");
                    break;

                case 6:
                    wbSolucion.Url = new Uri(ruta+"\\Incidentes\\NO_INPRIME_CODIGOS_GENERADOS.pdf");
                    break;
                default:  MessageBox.Show("Seleccione su problema","Seleccione..");
                    break;

                /*acciones.TextoAyuda(NumeroInciso+1);
            
                while(acciones.Leer.Read())
                {
                    txtSolucion.Text = acciones.Leer["solucion"].ToString(); 
                }*/
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}  