﻿using System;
using System.Windows.Media.Imaging;

namespace Proyecto_Escaparate_Camisetas.Clases {
    class Camiseta {

        String nombre, colorCamiseta;
        System.Windows.Media.Imaging.BitmapImage ImageData;
        byte[] img;

        public Camiseta(System.Windows.Media.Imaging.BitmapImage ImageData) {


            this.ImageData = ImageData;
        }
        public Camiseta() {


        }



       
        public string ColorCamiseta { get => colorCamiseta; set => colorCamiseta = value; }
        public byte[] Img { get => img; set => img = value; }
        public string Nombre { get => nombre; set => nombre = value; }



        public BitmapImage ImageData1 { get => ImageData; set => ImageData = value; }
    }
}
