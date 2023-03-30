using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;




namespace Proyecto_Escaparate_Camisetas
{
    /// <summary>
    /// Lógica de interacción para AdministradorCamisetas.xaml
    /// </summary>
    public partial class AdministradorCamisetas : Window
    {
        Clases.Camiseta camiseta = new Clases.Camiseta();

        public AdministradorCamisetas()
        {
           
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PNG (*.PNG)|*.PNG|Archivos JPG (*.JPG)|*.JPG";

            if (openFileDialog.ShowDialog() == true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(uri);
                System.Drawing.Image newImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                converterDemo(newImage);




            }
        }

        public static byte[] converterDemo(System.Drawing.Image x)
        {
            System.Drawing.ImageConverter _imageConverter = new System.Drawing.ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            BD.Modelo modelo = new BD.Modelo();
            camiseta.Nombre = nombre.Text;
            camiseta.ColorCamiseta = "blanco";

            //meter el usuario en el controlador que devuelba el usuario 

            //meterlo en camiseta_user y imagen

            //paginador img

            modelo.insertarCamiseta(camiseta);



        }

    }
}
