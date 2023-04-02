using System;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para InicioAdmin.xaml
    /// </summary>
    public partial class InicioAdmin : Window {


        String dato;
        public InicioAdmin() {

            InitializeComponent();
        }
        public InicioAdmin(String dato) {

            InitializeComponent();
            this.dato = dato;
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            
            AdministradorUsuarios admin = new AdministradorUsuarios();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            AdministradorCamisetas administrador = new AdministradorCamisetas(dato);
            administrador.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            AdministradorImagen imagen = new AdministradorImagen(dato);
            imagen.Show();
            this.Close();
        }
    }
}
