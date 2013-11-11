using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Votaciones
{
    class Password
    {
        public String Encriptar(String Password)
        {
            String PasswordFinal = "";
            byte[] Encriptado = Encoding.Unicode.GetBytes(Password);//obtiene bytes de cadena
            PasswordFinal = Convert.ToBase64String(Encriptado);
            return PasswordFinal;
        }

        public String Desencriptar(String Password)
        {
            String resultado = "";
            byte[] Desencriptado = Convert.FromBase64String(Password);//obtiene en base64
            resultado = Encoding.Unicode.GetString(Desencriptado);//hace string
            return resultado;
        }
    }
}
