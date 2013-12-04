using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace Votaciones
{
    public partial class FormCorreo : Form
    {
        public FormCorreo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress(txtPara.Text));
            msg.From = new MailAddress(txtDe.Text);
            msg.Subject = txtAsunto.Text;
            msg.Body = "El contenido del mensaje";

            SmtpClient clienteSmtp = new SmtpClient("WIN02");

            clienteSmtp.Credentials =
            new NetworkCredential("usuario", "clave");

            try
            {
                clienteSmtp.Send(msg);
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }


    }
}
