using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            openFileDialog.Filter = "Archivos PNG (*.PNG)|*.PNG";

            if (openFileDialog.ShowDialog() == true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(uri);
               // camiseta.Img = img;

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
