using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escaparate_Camisetas.Clases
{
    class Imagen
    {

        String nombre, colorCamiseta;
        byte[] img_Imagen;
        int idUsuario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ColorCamiseta { get => colorCamiseta; set => colorCamiseta = value; }
        public byte[] Img_Imagen { get => img_Imagen; set => img_Imagen = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
