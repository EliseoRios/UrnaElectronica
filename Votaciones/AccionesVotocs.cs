using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Votaciones
{
    class AccionesVotocs : Conexion
    {
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
            String Sql = "SELECT * FROM candidatos where Id ='"+id+"' and Cargo ='"+NombreCargo+"';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void LeerCargo(int id)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM cargos where id='"+id+"';";
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

        public void RegistarVoto(String nombre,String cargo,String partido)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO registros (nombre,cargo,partido) VALUES ('"+nombre+"','"+cargo+"','"+partido+"');";
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
            String Sql = "SELECT nombre AS Nombre, COUNT( nombre ) AS Cantidad_VOTOS, cargo AS Cargo, partido AS Partido"
                       + "FROM registros WHERE nombre is not null"
                       + "GROUP BY cargo;";
            this.Comando = new MySqlCommand(Sql,this.Con);
            resultado = Comando.BeginExecuteReader();
            Leer = Comando.EndExecuteReader(resultado);

            /*int count = 0;
            while (!resultado.IsCompleted)
            {
                count += 1;
                Console.WriteLine("Waiting ({0})", count);
                // Wait for 1/10 second, so the counter 
                // does not consume all available resources  
                // on the main thread.
                System.Threading.Thread.Sleep(100);
            }
            
            DisplayResults(Leer);*/
        }

        private static void DisplayResults(MySqlDataReader leer)
        {
            // Display the data within the reader. 
            while (leer.Read())
            {
                // Display all the columns.  
                for (int i = 0; i < leer.FieldCount; i++)
                    Console.Write("{0} ", leer.GetValue(i));
                Console.WriteLine();
            }
        }
    }
}
