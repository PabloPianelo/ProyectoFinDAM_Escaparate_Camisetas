using System;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window {


        public Login() {
            InitializeComponent();


        }
       
      


        private void Button_Click(object sender, RoutedEventArgs e) {
            Registro registro = new Registro();
            registro.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

           String nombres = nombre.Text;

           
          String pas = pass.Password;

            
            try {
               

                Registro_Login.Controlador controlador = new Registro_Login.Controlador();
                BD.Modelo modelo = new BD.Modelo();
                String respuesta = controlador.ctrlLoging(nombres, pas);
                if (respuesta.Length > 0) {

                    MessageBox.Show(respuesta);
                } else if (modelo.adminorUsuario(nombres).Equals("1")) {

                    Singleton.RepositorioAplicacion.Instance.Nombre = nombres;
                    InicioAdmin admin = new InicioAdmin();
                    admin.Show();
                    this.Close();
                } else {
                    Singleton.RepositorioAplicacion.Instance.Nombre = nombres;
                    InicioUsuario usuario = new InicioUsuario();
                    usuario.Show();
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }






        }





    }
}
