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

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para Escaparate.xaml
    /// </summary>
    public partial class Escaparate : Window {
        public Escaparate() {
            InitializeComponent();
            this.LvCamisetas.ItemsSource = new Clases.Camiseta[] //metodo modelo //arry camisetas 

        {
            new Clases.Camiseta{Nombre="Movie 1", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\camisetaBlanca.jpg")},
            new Clases.Camiseta{Nombre="Movie 2", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\f2.jpg")},
            new Clases.Camiseta{Nombre="Movie 3", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\f2.jpg")},
            new Clases.Camiseta{Nombre="Movie 4", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\f.jpg")},
            new Clases.Camiseta{Nombre="Movie 5", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\f.jpg")},
            new Clases.Camiseta{Nombre="Movie 6", ImageData1=LoadImage("C:\\Users\\javie\\Desktop\\img\\camisetaBlanca.jpg")}
        };
        }

        private BitmapImage LoadImage(string filename) {
            return new BitmapImage(new Uri( filename));
        }

        public BitmapImage ToImage(byte[] array) {
            using (var ms = new System.IO.MemoryStream(array)) {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad; // here
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }
    }
}
