using Microsoft.Win32;
using System;
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
        String dato;

        public AdministradorCamisetas(String dato) {

            InitializeComponent();
            this.dato = dato;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

     
          
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JPG (*.JPG)|*.JPG|Archivos PNG (*.PNG)|*.PNG";

            if (openFileDialog.ShowDialog() == true) {
                Uri uri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(uri);
                System.Drawing.Image newImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                converterDemo(newImage);




            }
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








            if (modelo.existeUsuario(dato)) {
                long id_camiseta = modelo.insertarCamiseta(camiseta);
                long id_usuario = modelo.idUsuario(dato);
                Console.WriteLine(id_usuario);
                Console.WriteLine(id_camiseta+" camiseta");
                modelo.insertarCamisetas_Usuarios(id_usuario, id_camiseta);
               // modelo.insertarCamisetas_Imagenes1(id_camiseta);//duda

                MessageBox.Show("Camiseta insertada");

            } else {
                MessageBox.Show("Error");
               
            }







        }

    }
}
