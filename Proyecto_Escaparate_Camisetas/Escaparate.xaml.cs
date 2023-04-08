using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para Escaparate.xaml
    /// </summary>
    public partial class Escaparate : Window {

        public Escaparate() {
            InitializeComponent();
           
            BD.Modelo modelo = new BD.Modelo();


            //camiseta
            ArrayList arrayList_camiseta = new BD.Modelo().img_Camiseta();
            for (int i = 0; i < arrayList_camiseta.Count; i++) {
                ((Clases.Camiseta)arrayList_camiseta[i]).ImageData1 = ToImage(((Clases.Camiseta)arrayList_camiseta[i]).Img);
               
            }
            this.LvCamisetas.ItemsSource = arrayList_camiseta;

            //img
               ArrayList arrayList_img = new BD.Modelo().img_Imagen(1);

               for (int i = 0; i < arrayList_img.Count; i++) {
                   ((Clases.Imagen)arrayList_img[i]).ImageData1 = ToImage(((Clases.Imagen)arrayList_img[i]).Img_Imagen);

               }
              


               
               //img usuario
               ArrayList arrayList_img_2 = new BD.Modelo().img_Imagen(modelo.idUsuario(Singleton.RepositorioAplicacion.Instance.Nombre));
               for (int i = 0; i < arrayList_img_2.Count; i++) {
                   ((Clases.Imagen)arrayList_img_2[i]).ImageData1 = ToImage(((Clases.Imagen)arrayList_img_2[i]).Img_Imagen);

               }
            arrayList_img.Add(arrayList_img_2);
            this.LvImagenes.ItemsSource = arrayList_img;


        }



        private BitmapImage LoadImage(string filename) {
        return new BitmapImage(new Uri(filename));

    }


    public BitmapImage ToImage(byte[] array) {
        using (var ms = new System.IO.MemoryStream(array)) {
            var image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }

        private void Button_Click(object sender, RoutedEventArgs e) {

            ListBoxItem listBoxItem = (ListBoxItem)LvCamisetas.SelectedItem;
            BitmapImage image = (BitmapImage)listBoxItem.Content;
            Img.Source = image;
        }
    }
}
