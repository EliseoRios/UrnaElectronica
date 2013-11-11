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
    }
}