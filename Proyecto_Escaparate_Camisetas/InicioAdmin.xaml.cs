﻿using System.Windows;

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
        private void btn5_Click(object sender, RoutedEventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Escaparate_Copy_Click(object sender, RoutedEventArgs e)
        {
            ControladorCamiseta administrador = new ControladorCamiseta();
            administrador.Show();
            this.Close();
        }

        private void Escaparate_Copy1_Click(object sender, RoutedEventArgs e)
        {
            ControladorImagen administrador = new ControladorImagen();
            administrador.Show();
            this.Close();
        }
    }
}
