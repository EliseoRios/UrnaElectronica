using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

namespace Votaciones
{
    class AccionesVotocs : Conexion
    {
        public MySqlCommand Commando;
        public MySqlDataReader Leer;
        public IAsyncResult resultado;

        public int CantidadCargos()
        {
            int Cuantos = 0;

            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT COUNT( * ) FROM cargos";
            this.Comando = new MySqlCommand(Sql, this.Con);
            String Cuanto = Comando.ExecuteScalar().ToString();
            Cuantos = int.Parse(Cuanto);

            return Cuantos;
        }

        public int CantidadCandidatos()
        {
            int Cuantos = 0;

            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT COUNT(*) FROM candidatos";
            this.Comando = new MySqlCommand(Sql, this.Con);
            String Cuanto = Comando.ExecuteScalar().ToString();
            Cuantos = int.Parse(Cuanto);

            return Cuantos;
        }

        public void LeerCandidato(int id, String NombreCargo)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM candidatos where Id ='" + id + "' and Cargo ='" + NombreCargo + "';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void LeerCargo(int id)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM cargos where id='" + id + "';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void ImagenPartido(String NombrePartido)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM partidos where nombre='" + NombrePartido + "';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void PartidoSeleccionado(String candidato)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM candidatos where Nombre='" + candidato + "';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void RegistarVoto(String nombre, String cargo, String partido)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO registros (nombre,cargo,partido) VALUES ('" + nombre + "','" + cargo + "','" + partido + "');";
            this.Comando = new MySqlCommand(Sql, this.Con);
            Comando.ExecuteNonQuery();
        }

        private void Inicializar()
        {
            this.Comando = null;
            this.Leer = null;
        }

        public void ContarVotos()
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT nombre AS Nombre, cargo AS Cargo, partido AS Partido, COUNT( nombre ) AS Cantidad_VOTOS"
                       + " FROM registros WHERE nombre is not null"
                       + " GROUP BY cargo;";
            Commando = new MySqlCommand(Sql, this.Con);
            resultado = Commando.BeginExecuteReader();
        }
    }
}
