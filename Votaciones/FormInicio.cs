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
    public partial class FormInicio : Form
    {
        Acciones acciones = new Acciones();
        public FormInicio()
        {
            InitializeComponent();
            //Ayuda a = new Ayuda();
            //a.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            String nombre = "";
            acciones.ComprobarSiesPrimero();

            while (acciones.Leer.Read())
            {
                nombre = acciones.Leer["numero"].ToString();
            }

            if (nombre == "" || nombre.Trim() == null)
            {
                PrimerRegistro primerRegistro = new PrimerRegistro();
                primerRegistro.Show();
                acciones.AlmacenarComoPrimero();

                //Close();
                /*NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(RunPrincipal));
                this.Close();
                NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                NuevoHilo.Start();*/
            }
        }
    }
}
