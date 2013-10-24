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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4();
            forma4.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro que desea borrar todos los registros.\nSI LOS BORRA NO PODRAN RECUPERARSE.", "Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if(confirmacion==DialogResult.Yes)
            {
                MessageBox.Show("Borrado exitoso", "Operación Realizada", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();
            ver.MostrarNombre("RESULTADOS LOCALES");
            ver.Show();
        }
    }
}
