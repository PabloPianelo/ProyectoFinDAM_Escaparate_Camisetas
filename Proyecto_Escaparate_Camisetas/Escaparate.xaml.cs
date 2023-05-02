using System;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
            Console.WriteLine("DATO "+arrayList_img.Count);
               for (int i = 0; i < arrayList_img.Count; i++) {
                   ((Clases.Imagen)arrayList_img[i]).ImageData1 = ToImage(((Clases.Imagen)arrayList_img[i]).Img_Imagen);

               }
              


               
               //img usuario
               ArrayList arrayList_img_2 = new BD.Modelo().img_Imagen(modelo.idUsuario(Singleton.RepositorioAplicacion.Instance.Nombre));
               for (int i = 0; i < arrayList_img_2.Count; i++) {
                   ((Clases.Imagen)arrayList_img_2[i]).ImageData1 = ToImage(((Clases.Imagen)arrayList_img_2[i]).Img_Imagen);
                arrayList_img.Add(arrayList_img_2[i]);
            }
            
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


        BD.Modelo modelo = new BD.Modelo();
        Clases.Imagen imagenSelecionada= new Clases.Imagen();
        Clases.Camiseta camisetaSelecionada = new Clases.Camiseta();
        private void LvCamisetas_SelectionChanged(object sender, SelectionChangedEventArgs e) {

          

            camisetaSelecionada = (Clases.Camiseta)LvCamisetas.SelectedItem;

            camisetaSelecionada= modelo.porImg_Camiseta(camisetaSelecionada.Img);

           


        
                if (imagenSelecionada.ColorCamiseta != camisetaSelecionada.ColorCamiseta) {
                    Camiseta.Source = ((Clases.Camiseta)LvCamisetas.SelectedItem).ImageData1;
                } else {
                MessageBox.Show("La imagen o la camiseta no son compatibles");
            }
           
           
           

        }

        private void LvImagenes_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            imagenSelecionada = (Clases.Imagen)LvImagenes.SelectedItem;
            imagenSelecionada = modelo.porImg_Imagen(imagenSelecionada.Img_Imagen);

            
                if (imagenSelecionada.ColorCamiseta != camisetaSelecionada.ColorCamiseta) {
                    Img.Source = ((Clases.Imagen)LvImagenes.SelectedItem).ImageData1;
                } else {
                MessageBox.Show("La imagen o la camiseta no son compatibles");

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

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (camisetaSelecionada != null && imagenSelecionada != null) {



                BD.Modelo modelo = new BD.Modelo();
                long idimagen = modelo.idImagen(imagenSelecionada.Nombre);
                long idcamiseta = modelo.idCamiseta(camisetaSelecionada.Nombre);
                long idusuario = modelo.idUsuario(Singleton.RepositorioAplicacion.Instance.Nombre);

                modelo.insertarCamisetas_Imagenes_Usuario(idimagen, idcamiseta, idusuario);


               // Singleton.RepositorioAplicacion.Instance.Texto = "El usuario " + Singleton.RepositorioAplicacion.Instance.Nombre+" a pedido la camiseta "+camisetaSelecionada.Nombre+" con la imagen "+imagenSelecionada.Nombre;
               //insertar en bd  con los id de cada uno 
                MessageBox.Show("Información enviada");

            } else {
                MessageBox.Show("La imagen o la camiseta no esta selecionada");
            }
        }
    }
}
