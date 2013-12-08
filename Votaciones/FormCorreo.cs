using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Net;
using System.Net.Mail;

namespace Votaciones
{
    public partial class FormCorreo : Form
    {
        FormAdministrador admin = new FormAdministrador();

        public FormCorreo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean Enviado = EnviarGmail();

            if (Enviado)
            {
               DialogResult Enviados = MessageBox.Show("Correo enviado", "Exito");
                if (Enviados == DialogResult.OK)
                {
                    FormAdministrador admin = new FormAdministrador();
                    admin.Show();
                    this.Dispose();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Error al enviar", "Falló..");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            admin.Show();
        }

        private Boolean EnviarGmail()
        {
            Boolean Enviado = true;

            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress(txtPara.Text));
            msg.From = new MailAddress(txtDe.Text);
            msg.Subject = txtAsunto.Text;
            msg.Body = txtVotos.Text;

            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.Host = "smtp.gmail.com";
            clienteSmtp.Port = 587;
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;

            clienteSmtp.Credentials =
            new NetworkCredential(txtDe.Text, txtContraseña.Text);

            try
            {
                clienteSmtp.Send(msg);
                Enviado = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No envió..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Enviado = false;
            }
            return Enviado;
        }

        private void FormCorreo_Load(object sender, EventArgs e)
        {
            AccionesVotocs AccionesVoto = new AccionesVotocs();
            AccionesVoto.ContarVotos();

            if (AccionesVoto.resultado.IsCompleted)
            {
                MessageBox.Show("Los resultados se han copletado", "Cargando..");
            }
            else
            {
                MessageBox.Show("Espere la carga de resultados..", "Cargando..");
                AccionesVoto.Leer = AccionesVoto.Commando.EndExecuteReader(AccionesVoto.resultado);

                try
                {
                    txtVotos.AppendText("Nombre\t\tCargo\t\t\tPartido\t\tVotos\n");

                    while (AccionesVoto.Leer.Read())
                    {
                        txtVotos.AppendText(AccionesVoto.Leer.GetString(0) + "\t\t" + AccionesVoto.Leer.GetString(1) + "\t\t" + AccionesVoto.Leer.GetString(2) + "\t\t" + AccionesVoto.Leer.GetInt32(3)+"\n");
                    }
                }
                finally
                {
                   // AccionesVoto.Commando.Dispose();
                }
            }
        }
    }
}
