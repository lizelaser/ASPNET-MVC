using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Constante
    {
        public static class Rol
        {
            // sincronizado con la base de datos
            public const string Administrador = "SA";
            public const string Secretaria = "SE";
            public const string Coordinador = "CO";
            public const string Direccion = "DI";
        }
        public static class ValorTabla
        {
            // sincronizado con la base de datos
            public const int TipoPersonal = 1;
        }
        public static class Menu
        {
            public static List<string> Listar(string rol)
            {
                var mnuAdministrador = new List<string> { "Configuracion", "Usuario", "Personal", "Alumno", "Matricula", "Pagos" };
                var mnuSecretaria = new List<string> { "Alumno", "Personal" };
                var mnuCoordinador = new List<string> { "Personal" };
                var mnuDireccion = new List<string> { "Admision" };
                switch (rol)
                {
                    case Rol.Administrador: return mnuAdministrador;
                    case Rol.Secretaria: return mnuSecretaria;
                    case Rol.Coordinador: return mnuCoordinador;
                    case Rol.Direccion: return mnuDireccion;
                    default: return null;
                }
            }
        }
    }
}
