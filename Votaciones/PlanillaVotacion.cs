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
    public partial class PlanillaVotacion : Form
    {
        public PlanillaVotacion()
        {
            InitializeComponent();
        }

        AccionesVotocs acciones = new AccionesVotocs();
        int Contador = 1;
        int ContadorSwitch = 1;

        private void PlanillaVotacion_Load(object sender, EventArgs e)
        {
            this.QuitarVisibilidad();

            int CantidadCargos = acciones.CantidadCargos();
            int CantidadCandidatos = acciones.CantidadCandidatos();

            if (Contador <= CantidadCargos)
            {
                String NombreCargo = "";
                acciones.LeerCargo(Contador);

                while (acciones.Leer.Read())
                {
                    NombreCargo = acciones.Leer["Nombre"].ToString();
                }
                lblCargo.Text = NombreCargo.ToUpper();

                for (int i = 0; i < CantidadCandidatos; i++)
                {
                    String Nombre = "";
                    String Cargo = "";
                    String Partido = "";
                    String DireccionImagen = "";

                    acciones.LeerCandidato(i + 1, NombreCargo);

                    while (acciones.Leer.Read())
                    {
                        Nombre = acciones.Leer["Nombre"].ToString();
                        Cargo = acciones.Leer["Cargo"].ToString();
                        Partido = acciones.Leer["Partido"].ToString();
                    }

                    acciones.ImagenPartido(Partido);

                    while (acciones.Leer.Read())
                    {
                        DireccionImagen = acciones.Leer["logo"].ToString();
                    }

                    if (Nombre != "")
                    {
                        this.LlenarPlanilla(ContadorSwitch, Nombre, DireccionImagen, Partido);
                        ContadorSwitch++;
                    }
                }
            }
            else
            {
                DialogResult Saliendo = MessageBox.Show("Agradecemos su participación", "Saliendo..");
                if (Saliendo == DialogResult.OK)
                {
                    FormBienvenida bienbenida = new FormBienvenida();
                    bienbenida.Show();
                    this.Close();
                    this.Dispose();
                }
            }
        }

        String CandidatoSeleccionado;
        private void btnVotar_Click_1(object sender, EventArgs e)
        {
            ContadorSwitch = 1;
            SeleccionCandidato();

            acciones.PartidoSeleccionado(CandidatoSeleccionado);
            String PartidoCandidato ="";

            while(acciones.Leer.Read())
            {
                PartidoCandidato = acciones.Leer["Partido"].ToString();
            }

            acciones.RegistarVoto(CandidatoSeleccionado,lblCargo.Text,PartidoCandidato);

            Contador++;
            PlanillaVotacion_Load(sender, e);
        }

        private void SeleccionCandidato()
        {
            if (rb1.Checked) CandidatoSeleccionado = rb1.Text;
            if (rb2.Checked) CandidatoSeleccionado = rb2.Text;
            if (rb3.Checked) CandidatoSeleccionado = rb3.Text;
            if (rb4.Checked) CandidatoSeleccionado = rb4.Text;
            if (rb5.Checked) CandidatoSeleccionado = rb5.Text;
            if (rb6.Checked) CandidatoSeleccionado = rb6.Text;
            if (rb7.Checked) CandidatoSeleccionado = rb7.Text;
            if (rb8.Checked) CandidatoSeleccionado = rb8.Text;
            if (rb9.Checked) CandidatoSeleccionado = rb9.Text;
            if (rb10.Checked) CandidatoSeleccionado = rb10.Text;
            if (rb11.Checked) CandidatoSeleccionado = rb11.Text;
            if (rb12.Checked) CandidatoSeleccionado = rb12.Text;
            if (rb13.Checked) CandidatoSeleccionado = rb13.Text;
            if (rb14.Checked) CandidatoSeleccionado = rb14.Text;
            if (rb15.Checked) CandidatoSeleccionado = rb15.Text;
        }

        private void LlenarPlanilla(int Posicion, String Nombre, String DireccionImagen,String Partido)
        {
            switch (Posicion)
            {
                case 1:
                    rb1.Visible = true;
                    rb1.Text = Nombre;
                    rb1.Name = Nombre;

                    pb1.Visible = true;
                    pb1.ImageLocation = DireccionImagen;
                    lbl1.Text = Partido;
                    break;

                case 2:
                    rb2.Visible = true;
                    rb2.Text = Nombre;
                    rb2.Name = Nombre;

                    pb2.Visible = true;
                    pb2.ImageLocation = DireccionImagen;
                    lbl2.Text = Partido;
                    break;

                case 3:
                    rb3.Visible = true;
                    rb3.Text = Nombre;
                    rb3.Name = Nombre;

                    pb3.Visible = true;
                    pb3.ImageLocation = DireccionImagen;
                    lbl3.Text = Partido;
                    break;

                case 4:
                    rb4.Visible = true;
                    rb4.Text = Nombre;
                    rb4.Name = Nombre;

                    pb4.Visible = true;
                    pb4.ImageLocation = DireccionImagen;
                    lbl4.Text = Partido;
                    break;

                case 5:
                    rb5.Visible = true;
                    rb5.Text = Nombre;
                    rb5.Name = Nombre;


                    pb5.Visible = true;
                    pb5.ImageLocation = DireccionImagen;
                    lbl5.Text = Partido;
                    break;

                case 6:
                    rb6.Visible = true;
                    rb6.Text = Nombre;
                    rb6.Name = Nombre;

                    pb6.Visible = true;
                    pb6.ImageLocation = DireccionImagen;
                    lbl6.Text = Partido;
                    break;

                case 7:
                    rb7.Visible = true;
                    rb7.Text = Nombre;
                    rb7.Name = Nombre;

                    pb7.Visible = true;
                    pb7.ImageLocation = DireccionImagen;
                    lbl7.Text = Partido;
                    break;

                case 8:
                    rb8.Visible = true;
                    rb8.Text = Nombre;
                    rb8.Name = Nombre;

                    pb8.Visible = true;
                    pb8.ImageLocation = DireccionImagen;
                    lbl8.Text = Partido;
                    break;

                case 9:
                    rb9.Visible = true;
                    rb9.Text = Nombre;
                    rb9.Name = Nombre;

                    pb9.Visible = true;
                    pb9.ImageLocation = DireccionImagen;
                    lbl9.Text = Partido;
                    break;

                case 10:
                    rb10.Visible = true;
                    rb10.Text = Nombre;
                    rb10.Name = Nombre;

                    pb10.Visible = true;
                    pb10.ImageLocation = DireccionImagen;
                    lbl10.Text = Partido;
                    break;

                case 11:
                    rb11.Visible = true;
                    rb11.Text = Nombre;
                    rb11.Name = Nombre;

                    pb11.Visible = true;
                    pb11.ImageLocation = DireccionImagen;
                    lbl11.Text = Partido;
                    break;

                case 12:
                    rb12.Visible = true;
                    rb12.Text = Nombre;
                    rb12.Name = Nombre;

                    pb12.Visible = true;
                    pb12.ImageLocation = DireccionImagen;
                    break;

                case 13:
                    rb13.Visible = true;
                    rb13.Text = Nombre;
                    rb13.Name = Nombre;

                    pb13.Visible = true;
                    pb13.ImageLocation = DireccionImagen;
                    break;

                case 14:
                    rb14.Visible = true;
                    rb14.Text = Nombre;
                    rb14.Name = Nombre;

                    pb14.Visible = true;
                    pb14.ImageLocation = DireccionImagen;
                    break;

                case 15:
                    rb15.Visible = true;
                    rb15.Text = Nombre;
                    rb15.Name = Nombre;

                    pb15.Visible = true;
                    pb15.ImageLocation = DireccionImagen;
                    break;
            }
        }

        private void QuitarVisibilidad()
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            rb10.Visible = false;
            rb11.Visible = false;
            rb12.Visible = false;
            rb13.Visible = false;
            rb14.Visible = false;
            rb15.Visible = false;

            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            pb7.Visible = false;
            pb8.Visible = false;
            pb9.Visible = false;
            pb10.Visible = false;
            pb11.Visible = false;
            pb12.Visible = false;
            pb13.Visible = false;
            pb14.Visible = false;
            pb15.Visible = false;

            lbl1.Text ="";
            lbl2.Text ="";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            lbl13.Text = "";
            lbl14.Text = "";
            lbl15.Text = "";
        }
    }
}
