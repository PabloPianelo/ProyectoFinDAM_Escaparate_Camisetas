using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace Proyecto_Escaparate_Camisetas {
    /// <summary>
    /// Lógica de interacción para AdministradorUsuarios.xaml
    /// </summary>
    public partial class AdministradorUsuarios : Window {
        public AdministradorUsuarios() {
            InitializeComponent();

            BD.ConexionBD conexionBD = new BD.ConexionBD();
            BD.Modelo modelo = new BD.Modelo();

            if (modelo.nombreUsuario(modelo.mensajeIdUsuario())!= null)
            {
                pedidos.Text += "El usuario " + modelo.nombreUsuario(modelo.mensajeIdUsuario()) + " a pedido la camiseta " + modelo.nombreCamiseta(modelo.mensajeIdCamiseta()) + " con la imagen " + modelo.nombreImagen(modelo.mensajeIdImagen()) + "\n";

            }
         

            MySqlConnection conexion = conexionBD.conexion();


            String sql = "SELECT * FROM usuario";
            MySqlCommand command = new MySqlCommand(sql, conexion);


            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            dataGrib.ItemsSource = dt.DefaultView;
            conexionBD.conexion();












        }

        private void btn5_Click(object sender, RoutedEventArgs e) {

            InicioAdmin admin = new InicioAdmin();
            admin.Show();
            this.Close();
        }
    }
}
