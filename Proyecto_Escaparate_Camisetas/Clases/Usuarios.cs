using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escaparate_Camisetas.Clases
{
    class Usuarios
    {
        int idUsuario;
        String nombre, contraseña;
        Boolean rol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Rol { get => rol; set => rol = value; }
    }
}
