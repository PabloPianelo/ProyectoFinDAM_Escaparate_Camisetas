using System;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para InicioUsuario.xaml
    /// </summary>
    public partial class InicioUsuario : Window {

        String dato;
        public InicioUsuario() {
            InitializeComponent();
        }

        public InicioUsuario(string dato) {
            InitializeComponent();
            this.dato = dato;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            AdministradorImagen imagen = new AdministradorImagen(dato);
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
