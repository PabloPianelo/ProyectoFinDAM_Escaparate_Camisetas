using System;

namespace Proyecto_Escaparate_Camisetas.Clases {
    class Camiseta {

        String nombre, colorCamiseta;
        byte[] img;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ColorCamiseta { get => colorCamiseta; set => colorCamiseta = value; }
        public byte[] Img { get => img; set => img = value; }
    }
}
