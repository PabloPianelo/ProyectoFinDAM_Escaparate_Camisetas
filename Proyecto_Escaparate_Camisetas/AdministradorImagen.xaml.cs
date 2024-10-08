﻿using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para AdministradorImagen.xaml
    /// </summary>
    public partial class AdministradorImagen : Window {
        Clases.Imagen imagen = new Clases.Imagen();


        public AdministradorImagen() {
            InitializeComponent();
        }

        private void btn5_Click(object sender, RoutedEventArgs e) {


            if (Singleton.RepositorioAplicacion.Instance.Nombre == "admin") {
                InicioAdmin admin = new InicioAdmin();
                admin.Show();
                this.Close();
            } else { 
            InicioUsuario usuario = new InicioUsuario();
              usuario.Show();
            this.Close();
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e) {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JPG (*.JPG)|*.JPG|Archivos PNG (*.PNG)|*.PNG";

            if (openFileDialog.ShowDialog() == true) {
                Uri uri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(uri);
                System.Drawing.Image newImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                converterDemo(newImage);
                imagen.Img_Imagen= toByte((BitmapSource)img.Source);




            }
        }
        public byte[] toByte(BitmapSource img) {

            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(img));
            using (MemoryStream ms = new MemoryStream()) {
                encoder.Save(ms);
                data = ms.ToArray();

            }

            return data;
        }
        public static byte[] converterDemo(System.Drawing.Image x) {
            System.Drawing.ImageConverter _imageConverter = new System.Drawing.ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

            BD.Modelo modelo = new BD.Modelo();
            imagen.Nombre = nombre.Text;




            if (rbAzul.IsChecked == true)
                imagen.ColorCamiseta = "Azul";
            if (rbBlanco.IsChecked == true)
                imagen.ColorCamiseta = "Blanco";
            if (rbNegro.IsChecked == true)
                imagen.ColorCamiseta = "Negro";
            if (rbRojo.IsChecked == true)
                imagen.ColorCamiseta = "Rojo";




            if (modelo.existeUsuario(Singleton.RepositorioAplicacion.Instance.Nombre)) {
                long id_usuario = modelo.idUsuario(Singleton.RepositorioAplicacion.Instance.Nombre);
                imagen.IdUsuario = id_usuario;
                long id_imagen = modelo.insertarImagen(imagen);



                MessageBox.Show("Imagen insertada");

            } else {
                MessageBox.Show("Error");

            }





        }
    }
}
