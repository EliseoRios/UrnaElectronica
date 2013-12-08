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
                MessageBox.Show("Correo enviado", "Exito");
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
            msg.Body = "Mensaje de prueba enviado";

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

            while(AccionesVoto.Leer.Read())
            {
                for (int i = 0; i < AccionesVoto.Leer.FieldCount; i++)
                {
                  String linea = AccionesVoto.Leer.GetValue(i).ToString();
                  txtVotos.AppendText(linea);
                }
            }
            /*int count = 0;
            while (!AccionesVoto.resultado.IsCompleted)
            {
                count += 1;
                txtVotos.AppendText("Waiting ("+count+")");
                
                System.Threading.Thread.Sleep(100);
            }*/
        }
    }
}
