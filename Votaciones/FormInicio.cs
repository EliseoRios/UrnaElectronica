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
        public FormInicio()
        {
            InitializeComponent();
            //Ayuda a = new Ayuda();
            //a.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormAyuda forma2 = new FormAyuda();
            forma2.Show();
        }
    }
}
