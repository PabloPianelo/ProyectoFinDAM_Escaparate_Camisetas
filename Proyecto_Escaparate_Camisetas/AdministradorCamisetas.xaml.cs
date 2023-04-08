using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;





namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para AdministradorCamisetas.xaml
    /// </summary>
    public partial class AdministradorCamisetas : Window {
        Clases.Camiseta camiseta = new Clases.Camiseta();


        public AdministradorCamisetas() {

            InitializeComponent();

        }


        private void Button_Click(object sender, RoutedEventArgs e) {



            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JPG (*.JPG)|*.JPG|Archivos PNG (*.PNG)|*.PNG";

            if (openFileDialog.ShowDialog() == true) {
                Uri uri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(uri);
                System.Drawing.Image newImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                converterDemo(newImage);
                camiseta.Img = toByte((BitmapSource)img.Source);



                

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
            camiseta.Nombre = nombre.Text;




            if (rbAzul.IsChecked == true)
                camiseta.ColorCamiseta = "Azul";
            if (rbBlanco.IsChecked == true)
                camiseta.ColorCamiseta = "Blanco";
            if (rbNegro.IsChecked == true)
                camiseta.ColorCamiseta = "Negro";
            if (rbRojo.IsChecked == true)
                camiseta.ColorCamiseta = "Rojo";








            if (modelo.existeUsuario(Singleton.RepositorioAplicacion.Instance.Nombre)) {
                long id_camiseta = modelo.insertarCamiseta(camiseta);
                long id_usuario = modelo.idUsuario(Singleton.RepositorioAplicacion.Instance.Nombre);
                modelo.insertarCamisetas_Usuarios(id_usuario, id_camiseta);


                MessageBox.Show("Camiseta insertada");

            } else {
                MessageBox.Show("Error");

            }







        }

    }
}
