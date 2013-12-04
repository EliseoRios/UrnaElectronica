using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections; 

namespace Votaciones
{
    public partial class FormNumeros : Form
    {
        String NombreVista = "";
        Acciones acciones = new Acciones();

        public FormNumeros()
        {
            InitializeComponent();
        }

        public void MostrarNombre(String Nombre)
        {
            NombreVista = Nombre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormAdministrador administrador = new FormAdministrador();
            administrador.Show();
            this.Close();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCandidatos candidatos = new FormCandidatos();
            candidatos.Show();
            this.Close();
        }

        private void cargosYPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerales generales = new FormGenerales();
            generales.Show();
            this.Close();
        }

        private void menúAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrador admin = new FormAdministrador();
            admin.Show();
            this.Close();
        }

        private void páginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Close();
        }

        private void páginaSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int aleatorios = 0;

            if (txtCantidad.Text.Trim() != "")
            {
                int contador = 0;
                acciones.SumarOtraGeneracionNumeros();
                CrearPDF();

                txtLista.Items.Add("\t\tNúmeros Generados");
                txtLista.Items.Add("\n");

                EscribirPDF("\t\tNúmeros Generados");

                for (int i = 0; i < int.Parse(txtCantidad.Text); i++)
                {
                    contador++;
                    aleatorios = random.Next(200, 80000);

                    acciones.GuardarNumerosAleatorios(aleatorios);
                    EscribirPDF("N° " + i + ":\t\t\t\t" + aleatorios.ToString());
                    txtLista.Items.Add("N° "+i+":\t\t"+aleatorios);

                    if (contador == 41)
                    {
                        contador = 0;
                        acciones.SumarOtraGeneracionNumeros();
                        CrearPDF();
                    }
                }

                CerrarPDF();
                FormNumeros_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad de numeros que desea","llene el campo..");
            }
        }

        Document document = new Document();
        String NombreDocumento;

        private void CrearPDF()
        {
            String Cantidad = acciones.CantidadGeneracionNumeros();
            NombreDocumento = "numeros_generados" + Cantidad + ".pdf";
            acciones.GuardarNombrePDF(NombreDocumento);

            PdfWriter.GetInstance(document,
                          new FileStream(NombreDocumento,
                                 FileMode.OpenOrCreate));
        }

        private void EscribirPDF(String Texto)
        {
            document.Open();

            Chunk chunk = new Chunk(Texto,
            FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));

            document.Add(new Paragraph(chunk));
        }

        private void CerrarPDF()
        {
            document.Close();
        }

        private void CambiarFuente()
        {
            Chunk chunk = new Chunk("Texto subrayado",

            FontFactory.GetFont("ARIAL", 12,iTextSharp.text.Font.BOLD));

            document.Add(new Paragraph(chunk));
        }

        private void ImagenEnPDF()
        {
            iTextSharp.text.Image jpg =

             iTextSharp.text.Image.GetInstance(@"C:\...\ghostsandgoblins.jpg");

            jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;

            document.Add(jpg); 
        }

        private void FormNumeros_Load(object sender, EventArgs e)
        {
            acciones.PDFsGenerados();
            txtGenerados.Items.Clear();

            while(acciones.Leer.Read())
            {
               txtGenerados.Items.Add(acciones.Leer["nombre"].ToString());
            }

            if (txtGenerados.Items.Count != 0)
            {
                txtGenerados.SelectedIndex = 0;
            }
        }

        private void btnVerCogigos_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath;
            wbPDF.Url = new Uri(ruta+"\\"+txtGenerados.Text);
        }
    }
}
