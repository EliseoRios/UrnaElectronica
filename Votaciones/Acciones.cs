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
        public String IdAdministrador = "";

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
            String CadenaCantidad = "";

            this.AbrirConexion();
            this.Inicializar();

            String Sql = "SELECT * FROM incidentes WHERE id='"+NumeroInciso+"';";
            this.Comando = new MySqlCommand(Sql, this.Con);
            this.Leer = Comando.ExecuteReader();
            
            while(Leer.Read())
            {
                Nombre = Leer["nombre"].ToString();
                CadenaCantidad = Leer["cantidad"].ToString();
                MessageBox.Show(CadenaCantidad,"CantidadCadena");
            }

            if(CadenaCantidad == "")
            {
                CadenaCantidad = "0";
            }

            Cantidad = Int32.Parse(CadenaCantidad);
            Cantidad = Cantidad+1;

            if (Cantidad <= 2)
            {
                this.AbrirConexion();
                String Sql2 = "UPDATE incidentes SET cantidad='" + Cantidad + "' WHERE id='" + NumeroInciso + "'";
                this.Comando = new MySqlCommand(Sql2, this.Con);
                this.Comando.ExecuteNonQuery();
                this.CerrarConexion();
            }
            else
            {
                this.AbrirConexion();
                String Sql2 = "UPDATE incidentes SET cantidad='" + Cantidad + "' WHERE id='" + NumeroInciso + "'";
                this.Comando = new MySqlCommand(Sql2, this.Con);
                this.Comando.ExecuteNonQuery();
                this.CerrarConexion();

                this.AbrirConexion();
                String Sql3 = "INSERT INTO problemas (nombre,cantidad,fecha_inicio) VALUES ('"+Nombre+"','"+Cantidad+"',now())";
                this.Comando = new MySqlCommand(Sql3, this.Con);
                this.Comando.ExecuteNonQuery();
                this.CerrarConexion();
            }
        }

        public void ClienteIncidentes(String Nombre,String Direccion, String Telefono,String Celular,String Oficina,String Ciudad,String CP,String Sexo)
        {
            this.AbrirConexion();
            this.Inicializar();
            String sql = "INSERT INTO cliente (nombre,direccion,telefono,celular,oficina,ciudad,CP,sexo) VALUES ('"+Nombre+"','"+Direccion+"','"+Telefono+"','"+Celular+"','"+Oficina+"','"+Ciudad+"','"+CP+"','"+Sexo+"')";
            Comando = new MySqlCommand(sql,this.Con);
            Comando.ExecuteNonQuery();
            this.CerrarConexion();
        }

        public void SiExiste(String Nombre, String Telefono)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql2 = "SELECT * FROM cliente WHERE nombre='"+Nombre+"' AND telefono='"+Telefono+"'";
            Comando = new MySqlCommand(Sql2,this.Con);
            Leer = Comando.ExecuteReader();

            String id="";
            while(Leer.Read())
            {
               id = Leer["id"].ToString();
            }

            if (id == "")
            {
                FormPerfil perfil = new FormPerfil();
                perfil.Show();
            }
            else
            {
                FormAyuda ayuda = new FormAyuda();
                ayuda.Show();
            }

            this.CerrarConexion();
        }

        public void AlmacenarComoPrimero()
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO primer_registro (numero) VALUES ('1');";
            this.Comando = new MySqlCommand(Sql,this.Con);
            this.Comando.ExecuteNonQuery();
            this.CerrarConexion();
        }

        public void ComprobarSiesPrimero()
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM primer_registro;";
            this.Comando = new MySqlCommand(Sql,this.Con);
            this.Leer = Comando.ExecuteReader();
        }

        public void PrimerRegistro(String Nombre, String Direccion, String Telefono, String Celular, String Oficina, String Ciudad, String CP, String Sexo,String Contrasenia)
        {
            this.AbrirConexion();
            this.Inicializar();
            String sql = "INSERT INTO cliente (nombre,direccion,telefono,celular,oficina,ciudad,CP,sexo,contrasenia) VALUES ('" + Nombre + "','" + Direccion + "','" + Telefono + "','" + Celular + "','" + Oficina + "','" + Ciudad + "','" + CP + "','" + Sexo + "','"+Contrasenia+"')";
            Comando = new MySqlCommand(sql, this.Con);
            Comando.ExecuteNonQuery();
            this.CerrarConexion();
        }

        public void AlmacenarContraseña()
        {
        }

        public bool VerificarContraseña(String Contraseña,String Nombre)
        {
            bool Verificacion = true;
            String Sql="";
            String LecturaId="";
            String LecturaNombre ="";
            this.AbrirConexion();
            this.Inicializar();
            Sql = "SELECT * FROM cliente WHERE contrasenia='"+Contraseña+"';";
            this.Comando = new MySqlCommand(Sql,this.Con);
            this.Leer = Comando.ExecuteReader();

            while(Leer.Read())
            {
                LecturaId = Leer["id"].ToString();
                LecturaNombre = Leer["nombre"].ToString();
            }

            if (LecturaId.Trim() == null || LecturaId.Trim() == "")
            {
                Verificacion = false;
            }
            else if (LecturaNombre != Nombre)
            {
                Verificacion = false;
            }

            return Verificacion;
        }

        private void Inicializar()
        {
            this.Comando = null;
            this.Leer = null;
        }

        public bool IngresoCiudadano(String Codigo)
        {
            Boolean acceso = true;
            /*this.AbrirConexion();
            this.Inicializar();
            String Sql = "SELECT * FROM ciudadanos WHERE folio = "+Codigo+";";
            this.Leer = Comando.ExecuteReader();*/
            return acceso;
        }

        public void GuardadCargo(String Cargo)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO cargos (nombre) VALUES ('"+Cargo+"');";
            this.Comando = new MySqlCommand(Sql, this.Con);
            MessageBox.Show("Cargo: " + Cargo,"Guargado..");
            Comando.ExecuteNonQuery();
        }

        public void GuardarFecha(String Fecha)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO periodo (Duracion) VALUES ('"+Fecha+"');";
            this.Comando = new MySqlCommand(Sql, this.Con);
            MessageBox.Show("Fecha: " + Fecha, "Guardado..");
            Comando.ExecuteNonQuery();
        }

        public void GuardarPartido(String Partido, String Direccion)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO partidos (nombre,logo) VALUES ('"+Partido+"','"+Direccion+"');";
            this.Comando = new MySqlCommand(Sql, this.Con);
            int exito = Comando.ExecuteNonQuery();
            
            if (exito == 1)
            {
                MessageBox.Show("Partido: " + Partido, "Guardado..");
            }
            else
            {
                MessageBox.Show("Fallo al guardar", "No guardo");
            }
        }

        public void GuardarCandidato(String Nombre, String Cargo, String Partido, String Descripcion)
        {
            this.AbrirConexion();
            this.Inicializar();
            String Sql = "INSERT INTO cardidatos (Nombre, Cargo, Partido, Descripcion) VALUES ('"+Nombre+"','"+Cargo+"','"+Partido+"','"+Descripcion+"')";
            this.Comando = new MySqlCommand(Sql,this.Con);
            MessageBox.Show("Candidato: "+Nombre ,"Guardado..");
            this.Comando.ExecuteNonQuery();
        }

        public Hashtable MostrarRegistrosGenerales()
        {
            Hashtable HashRegistros = new Hashtable();

            this.AbrirConexion();
            this.Inicializar();

            String SqlCargo = "";
            this.Comando = new MySqlCommand(SqlCargo,Con);
            this.Leer = this.Comando.ExecuteReader();

            String SqlDuracion = "";
            this.Comando = new MySqlCommand(SqlDuracion, this.Con);
            this.Leer = this.Comando.ExecuteReader();

            String SqlPartido = "";
            this.Comando = new MySqlCommand(SqlPartido, this.Con);
            this.Leer = this.Comando.ExecuteReader();

            this.CerrarConexion();

            return HashRegistros;
        }
    }
}