using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para InicioAdmin.xaml
    /// </summary>
    public partial class InicioAdmin : Window {



        public InicioAdmin() {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            AdministradorUsuarios admin = new AdministradorUsuarios();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            AdministradorCamisetas administrador = new AdministradorCamisetas();
            administrador.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            AdministradorImagen imagen = new AdministradorImagen();
            imagen.Show();
            this.Close();
        }
    }
}
