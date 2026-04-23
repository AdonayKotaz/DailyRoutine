using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRoutine
{
    public static class UsuarioSesion
    {
        // Aquí guardaremos el ID del usuario que logueó correctamente
        public static int IdUsuario { get; set; }
        public static string Correo { get; set; }
        public static void LimpiarSesion()
        {
            IdUsuario = 0;
            Correo = string.Empty;
        }
    }

}
