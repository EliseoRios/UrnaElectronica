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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormGenerales forma4 = new FormGenerales();
            forma4.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro que desea borrar todos los registros.\nSI LOS BORRA NO PODRAN RECUPERARSE.", "Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if(confirmacion==DialogResult.Yes)
            {
                Acciones acciones = new Acciones();
                acciones.EliminarUrna();
                
                Application.Exit();
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();
            ver.MostrarNombre("RESULTADOS LOCALES");
            ver.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBienvenida bienbenida = new FormBienvenida();
            bienbenida.Show();
            this.Close();
        }
    }
}
