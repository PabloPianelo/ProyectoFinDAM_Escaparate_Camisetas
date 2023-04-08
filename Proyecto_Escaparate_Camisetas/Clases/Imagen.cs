using System;
using System.Windows.Media.Imaging;

namespace Proyecto_Escaparate_Camisetas.Clases {
    class Imagen {

        String nombre, colorCamiseta;
        byte[] img_Imagen;
        long idUsuario;
        System.Windows.Media.Imaging.BitmapImage ImageData;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ColorCamiseta { get => colorCamiseta; set => colorCamiseta = value; }
        public byte[] Img_Imagen { get => img_Imagen; set => img_Imagen = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
        public BitmapImage ImageData1 { get => ImageData; set => ImageData = value; }
    }
}
