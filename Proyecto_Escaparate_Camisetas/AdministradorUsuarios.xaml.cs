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



            MySqlConnection conexion = conexionBD.conexion();


            String sql = "SELECT * FROM usuario";
            MySqlCommand command = new MySqlCommand(sql, conexion);


            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            dataGrib.ItemsSource = dt.DefaultView;
            conexionBD.conexion();












        }
    }
}
