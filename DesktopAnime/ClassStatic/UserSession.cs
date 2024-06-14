using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAnime.ClassStatic
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string Rol { get; set; }
    }
}

//Porque una clase estatica?
//Una de las formas más comunes y efectivas es usar
//una clase estática o singleton para almacenar la
//información del usuario, de modo que esta información
//pueda ser accesible desde cualquier parte de la aplicación.