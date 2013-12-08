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
            PlanillaVotacion planilla = new PlanillaVotacion();
            planilla.Show();
            this.Close();
            /*String Codigo = txtCodigo.Text;
            Boolean acceso = acciones.IngresoCiudadano(Codigo);

            if (acceso)
            {
                acciones.InhabilitarCodigo(txtCodigo.Text);
                PlanillaVotacion planilla = new PlanillaVotacion();
                planilla.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Código no valido","Error..",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }*/
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}