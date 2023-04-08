using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para InicioUsuario.xaml
    /// </summary>
    public partial class InicioUsuario : Window {


        public InicioUsuario() {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e) {
            AdministradorImagen imagen = new AdministradorImagen();
            imagen.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Escaparate escaparate = new Escaparate();
            escaparate.Show();
            this.Close();
        }
    }
}
