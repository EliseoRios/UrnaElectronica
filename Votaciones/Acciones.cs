using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Votaciones
{
    class Acciones : Conexion
    {
        public MySqlDataReader Leer;

        public void IncisoAyuda()
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM incidentes;";
            this.Comando = new MySqlCommand(Sql,this.Con);
            Leer = Comando.ExecuteReader();
        }

        public void TextoAyuda(int NumeroInciso)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM incidentes WHERE id='"+NumeroInciso+"'";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = this.Comando.ExecuteReader();
        }

        public void CantidadIncidencias(int NumeroInciso)
        {
            int Cantidad = 0;
            String Nombre="";
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM incidentes WHERE id='"+NumeroInciso+"';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
            
            while(Leer.Read())
            {
                Nombre = Leer["nombre"].ToString();
                Cantidad = int.Parse(Leer["cantidad"].ToString());
            }

            Cantidad = Cantidad + 1;

            if (Cantidad <= 2)
            {
                String Sql2 = "UPDATE incidentes SET cantidad='" + Cantidad + "' WHERE id='" + NumeroInciso + "'";
                this.Comando = new MySqlCommand(Sql2, this.Con);
                this.Comando.ExecuteNonQuery();
            }
            else
            {
                String Sql2 = "UPDATE incidentes SET cantidad='" + Cantidad + "' WHERE id='" + NumeroInciso + "'";
                this.Comando = new MySqlCommand(Sql2, this.Con);
                this.Comando.ExecuteNonQuery();

                String Sql3 = "INSERT INTO problemas (nombre,cantidad,fecha_inicio) VALUES ('"+Nombre+"','"+Cantidad+"',now()) id='" + NumeroInciso + "'";
                this.Comando = new MySqlCommand(Sql3, this.Con);
                this.Comando.ExecuteNonQuery();
            }
        }

        private void Inicializar()
        {
            this.Comando = null;
            this.Leer = null;
        }
    }
}