using System;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window {
        public Registro() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Clases.Usuarios usuario = new Clases.Usuarios();
            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = txtPass.Password;




            try {

                Registro_Login.Controlador controlador = new Registro_Login.Controlador();

                string respuesta = controlador.ctrRegistro(usuario);

                if (respuesta.Length > 0) {
                    MessageBox.Show(respuesta);
                } else {
                    MessageBox.Show("Usuario reguistrado");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

