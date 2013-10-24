using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Votaciones
{
    class Conexion
    {
        protected MySqlConnection Con;
        protected MySqlCommand Comando;

        protected void AbrirConexion()
        {
            this.Con = new MySqlConnection();
            try
            {
                String datos = "Server=localhost;pwd='';Uid=root;Database=urna;";
                this.Con.ConnectionString = datos;
                this.Con.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No conecto", "FALLO");
            }
        }

        protected void CerrarConexion()
        {
            this.Con.Close();
            this.Con = null;
        }
    }
}
