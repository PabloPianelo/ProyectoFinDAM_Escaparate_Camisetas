using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window {
        public Registro() {
            InitializeComponent();
        }

        public static string GetSHA1(string str) {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e) {
            Clases.Usuarios usuario = new Clases.Usuarios();
            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = GetSHA1(txtPass.Password);




            try {

                Registro_Login.Controlador controlador = new Registro_Login.Controlador();

                string respuesta = controlador.ctrRegistro(usuario);

                if (respuesta.Length > 0) {
                    MessageBox.Show(respuesta);
                } else {
                    MessageBox.Show("Usuario reguistrado");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
          
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

